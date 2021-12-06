using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VII_Paskaita_Pazymiu_vidurkis
{
    internal class Program
    {


        public struct Pazymiai
        {
            public double PirmasTrimestras;
            public double AntrasTrimestras;
            public double  TreciasTrimestras;
            

            public Pazymiai ( double pirmasTrimestras,double antrasTrimestras, double treciasTrimestras)  //ctor 2kart tab konstruktorius
           {
                PirmasTrimestras = pirmasTrimestras;
                AntrasTrimestras = antrasTrimestras;
                TreciasTrimestras = treciasTrimestras;
            }

            public void SuskaiciuotiVidurki()
            {
                double Vidurkis = (PirmasTrimestras + AntrasTrimestras + TreciasTrimestras) / 3;
                Console.WriteLine($"Vidurkis: {Vidurkis}");
                Console.ReadLine();
            }
        }





        static void Main(string[] args)
        {
            Pazymiai pazymys;
            pazymys.PirmasTrimestras = 9;
            pazymys.AntrasTrimestras=10;
            pazymys.TreciasTrimestras = 9;

            Pazymiai pazymys2= new Pazymiai (9,10,9);   

           // pazymys.SuskaiciuotiVidurki();

            pazymys2.SuskaiciuotiVidurki();
        }
    }
}
