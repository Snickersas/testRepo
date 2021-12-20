using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    public struct Mokinys
    {
        public static List<int> Trimestras = new List<int> { 5, 7, 3, 9, 8 };
        public static List<int> Trimestras2 = new List<int> { 7, 8, 10, 10, 9, 8 };
        public static List<int> Trimestras3 = new List<int> { 8, 8, 10, 10, 5, 8 };

        public Mokinys(List<int> trimestras, List<int> trimestras2, List<int> trimestras3)
        {
            Trimestras = trimestras;
            Trimestras2 = trimestras2;
            Trimestras3 = trimestras3;
        }

        public static string Menu()
        {
            Console.WriteLine("Sveiki! Kokį veiksmą norėtumėte atlikti?");
            Console.WriteLine("[1] -Pirmo vidurkis; [2] -Antro vidurkis; [3] -Trečio vidurkis; [4] -Metinis vidurkis; [5] -Pridėti pažymį; [6] -Ištrinti pažymį.");

            double vidurkisMetinis = 0;
            string pasirinkimas = Console.ReadLine();


            switch (pasirinkimas)
            {
                case "1":
                    Skaiciavimas(Trimestras);
                    break;

                case "2":
                    Skaiciavimas(Trimestras2);
                    break;

                case "3":
                    Skaiciavimas(Trimestras3);
                    break;

                case "4":
                    vidurkisMetinis = (Skaiciavimas(Trimestras) + Skaiciavimas(Trimestras2) + Skaiciavimas(Trimestras3)) / 3;
                    Console.WriteLine($"Metinis vidurkis yra: {vidurkisMetinis}");
                    break;

                case "5":
                    PridejimoTrimestruMenu();
                    break;

                case "6":
                    TrinimoTrimestruMenu();
                    break;

            }
            return pasirinkimas;

        }

        private static double Skaiciavimas(List<int> trimestras)
        {
            Console.WriteLine($"Vidurkis yra: {trimestras.Average()}");
            return trimestras.Average();
        }

        private static double Trinimas(List<int> trimestras)
        {
            TrimestroPazymiai(trimestras);
            Console.WriteLine("\n");
            Console.WriteLine("Pasirinkite kurį elementą/pažymį norite ištrinti:");
            int istrintasPazymys = Convert.ToInt32(Console.ReadLine());
            trimestras.Remove(istrintasPazymys);
            return trimestras.Average();
        }

        private static double Pridejimas(List<int> trimestras)
        {
            TrimestroPazymiai(trimestras);
            Console.WriteLine("\n");
            Console.WriteLine("Jūs pasirinkote variantą pridėti:");
            Console.WriteLine("Pasirinkite kurį elementą/pažymį norite pridėti:");
            int pridetasPazymys = Convert.ToInt32(Console.ReadLine());
            trimestras.Add(pridetasPazymys);
            return trimestras.Average();
        }

       // private static double Veiksmai(List<int> trimestras, string veiksmas)
       // {
       //     TrimestroPazymiai(trimestras);
       //     Console.WriteLine("\n");
       //     Console.WriteLine("Pasirinkite kurį pažymį norite ištrinti/pridėti:");
       //     int pridetasPazymys = Convert.ToInt32(Console.ReadLine());
       //     trimestras.veiksmas(pridetasPazymys);
       //     return trimestras.Average();
       // }

        public static string TrinimoTrimestruMenu()
        {
            Console.WriteLine("Kuriame trimestre norite atlikti veiksmus?");
            Console.WriteLine("[1] -Pirmo; [2] -Antro; [3] -Trecio.");

            string pasirinkimasDu = Console.ReadLine();

            switch (pasirinkimasDu)
            {
                case "1":
                    Trinimas(Trimestras);
                    break;

                case "2":
                    Trinimas(Trimestras2);
                    break;

                case "3":
                    Trinimas(Trimestras3);
                    break;

            }
            return pasirinkimasDu;
        }

        public static string PridejimoTrimestruMenu()
        {
            Console.WriteLine("Kuriame trimestre norite atlikti veiksmus?");
            Console.WriteLine("[1] -Pirmo; [2] -Antro; [3] -Trecio.");

            string pasirinkimasDu = Console.ReadLine();

            switch (pasirinkimasDu)
            {
                case "1":
                    Pridejimas(Trimestras);
                    break;

                case "2":
                    Pridejimas(Trimestras2);
                    break;

                case "3":
                    Pridejimas(Trimestras3);
                    break;

            }
            return pasirinkimasDu;
        }

        public static void TrimestroPazymiai(List<int> trimestras)
        {
            Console.WriteLine("Trimestrą sudarantys pažymiai:");

            foreach (int pazymys in trimestras)
            {
                Console.Write($"{pazymys} ");
            }

        }
            



    }
}
