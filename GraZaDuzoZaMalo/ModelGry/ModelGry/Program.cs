using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGry
{
    public class Gra
    {
        //subtypes
        public enum Odp { ZaMalo = -1, Trafiono = 0, ZaDuzo = +1}
        public enum StanGry { Trwa, Poddana, Odgadnieta}

        //fields
        public readonly int ZakresOd;
        public readonly int ZakresDo;
        private readonly int wylosowana;
        public int? Wylosowana
        {
            get
            {
                if (Stan != StanGry.Trwa)
                    return wylosowana;
                else
                    return null;
            }
        }

        public StanGry Stan { get; private set; }

        public int LicznikRuchow { get; private set; } = 0;

        //historia gry : ToDo


        //constructors
        public Gra(int min = 1 , int max = 100)
        {
            ZakresOd = min;
            ZakresDo = max;

            //losowanie
            wylosowana = Losuj(ZakresOd,ZakresDo);
        }

        //methods
        Odp Ocena(int liczba)
        {
            LicznikRuchow++;
            if (liczba < wylosowana)
                return Odp.ZaMalo;
            else if (liczba > wylosowana)
                return Odp.ZaDuzo;

            //trafiono
            Stan = StanGry.Odgadnieta;
            return Odp.Trafiono;
        }

        public void Poddaj()
        {
            Stan = StanGry.Poddana;
        }


        //auxliary methods
        public static int Losuj(int min = 1, int max = 100)
        {
            if (min > max)
            { //swap
                int temp = min;
                min = max;
                max = temp;
            }
            Random generator = new Random();
            return generator.Next(min, max + 1);
        }
    }
}
