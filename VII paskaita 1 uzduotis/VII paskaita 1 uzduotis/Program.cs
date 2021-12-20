using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
namespace VII_paskaita_1_uzduotis
{
    internal class Program
    {
        public struct Mokinys
        {
            public string Vardas;
            public string Pavarde;
            public string KursoPradzia;
            public string KursoPabaiga;
        

        public Mokinys (string vardas, string pavarde, string kursoPradzia, string kursoPabaiga)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            KursoPradzia= kursoPradzia; 
            KursoPabaiga = kursoPabaiga;    
        
        }

        public void MokinioInformacija()
        {

            Console.WriteLine($"Vardas: {Vardas},Pavarde: {Pavarde}, KursoPradzia: {KursoPradzia}, KursoPabaiga: {KursoPabaiga}");
            Console.ReadLine();
        }

        }

        static void Main(string[] args)
        {

            Mokinys mokinys = new Mokinys ("Vaidotas","Kuodys","2021-11-08","2022-01-20");

            mokinys.MokinioInformacija();
        }
    }
}
**/

namespace VII_paskaita_2_uzduotis
{
    internal class Program
    {
        public struct BibliotekosKnyga
        {
            public int ID;
            public string Pavadinimas;
            public string SkaitytojoVardas;
            public DateTime PaemimoData;


            public BibliotekosKnyga(int id, string pavadinimas, string skaitytojovardas, DateTime paemimodata)
            {
                ID = id;
                Pavadinimas = pavadinimas;
                SkaitytojoVardas = skaitytojovardas;
                PaemimoData = paemimodata;

            }

            public void SuskaiciuokDienas()
            {

                TimeSpan dienos = DateTime.Today - PaemimoData;
                int dienomis = dienos.Days;
                Console.WriteLine($"Nuo paemimo pradzios jau praejo: {dienomis} dienos.");
                Console.ReadLine();
            }

        }

        static void Main(string[] args)
        {

            BibliotekosKnyga knyga = new BibliotekosKnyga(1, "Enciklopedija", "Vaidotas", new DateTime(2021, 11, 10));

            knyga.SuskaiciuokDienas();
        }
    }
}