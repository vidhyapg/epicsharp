using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiProblems
{
    /* Find x power of y.
     * */
    public class _5_7
    {
        // recursive my solution
        public static double pow(double x, long y)
        {
            double result = 1.0;

            if (y == 0)
            {
                return 1;
            }

            double ans = pow(x, y >> 1);
            result = ans * ans;
            if ((y & 1) > 0)
            {
                return x * result;
            }

            return result;
        }

        // iterative book solution: Not sure how to convert from recursive to iterative
        // is y is negative, 
        public static double pow1(double x, long y)
        {
            double result = 1.0;
            long power = y;
            if (power < 0)
            {
                x = 1.0 / x;
                power = -power;
            }

            // C# Tip: Does not evaluate to bool. Should explicitly check.
            while (power > 0)
            {
                if ((power & 1) > 0)
                {
                    result *= x;
                }
                x *= x; power >>= 1;
            }

            return result;
        }
    }
}
