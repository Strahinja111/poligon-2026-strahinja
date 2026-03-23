using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_2026_strahinja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Milos Pusic
            // Tacka prva = new Tacka();
            // Console.WriteLine(prva.d());
            /* Tacka A = new Tacka(1,2);
            Tacka B = new Tacka(2,3);
            Vektor AB = new Vektor(A,B);
            Tacka C = AB.Centriraj();
            Console.WriteLine(C.d());
            */
            /*
            Tacka A = new Tacka(3, 2);
            Tacka B = new Tacka(-2, 3);
            Tacka O = new Tacka();
            Vektor OA = new Vektor(O, A);
            Vektor OB = new Vektor(O, B);
            Console.WriteLine(Vektor.SP(OA, OB));
            Console.WriteLine(Vektor.VP(OB, OA));
            */
            tacka A = new tacka(5, 3);
            tacka B = new tacka(5, 5);
            tacka prva = new tacka(3, 2);
            tacka druga = new tacka(7, 6);
            Vektor a = new Vektor(prva, druga);
            Console.WriteLine(Ravan.SIS(a, A, B));
        }
    }
}
