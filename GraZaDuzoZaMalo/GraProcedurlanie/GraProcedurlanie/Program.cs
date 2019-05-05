using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraProceduralnie
{
    class Program
    {
        static int Losuj(int min, int max)
        {
            if(min > max)
                { //swap
                    int temp = min;
                    min = max;
                    max = temp;
                }
            Random generator = new Random();
            return generator.Next(min, max+1);;   
        }

        static int WczytajLiczbe(string prompt = "Podaj liczbę. (X aby zakończyć): ")
            {
                int liczba = 0;
                while(true)
                {
                    Console.Write(prompt);
                    string tekst = Console.ReadLine();
                    if (tekst.ToLower() == "x")
                        throw OperationCanceledException("wybrano X");

                
                    try
                    {
                        liczba = Convert.ToInt32(tekst);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nie podano liczby! Spróbuj jeszcze raz.");
                        continue;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Liczba nie mieści się w rejestrze! Spróbuj jeszcze raz.");
                        continue;
                    }
                }
                return liczba;
            }           

        static string Ocena(int propozycja)
            {
                if (propozycja < wylosowana)
                    return "za mało";
                else if (propozycja > wylosowana)
                    return "za dużo";
                else
                    return "trafiono";
            }

        static int wylosowana;

        static void Main(string[] args)
        {
            // Krok 1. Komputer losuje liczbę
            
            wylosowana = Losuj(1,100);
            Console.WriteLine("Wylosowałem liczbę od 1 do 100. \n Odgadnij ją");

#if(DEBUG)
            Console.WriteLine(wylosowana);
#endif

            //wykonuj
            bool trafiono = false; //wartownik (zwany czasami flagą)
            do
            {
                int propozycja = WczytajLiczbe("Podaj swoją propozycje. (X aby się poddać)");
                Console.WriteLine($"Przyjąłem wartość {propozycja}");

                string wynik = Ocena(propozycja);
                Console.WriteLine(wynik);
                if(wynik == "trafiono")
                    break;
            }
            while (true);
            //do momentu trafienia

            Console.WriteLine("Koniec gry");
        }
    }
}