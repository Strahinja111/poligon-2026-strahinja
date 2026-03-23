using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_2026_strahinja
{
    internal class Vektor
    {
        public tacka pocetak, kraj;
        public Vektor(tacka A, tacka B)
        {
            pocetak = A;
            kraj = B;
        }
        public tacka Centriraj()
        {
            tacka Nova = new tacka(kraj.x - pocetak.x, kraj.y - pocetak.y);
            return Nova;
        }
        public static double SP(Vektor a, Vektor b)
        {
            tacka aC = a.Centriraj();
            tacka bC = b.Centriraj();
            return aC.x * bC.x + aC.y * bC.y;
        }
        public static double VP(Vektor a, Vektor b)
        {
            tacka aC = a.Centriraj();
            tacka bC = b.Centriraj();
            return aC.x * bC.y - bC.x * aC.y;
        }
    }
}
