namespace EpiProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    static class Helper
    {
        public static byte[] ToByteArray(this string str)
        {
            return System.Text.Encoding.ASCII.GetBytes(str);
        }

        public static void PrintByteArray(byte[] b_byte)
        {
            StringBuilder sb = new StringBuilder("byte array [ ");
            foreach (var b in b_byte)
            {
                sb.Append(b + " ,");
            }
            sb.Append(" ]");
            Console.WriteLine(sb.ToString());
        }
    }

    public class _5_1
    {
        // Find parity of a very large number of 64 bit words.
        // if number of 1s is odd, then parity is 1, else 0.
        // My solution
        private static int FindParity(BigInteger b_int)
        {
            StringBuilder sb = new StringBuilder();
            byte[] b_array = b_int.ToByteArray();
            bool r_byte_p = false;
            
            foreach(var l_b in b_array)
            {
                
                byte b = l_b;
                bool c_byte_p = false;
                while (b > 0)
                {
                    sb.Insert(0,((b & 0x1)));
                    c_byte_p ^= ((b & 0x1) != 0);
                    b = (byte) (b >> 1);
                }
                r_byte_p ^= c_byte_p;
            }
            Console.WriteLine("The Number in Binary is: "+ sb.ToString());
            return r_byte_p ? 1:0;       
        }

        public static int FindParity(string input)
        {
            return FindParity(BigInteger.Parse(input, System.Globalization.NumberStyles.Integer));
        }

        // Book solution 1. Brute force
        public static int FindParity_1(ulong input)
        {
            short parity = 0;
            while(input > 0)
            {
                parity ^= (short)(input & 1);
                input >>= 1;
            }
            return parity;
        }

        // Book Solution 2. Parallel XOR and look up 4 bits. 
        // Order of XOR should not matter. 
        public static int FindParity_2(ulong input)
        {
            // Parallel XOR first 32 bits and last 32 bits, remaining 32 bits
            input ^= input >> 32;
            // Parallel XOR first 16 bits and last 16 bits, remaining 16 bits
            input ^= input >> 16;
            // Parallel XOR first 8 bits and last 8 bits, remaining 8 bits
            input ^= input >> 8;
            // Parallel XOR first 4 bits and last 4 bits, remaining 4 bits
            input ^= input >> 4;
            input &= 0xf;

            // Look up table for parity of 0 to 16
            // ‭0110100110010110‬
            int lookup = 0x6996;
            return (lookup >> (int)input) & 1;
        }

    }
}
