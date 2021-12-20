using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blablabla
{
    internal class Program
    {

        /**
        static void Main(string[] args)
        {

            //Console.ReadLine();
           //int skaicius = 10;
           // Console.WriteLine( $"Pries:{skaicius}");
           // KeiciameArgumentus(skaicius);
           //Console.WriteLine($"Po: {skaicius}");
           // Console.ReadLine();

            string opcija2=string.Empty;    
             int skaicius = 0;
            Console.WriteLine($"Pries:{skaicius}");
            //KeiciameArgumentusPagalRef(ref skaicius);
            BilietoMeniu(ref skaicius);
             Console.WriteLine($"Po: {skaicius}");
             Console.ReadLine();
        }
        **/

        private static string[] valiutuPavadinimai = { "USD", "PLN", "BYR" };
        private static decimal[] valiutuKursai = { 1.1256m, 4.5942m, 22288.8906m }; // 2021-12-08 valiutu kursai

        static void Main(string[] args)
        {
            while (true)
            {
                string valiuta = string.Empty;
                int suma = 0;
                decimal galutineSuma = 0;
                decimal kursas = 0;

                PasirinkiteValiuta(ref valiuta, kursas, ref suma, ref galutineSuma);
            }

        }

        public static int PasirinkiteValiuta(ref string valiuta,  decimal kursas, ref int suma, ref decimal galutineSuma)
        {
            Console.WriteLine("Pasirinkite valiuta:");
            Console.WriteLine("1 - USD, 2 - PLN, 3 - BYR;");

            string pasirinkimas = Console.ReadLine();

            switch (pasirinkimas)
            {
                case "1":
                    valiuta = valiutuPavadinimai[0];
                    kursas = valiutuKursai[0];
                    KursoKeitimas(ref suma, kursas, ref galutineSuma, ref valiuta);
                    break;

                case "2":
                    valiuta = valiutuPavadinimai[1];
                    kursas = valiutuKursai[1];
                    KursoKeitimas(ref suma, kursas, ref galutineSuma, ref valiuta);
                    break;

                case "3":
                    valiuta = valiutuPavadinimai[2];
                    kursas = valiutuKursai[2];
                    KursoKeitimas(ref suma, kursas, ref galutineSuma, ref valiuta);
                    break;
            }

            return suma;

        }

        public static decimal KursoKeitimas(ref int suma, decimal kursas, ref decimal galutineSuma, ref string valiuta)
        {

            Console.WriteLine("Iveskite suma: ");

            suma = Convert.ToInt32(Console.ReadLine());
            galutineSuma = kursas * suma;

            Console.WriteLine($"Pakeista suma: {galutineSuma} {valiuta}");
            Console.ReadLine();

            return galutineSuma;
        }
    }
}
