/*
***************************************************************************************************************************

nazwa: Klasa INF04
opis: klasa służąca do ob sługi gry kości
posiadane funkcje: 3
zmienne statyczne: 2
autor: Igi 2005

***************************************************************************************************************************

nazwa: seData()
parametry: brak
opis: funkcja służąca do poprawnego wpisania liczby z zakresu <3,10>
zwracany typ: brak
autor: Igi 2005

***************************************************************************************************************************

nazwa: getData()
parametry: brak
opis: funkcja służąca do czyszczenia listy wyników z poprzedniej gry jeśli istnieje, nastepnie losuje wartosc kazdej kostki
zwracany typ: brak
autor: Igi 2005

nazwa: getSuma()
parametry: brak
opis: funkcja służąca do obliczenia sumy kości
zwracany typ: int(liczbowy)
autor: Igi 2005
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class INF04
    {

        static List<int> lista_wynikow = new List<int>();
        static int choice;

        public static void setData()
        {
            while (choice > 10 || choice < 3)
            {
                Console.WriteLine("Ile chcesz rzucic kostek z zakresu <3,10> !");
                choice = int.Parse(Console.ReadLine());
            }
        }
        public static void getData()
        {

            if(lista_wynikow.Count > 0)
            {
                lista_wynikow.Clear();
            }

            Random rnd = new Random();

             for(int i = 0; i < choice; i++)
            {
                
                int value = rnd.Next(1, 7);
                //Console.WriteLine($"{i} {value}");
                lista_wynikow.Add(value);
            }

             for (int i = 0;i < lista_wynikow.Count; i++)
            {
                Console.WriteLine("Kostka " + (i+1) + " " + lista_wynikow[i]);
                
            }
        }

        public static int getSuma()
        {
            int suma = 0;
            for(int i = 0; i < lista_wynikow.Count; i++)
            {
                int help = 0;
                for (int j = 0; j < lista_wynikow.Count; j++)
                {
                    if (lista_wynikow[i] == lista_wynikow[j])
                    {
                        help = help + 1;
                    }
                }
                if(help > 1)
                {
                    suma = suma + lista_wynikow[i];
                    //Console.WriteLine("help to " + help);
                }
            }
            return suma;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            INF04.setData();
            INF04.getData();
            Console.WriteLine("wynik to " + INF04.getSuma());
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Czy chcesz zagrac jeszcze raz (t/n)");
            char choice = char.Parse(Console.ReadLine());
            
 
            while (choice == 't')
            {
                
                INF04.getData();
                Console.WriteLine("wynik to " + INF04.getSuma());
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Czy chcesz zagrac jeszcze raz (t/n)");
                choice = char.Parse(Console.ReadLine());

            }
           
             Console.WriteLine("Koniec programu !");



            Console.ReadKey();

        }
    }
}
