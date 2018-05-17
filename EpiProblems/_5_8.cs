using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiProblems
{
    public class _5_8
    {

        // 0 to 9 -> same
        // 10 to 15 -> A to F
        // anything else error
        private static char IntToChar(int i)
        {
            if( (10<=i) && (i >= 15))
            {
                return 'A';
            }
        }
        // convert A to F as 10 to 15
        private static int CharToInt(char i)
        {
            // assign char to int converts to its ascii value
            int d = i;
            if (('A' <= i) && (i <= 'F'))
            {
                d -= ('A' - 10);
            }
            else if (('0' <= i) && (i <= '9'))
            {
                d -= '0';
            }
            else
            {
                throw new ArgumentException("Invalid Input char contains digits other than '0-9' and 'A-Z': " + i);
            }
            return d;
        }
        public static string ConvertFromDecimal(int val, int b)
        {
            StringBuilder sb = new StringBuilder();
            while(val > 0)
            {
                sb.Insert(0, IntToChar((val % b)), 1);
                val /= b;
            }
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }
        // s = "7FF" = (16^2 * 7 + 16^1 * 15 + 16^0 * 15)
        private static int ConvertToDecimal(string s, int b)
        {
            int sum = 0;
            char[] c_s = s.ToCharArray();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sum += CharToInt(c_s[i]) * (int)Math.Pow(b, (s.Length-1 -i));
                Console.WriteLine(sum);
            }
            Console.WriteLine(sum);
            return sum;
        }
        public static string ConvertBase(string s, int b1, int b2)
        {
            return ConvertFromDecimal(ConvertToDecimal(s, b1), b2);
        }
    }
}
