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

    public class _5
    {
        // Find parity of a very large number of 64 bit words.
        // if number of 1s is odd, then parity is 1, else 0.
        private static bool FindParity(BigInteger b_int)
        {
            byte[] b_byte = b_int.ToByteArray();
            Helper.PrintByteArray(b_byte);

            bool parity = false;
            foreach (var b in b_byte)
            {
                bool b_parity = false;
                byte l_b = b;
                while (l_b != 0)
                {
                    Console.WriteLine(l_b + "last bit is :" + (l_b & 0x1));
                    b_parity ^= ((b & 0x1) != 0);
                    l_b = (byte)((l_b >> 1));
                }
                Console.WriteLine("Parity of " + b + " is: " + Convert.ToInt16(b_parity));
                parity ^= b_parity;
            }

            return parity;
        }

        public static bool FindParity(string input)
        {
            return FindParity(BigInteger.Parse(input, System.Globalization.NumberStyles.Integer));
        }
    }
}
