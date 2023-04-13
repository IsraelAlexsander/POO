using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class xRaizes : xDelta
    {
        public double raiz1 { get; set; }
        public double raiz2 { get; set; }

        public void calcRaizes(double a, double b, double c)
        {
            calcDelta(a, b, c);

            if (delta >= 0)
            {
                this.raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                this.raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
            }
        }
    }
}
