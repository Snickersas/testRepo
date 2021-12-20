using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VII_Paskaita
{
    public class Program
    {

        //unitestai 7 paskaita

        /**
         #region
        public struct Zmogus
        {
            public string Vardas;
            public string Pavarde;
            public int Amzius;


            public Zmogus(string vardas,string pavarde, int amzius)  //ctor 2kart tab konstruktorius
            {
                Vardas = vardas; 
                Pavarde = pavarde;
                Amzius = amzius;
            }

            public void PasakytiVarda()
            {
                Console.WriteLine($"Mano vardas: {Vardas}");
                Console.ReadLine();
            }
        }


        static void Main(string[] args)
        {

            Zmogus zmogus;
            zmogus.Vardas = "Jonas";
            zmogus.Pavarde = "Jonauskas";
            zmogus.Amzius = 18;

            Zmogus zmogus1 = new Zmogus("Jurgis", "Jonauskas", 25);


          // zmogus.PasakytiVarda();

            zmogus1.PasakytiVarda();


            //struktas yra value tipo, tiesgioai storinamas kintamasis

            #endregion
        }
        **/
        static void Main(string[] args)
        { 
        
        }


        public static decimal SkaiciuotiMokescius(decimal pajamos)
        {

            decimal rezultatas = 0;

            if (pajamos <= 400)
            {
                rezultatas = pajamos * 0.05m;


            }

            else if (pajamos > 400 && pajamos <= 1000)
            {
                rezultatas = pajamos * 0.15m;



            }

            else {
                rezultatas = pajamos * 0.25m;
            }
            return rezultatas;
        }


    }


}
