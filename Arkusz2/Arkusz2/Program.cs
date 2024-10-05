using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
*******************************************************************************************************************************
nazwa funkcji: pobierzPese
opis funkcji: Funkcja ta pobiera 11 kolejnych liczb składających sie na pesel uzytkownika.
parametry: brak
zwracany typ i opis: brak
autor: Igi 2005
*******************************************************************************************************************************
*******************************************************************************************************************************
nazwa funkcji: sprawdzPlec 
opis funkcji: Funkcja ta sprawdza płeć na podstawie danych podanych przez użytkownika
parametry: _pesel i jest to tablica liczb całkowitych
zwracany typ i opis: funkcja zwraca typ znakowy M lub K w zależności od płci użytkownika
autor: Igi 2005
*******************************************************************************************************************************
*******************************************************************************************************************************
nazwa funkcji: sprawdzSume 
opis funkcji: Funkcja ta oblicza poprawność identyfikatora PESEL
parametry: _pesel i jest to tablica liczb całkowitych
zwracany typ i opis: funkcja zwraca typ logiczny true gdy podana suma sie zgadza lecz w przeciwnym wypadku zwraca false
autor: Igi 2005
*******************************************************************************************************************************
*/


namespace Arkusz2
{

    internal class Pesel
    {
        public static int[] pesel = new int[11];

        public static void pobierzPesel()
        {
            for(int i = 0; i < 11;i++)
            {
                Console.Write("Wpisz [" + (i+1) + "] numer peselu - ");
                pesel[i] = int.Parse(Console.ReadLine());
            }
        }

        public static char sprawdzPlec(int[] _pesel)
        {
            int[] peselIn = _pesel;
            int plec = peselIn[9];
            if(plec%2 == 0) { return 'K'; }
            else { return 'M'; }
        }

        public static bool sprawdzSume(int[] _pesel)
        {
            int[] peselIn = _pesel;
            int[] wagi = { 1,3,7,9,1,3,7,9,1,3};
            int S = 0;

            for(int i = 0;i < wagi.Length; i++)
            {
                S = S + (peselIn[i] * wagi[i]);
            }
            int m = S % 10;
            int r;
            if(m == 0)
            {
                r = 0;
            }
            else
            {
                r = 10 - m;
            }

            if(r == peselIn[10])
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            Pesel.pobierzPesel();
            if(Pesel.sprawdzPlec(Pesel.pesel) == 'K')
            {
                Console.WriteLine("Kobieta");
            }
            else
            {
                Console.WriteLine("Mezczyzna");
            }
            if(Pesel.sprawdzSume(Pesel.pesel))
            {
                Console.WriteLine("Wszystko sie zgadza");
            }
            else
            {
                Console.WriteLine("podane dane sie nie zgadzają");
            }
            Console.ReadKey();
        }
    }
}
