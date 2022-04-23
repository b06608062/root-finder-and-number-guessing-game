using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace root_finder_and_number_guessing_game
{
    internal class RootFinder
    {
        //data members
        double x0, x1, x2;

        //member methods
        public void Set(double a, double b, double c)
        {
            (x0, x1, x2) = (c, b, a);
        }

        public string FindRoot()
        {
            string result;
            double discriminant;
            double r1, r2, g1;
            if (x2 == 0)
            {
                if (x1 == 0)
                {
                    if (x0 == 0)
                    {
                        result = "Extremely degenerate!";
                    }
                    else
                    {
                        result = "No Solution!";
                    }
                }
                else
                {
                    r1 = -x0 / x1;
                    result = $"Degenerate:\r\nX = {r1}";
                }
            }
            else
            {
                discriminant = x1 * x1 - 4 * x2 * x0;
                if (discriminant >= 0)
                {
                    r1 = (-x1 + Math.Sqrt(discriminant)) / (2 * x2);
                    r2 = (-x1 - Math.Sqrt(discriminant)) / (2 * x2);
                    result = $"Multiple real roots:\r\nRoot1 = {r1}\r\nRoot2 = {r2}";
                }
                else
                {
                    r1 = -(x1 / (2 * x2));
                    g1 = Math.Sqrt(-discriminant) / (2 * x2);
                    result = $"Two complex roots:\r\nRoot1 = {r1} + {g1}i\r\nRoot2 = {r1} - {g1}i";
                }

            }

            return result;
        }
    }
}
