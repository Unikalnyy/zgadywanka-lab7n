using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGry
{
    public class Gra
    {
        int ZakresOd;
        int ZakresDo;
        int wylosowana;

        public Gra(int min = 1 , int max = 100)
        {
            ZakresOd = min;
            ZakresDo = max;

            //losowanie
            wylosowana = Losuj(min,max);

        }
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
