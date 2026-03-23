using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_2026_strahinja
{
    internal class tacka
    {
        // ovo sam upravo dodao. Ja.
        public double x, y;
        public tacka()
        {
            x = 0; y = 0;
        }
        public tacka(double a, double b)
        {
            x = a;
            y = b;
        }
        public double d()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
