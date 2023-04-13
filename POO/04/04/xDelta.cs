using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class xDelta
    {
        public double delta { get; set; }
        protected void calcDelta(double a, double b, double c)
        {
            this.delta = Math.Pow(b, 2) - 4 * a * c;
        }
    }
}
