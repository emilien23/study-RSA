using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;

namespace RSA
{
    class Controller
    {
        static FileStream fin;
        
        public  void startRSA(BigInteger p, BigInteger q)
        {

            BigInteger n = p*q;
            BigInteger nEl = (p - 1) * (q - 1);
            BigInteger e = generateE(nEl);
            BigInteger d = 0, y = 0;

            AlgEv(e, nEl,ref d,ref y);

            if (d < 0)
                d += nEl; 

            Console.WriteLine("Public key(n,e): (" + n + ", " + e + ")");
            Console.WriteLine("Private key(fi(n),d): (" + nEl + ", " + d + ")");
            Console.WriteLine();


            List<String> blocksText = readTextFile("C:/bible.txt", 10);
            
            List<BigInteger> blocksBigInt = encrypto(blocksText,e,n);
            Console.WriteLine("Crypto completed: " + writeCipherToFile(blocksBigInt, "crypto.txt"));
            
            List<BigInteger> blocksCipher = readCipherFile("crypto.txt");
            Console.WriteLine("Decrypto completed: " + decrypto(blocksCipher,"decrypto.txt" , d, n));
        }
        public  List<String> readTextFile(String path, Int32 sizeBlocks)
        {
            fin = new FileStream(path, FileMode.Open);
            
            
            StreamReader reader = new StreamReader(fin);
            String str = reader.ReadToEnd();
    
            List<String> blocksText = new List<String>();

            for (int i = 0; i < str.Length; i += sizeBlocks)
                if (i + sizeBlocks < str.Length)
                    blocksText.Add(str.Substring(i, sizeBlocks));
                else
                    blocksText.Add(str.Substring(i, str.Length - i));
            
            fin.Close();
            return blocksText;
        }
        public  List<BigInteger> readCipherFile(String path)
        {
            fin = new FileStream(path, FileMode.Open);

            List<BigInteger> blocksCipher = new List<BigInteger>();

            using (StreamReader fs = new StreamReader(fin))
            {
                while (true)
                {
                    String str = fs.ReadLine();

                    if (str == null) break;                  
                    
                    blocksCipher.Add(BigInteger.Parse(str));           
                }
            }
            
            fin.Close();
            return blocksCipher;
        }
        public  bool decrypto(List<BigInteger> blocksBigInt, String path, BigInteger d, BigInteger n)
        {

            StreamWriter writer = new System.IO.StreamWriter(path, true);
            
            
            List<char> blocksString = new List<char>();
            blocksBigInt.ForEach(delegate(BigInteger bigInt)
            {
                String s = fastPow(bigInt, d, n).ToString();
                
                if(s.Length % 3 == 1)
                    s = "00" + s;
                if (s.Length % 3 == 2)
                    s= "0" + s;

                for (int i = 0; i < s.Length; i += 3)
                    writer.Write((char)Int32.Parse(s.Substring(i, 3)));
            });
            writer.Close();

            return true;
        }
        public  bool writeCipherToFile(List<BigInteger> blocksBigInt, String path)
        {
            StreamWriter fstream = new StreamWriter(path);
            blocksBigInt.ForEach(delegate(BigInteger bigint)
            {
                fstream.WriteLine(bigint.ToString(), 0, bigint.ToString().Length);
            });
            fstream.Close();
            return true;
        }
        public  List<BigInteger> encrypto(List<String> blocksText, BigInteger e, BigInteger n)
        {
            
            List<BigInteger> blocksBigInt = new List<BigInteger>();
            blocksText.ForEach(delegate(String s)
            {
                
                char[] charr = s.ToCharArray();
                String str = null;
                for (int i = 0; i < charr.Length; i++)
                {
                    if ((int)charr[i] < 10)
                        str += "00" + ((int)charr[i]).ToString();
                    else if ((int)charr[i] < 100)
                            str += '0' + ((int)charr[i]).ToString();
                         else
                            str += ((int)charr[i]).ToString();
                }
                blocksBigInt.Add(fastPow(BigInteger.Parse(str), e, n));

            });
            return blocksBigInt;
        }
        public  BigInteger generateE(BigInteger nEl)
        {
            BigInteger e;

            Int32 eLen = (nEl).ToString().Length/3;
            do
            {
                e = RandomIntegerBelow(new BigInteger(Math.Pow(10,eLen)));
            }while(e == 1 || gcd(e,nEl) != 1 || Math.Abs(eLen - e.ToString().Length) > 3);
           
            return e;
        }
        public  BigInteger AlgEv(BigInteger a, BigInteger b, ref BigInteger x, ref BigInteger y)
        {
            if (a == 0)
            {
                x = 0; y = 1;
                return b;
            }
            BigInteger x1 = 0, y1 = 0;
            BigInteger d = AlgEv(b % a, a, ref  x1, ref  y1);

            x = y1 - (b / a) * x1;
            y = x1;

            return d;
        }
        public  BigInteger gcd(BigInteger a, BigInteger b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }
        public  BigInteger generateSimple(BigInteger border)
        {

            bool flag = false;
            BigInteger simple = 1;
            int k = 0;
            simple = RandomIntegerBelow(border);
            do
            {
             
                simple += k;
                
                flag = testMillerRabin(simple, (int)BigInteger.Log(simple,2));
                k += 2;
            }
            while (!flag || simple < 1000000);
            return simple;
        }
        public  bool testMillerRabin(BigInteger n, int k)
        {
       
            if (n % 2 == 0)
                return false;

            BigInteger s = 0, d = n - 1;

            while (d % 2 == 0) //разложение на 2^s * d
            {
                d /= 2;
                s++;
            }
            if (d % 2 == 0)
                return false;

            for (int i = 0; i < k; i++)
            {
                BigInteger a = RandomIntegerBelow(n - 1); //рандомный a
                if (n % a == 0)
                    return false;
                BigInteger b = fastPow(a, d, n);
                if (b == 1 || b == n - 1)
                    continue;
                for (int j = 0; j < s; j++)
                {
                    b = fastPow(b, b, n);
                    if (b == 1)
                        return false;
                    if (b == n - 1)
                        continue;
                }
                if (b != n - 1)
                   return false;
            }
            return true;
        }
        public  BigInteger RandomIntegerBelow(BigInteger N)
        {
            byte[] bytes = N.ToByteArray();
            BigInteger R;
            Random rnd = new Random();
            do
            {
                rnd.NextBytes(bytes);
                bytes[bytes.Length - 1] &= (byte)0x7F;
                R = new BigInteger(bytes);
            } while (R >= N);
            if (R % 2 == 0) //для нечетного
                return R++;
            return R;
        }        
        public  BigInteger fastPow(BigInteger a, BigInteger b, BigInteger n)
        {
            String bBin = toBinary(b);
            StringBuilder strBuild = new StringBuilder(bBin);
            char[] ch = bBin.ToCharArray(0, bBin.Length);
            BigInteger[] c = new BigInteger[ch.Length];
            c[0] = a;
            for (int i = 1; i < c.Length; i++)
                if (ch[i].Equals('1'))
                    c[i] = (c[i - 1] * a * c[i - 1]) % n;
                else
                    c[i] = (c[i - 1] * c[i - 1]) % n;
            return c[c.Length - 1];
        }
        public  String toBinary(BigInteger b)
        {
            List<BigInteger> d = new List<BigInteger>();
            d.Add(b % 2);
            b = b / 2;
            while (b != 0)
            {
                d.Add(b % 2);
                b = b / 2;
            }
            String str = "";
            foreach (BigInteger entry in d)
            {
                str += entry;
            }
            return str.Reverse().Aggregate(string.Empty, (acc, ch) => acc + ch);
        }
    }
}
