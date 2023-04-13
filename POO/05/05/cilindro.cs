using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class cilindro : circulo
    {                
        public double calcVolume(double altura, double raio)
        {
            return calcArea(raio) * altura;
        }
    }
}
