using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VI_paskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //NupiestiRemeli(10);
            //NupiestiRemeli(100);
            //NupiestiRemeli(600);
            //NupiestiRemeli(50);

            //Console.ReadLine();
            //int skaicius = 10;
            //Console.WriteLine( $"Pries:{skaicius}");
            //KeiciameArgumentus(skaicius);
            //Console.WriteLine($"Po: {skaicius}");
            //Console.ReadLine();


            // int skaicius = 10;
            //Console.WriteLine($"Pries:{skaicius}");
            // KeiciameArgumentusPagalRef(ref skaicius);
            // Console.WriteLine($"Po: {skaicius}");
            // Console.ReadLine();



            //int suma = CalculateSumRecursively(1, 3);
            //int suma2 = CalculateSumRecursively(2, 3);
            //int suma3 = CalculateSumRecursively(3, 3);


            //VardoIsvedimas( "Vaidotas", 5);

            // VardoIsvedimas();

            // Simboliai("Vaidotas");


            // KMI (82, 1.82);


            Tarpai("Aantanas Nakas");

            Console.ReadLine();


        }




        #region metodu perkovimas
        private static void NupiestiRemeli(int remelioIlgis)
        {

            int kiekRemelioSImboliuNupiesti = remelioIlgis;
            string remoSimbolis = "*";
            string tarpelioSimbolis = " ";

            //nupiesiame virstutine eilute
            for (int i = 0; i < kiekRemelioSImboliuNupiesti; i++)
            {
                Console.Write(remoSimbolis);
            }

            Console.WriteLine();

            //vidurine eilute
            Console.Write("{0}{1}{2}", remoSimbolis, tarpelioSimbolis, kiekRemelioSImboliuNupiesti);
            int skaiciausIlgis = kiekRemelioSImboliuNupiesti.ToString().Length;
            int kiekTarpuPraleisti = remoSimbolis.Length * 2 + skaiciausIlgis + tarpelioSimbolis.Length;

            for (int i = kiekTarpuPraleisti; i < kiekRemelioSImboliuNupiesti; i++)
            {
                Console.Write(tarpelioSimbolis);
            }
            Console.Write(remoSimbolis);

            Console.WriteLine();

            //apatine eilute 

            for (int i = 0; i < kiekRemelioSImboliuNupiesti; i++)
            {
                Console.Write(remoSimbolis);
            }

            Console.WriteLine();




        }
        #endregion

        /// metode skaiciavimas yra lokalus

        #region REF
        private static void KeiciameArgumentus(int skaicius)
        {
            skaicius = skaicius + 10;
            Console.WriteLine($"Pakeistas skaicius: {skaicius}");
        }

        private static void KeiciameArgumentusPagalRef(ref int skaicius)
        {
            skaicius = skaicius + 10;
            Console.WriteLine($"Pakeistas skaicius: {skaicius}");
        }

        #endregion

        #region metodas kuris call`ina save (metodas metoda)
        private static int CalculateSumRecursively (int n, int m) //metodas kuris call`ina save (metodas metoda)
        {
            int sum = n;
            if (n<m)
                {
                n++;
                return sum += CalculateSumRecursively(n, m);
            }
            return sum;
        }
        #endregion 



        private static void VardoIsvedimas()
        {
            string vardas = "Vaidotas";
            Console.WriteLine(vardas);
        }

        private static void VardoIsvedimas( string vardas, int kartai)
        {
            for (int i = 0; i < kartai; i++)
            {
                Console.WriteLine(vardas);
            }

            
        }

        private static void Simboliai(string inputas)
        {





            for (int i = 0; i < inputas.Length; i++)

            {
                Console.Write("#");
            }

        }

            private static void KMI ( double mase, double ugis)
            {

                double KMI = mase / ( ugis*ugis);

                Console.WriteLine($"Jūsų kūno masės indeksas yra: {KMI}");    
            
            }


        private static int Tarpai(string sakinys)

        {
            int tarpai = sakinys.Count(Char.IsWhiteSpace);
            Console.WriteLine($"Sakinyje {sakinys} yra {tarpai} tarpai/tarpų.");
            return tarpai;
        }



    }
}
