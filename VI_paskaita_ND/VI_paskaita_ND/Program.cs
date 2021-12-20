using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VI_paskaita_ND
{
    internal class Program
    {

        private static readonly string[] validOperators = { "1", "2", "3" };

        private static int sukurtiBilietaiUzDesimt = 0;

        private static int sukurtiBilietaiUzDvidesimt = 0;

        private static int sukurtiBilietaiUzTrisdesimt = 0;

        private static int parduotiBilietaiUzDesimt = 0;

        private static int parduotiBilietaiUzDvidesimt = 0;

        private static int parduotiBilietaiUzTrisdesimt = 0;



        static void Main(string[] args)
        {
            while (true)
            {
                Meniu();
            }

        }

        public static void Meniu()
        {
            int kaina = 0;
            int kiekis = 0;

            Console.WriteLine("Bilietavimo sistema. Pasirinkite norimą opciją:");
            Console.WriteLine("[1] -Parduoti bilietus; [2] -Kurti bilietus; [3] -Ataskaita apie pardavimus; [q] -Išeiti iš sistemos;");

            string opcija = GetOperator();

            switch (opcija)
            {
                case "1":
                    ParduotiBilieta(ref  kiekis, ref kaina, ref parduotiBilietaiUzDesimt, ref parduotiBilietaiUzDvidesimt, ref parduotiBilietaiUzTrisdesimt);
                    break;

                case "2":
                    SukurtiBilieta (ref kiekis, ref kaina, ref sukurtiBilietaiUzDesimt, ref sukurtiBilietaiUzDvidesimt, ref sukurtiBilietaiUzTrisdesimt);
                    break;

                case "3":
                    Ataskaita();
                    break;
            }
        }


        public static int BilietoMeniu(ref int kaina)
        {

            Console.WriteLine("Pasirinkite bilieto tipą:");
            Console.WriteLine("[1] -Po 10 eurų; [2] -Po 20 eurų; [3] -Po 30 eurų; [q] -Išeiti iš sistemos;");

            
            string opcijaKaina = GetOperator();

            switch (opcijaKaina)
            {
                case "1":
                    kaina = 10; 
                    break;

                case "2":
                    kaina = 20;
                    break;

                case "3":
                    kaina = 30;
                    break;
            }

            return kaina;
        }


        private static int GetNumberFromConsole()
        {
            bool isCorrectNumer = false;
            int argumentValue = 0;

            while (!isCorrectNumer)
            {

                string userInputValue = Console.ReadLine();
                CheckApplicationExit(userInputValue);

                if (int.TryParse(userInputValue, out argumentValue))
                {
                    isCorrectNumer = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            return argumentValue;
        }

        public static void ParduotiBilieta( ref int kiekis, ref int kaina, ref int parduotiBilietaiUzDesimt, ref int parduotiBilietaiUzDvidesimt, ref int parduotiBilietaiUzTrisdesimt)
        {
                Ivestis(ref kiekis, ref kaina);
                if (kaina == 10)
                {
                    parduotiBilietaiUzDesimt += kiekis;

                }
                else if (kaina == 20)
                {
                    parduotiBilietaiUzDvidesimt += kiekis;

                }
                else
                {
                    parduotiBilietaiUzTrisdesimt += kiekis;
                }
            }

        


        public static void SukurtiBilieta(ref int kiekis, ref int kaina, ref int sukurtiBilietaiUzDesimt, ref int sukurtiBilietaiUzDvidesimt, ref int sukurtiBilietaiUzTrisdesimt)
        {
                Ivestis(ref kiekis, ref kaina);
                if (kaina == 10)
                {
                    sukurtiBilietaiUzDesimt += kiekis;

                }
                else if (kaina == 20)
                {
                    sukurtiBilietaiUzDvidesimt += kiekis;

                }
                else
                {
                    sukurtiBilietaiUzTrisdesimt += kiekis;
                }
        }


        public static void Ivestis(ref int kiekis, ref int kaina)
        {
            BilietoMeniu(ref kaina);

            Console.WriteLine("Įveskite norimą kiekį:");
            kiekis = GetNumberFromConsole();
            Console.WriteLine($"Jūs sukūrėte/pardavėte {kiekis} bil. po {kaina} eurų.");

        }

        public static void Ataskaita()
        {
            Console.WriteLine($"Bilietų po 10 eurų iš viso sukurta: {sukurtiBilietaiUzDesimt}");
            Console.WriteLine($"Bilietų po 20 eurų iš viso sukurta: {sukurtiBilietaiUzDvidesimt}");
            Console.WriteLine($"Bilietų po 30 eurų iš viso sukurta: {sukurtiBilietaiUzTrisdesimt}");
            Console.WriteLine($"Bilietų po 10 eurų iš viso parduota: {parduotiBilietaiUzDesimt}");
            Console.WriteLine($"Bilietų po 20 eurų iš viso parduota: {parduotiBilietaiUzDvidesimt}");
            Console.WriteLine($"Bilietų po 30 eurų iš viso parduota: {parduotiBilietaiUzTrisdesimt}");

            int nepanaudotiPoDesimt = sukurtiBilietaiUzDesimt - parduotiBilietaiUzDesimt;
            int nepanaudotiPoDvidesimt = sukurtiBilietaiUzDvidesimt - parduotiBilietaiUzDvidesimt;
            int nepanaudotiPoTrisdesimt = sukurtiBilietaiUzTrisdesimt - parduotiBilietaiUzTrisdesimt;

            Console.WriteLine($"Nepanaudoti bilietai po 10: {nepanaudotiPoDesimt}");
            Console.WriteLine($"Nepanaudoti bilietai po 20: {nepanaudotiPoDvidesimt}");
            Console.WriteLine($"Nepanaudoti bilietai po 30: {nepanaudotiPoTrisdesimt}");
        }
    

     
       

        private static string GetOperator()
        {
            bool isCorrecOperator = false;
            string operatorValue = string.Empty;

            while (!isCorrecOperator)
            {

                
                string input = Console.ReadLine();

                CheckApplicationExit(input);
                if (IsOperatorValid(input))
                {
                    operatorValue = input;
                    isCorrecOperator = true;
                }
                else
                {
                    Console.WriteLine("Klaidingas pasirinkimas.");
                }
            }

            return operatorValue;
        }

       

        private static bool IsOperatorValid(string operatorValue)
        {
            return validOperators.Contains(operatorValue);
        }
        private static void CheckApplicationExit(string userInputValue)
        {
            if (userInputValue.Equals("q", StringComparison.OrdinalIgnoreCase))
            {
                CloseApplication();
            }
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


