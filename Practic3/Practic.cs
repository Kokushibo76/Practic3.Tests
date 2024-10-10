using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic3
{
    public class Practic
    {
        public static (double? root1, double? root2) FindRoots(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;

            if (D < 0)
            {
                return (null, null);
            }
            else if (D == 0)
            {
                double root = -b / (2 * a);
                return (root, root);
            }
            else
            {
                double root1 = (-b + Math.Sqrt(D)) / (2 * a);
                double root2 = (-b - Math.Sqrt(D)) / (2 * a);
                return (root1, root2);
            }
        }

        public static double CalculatePercentage(double number, double percent)
        {
            return number * percent / 100;
        }
    }
}