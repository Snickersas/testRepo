using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiniguKonvertavimas
{
    public class Program
    {

        private static string[] valiutos =
            {
            "USD",
            "PLN",
            "BYR"
            };

        private static decimal[] kursai =
            {
             1.13m,
             4.59m,
             2.88m,
            };

        static void Main(string[] args)
        {
            while (true)
            {
                PiniguKonvertavimas();
            }
        }

        public static int PiniguKonvertavimas( )
        {
            

            Console.WriteLine("Sveiki! Pasirinkite į kurią valiutą norėtumėte konvertuoti:");
            Console.WriteLine("[1] -USD; [2] -PLN; [3] -BYR; [4] -Išeiti iš sistemos!");



            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    
                    Konvertavimas(ref pasirinkimas);
                    break;

                case 2:
                    
                    Konvertavimas(ref pasirinkimas);
                    break;

                case 3:
                    
                    Konvertavimas(ref pasirinkimas);
                    break;

                case 4:
                    CloseApplication();
                    break;
            }

            return pasirinkimas;
            
        }

        public static decimal Konvertavimas(ref int pasirinkimas)
            {

            decimal kursas = kursai[pasirinkimas - 1];
            string valiuta = valiutos[pasirinkimas - 1];

            Console.WriteLine("Įveskite eurų kiekį:");

            int kiekis = Convert.ToInt32(Console.ReadLine());

            decimal pinigai = kursas * kiekis;

            Console.WriteLine($"Jums priklauso: {pinigai} {valiuta}");

            return pinigai;
        }

        

        private static void CloseApplication()
        {
            Console.WriteLine("Viso gero!");
            Console.WriteLine("Press any key to close application....");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }

}
