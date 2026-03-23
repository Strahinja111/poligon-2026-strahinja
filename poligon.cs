using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_2026_strahinja
{
    internal class poligon
    {
        public int br_temena;
        public tacka[] teme;
        public poligon(int n)
        {
            br_temena = n;
            teme = new tacka[n];
        }
        public static poligon unos()
        {
            Console.WriteLine("koliko temena");
            int n=Convert.ToInt32(Console.ReadLine());
            poligon novi = new poligon(n);
            for (int i = 0; i < n; i++)
            {
                novi.teme[i] = new tacka();
                Console.WriteLine("x koord tacke {0}=", i + 1);
                novi.teme[i].x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("y koord tacke {0}=", i + 1);
                novi.teme[i].y = Convert.ToDouble(Console.ReadLine());
            }
            return void;
        }
        public void stampa()
        {
            
        }
        public void snimi()
        {
            
        }
        public static poligon ucitaj()
        {
            return null;
        }
    }
}
