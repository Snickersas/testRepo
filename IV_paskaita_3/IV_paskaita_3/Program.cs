using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IV_paskaita_3
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // kaip pakeisti masyvo dydi
            /**

            char[] zodis = new char[6];
            zodis[0] = 'K';
            zodis[1] = 'u';
            zodis[2] = 'r';
            zodis[3] = 's';
            zodis[4] = 'a';
            zodis[5] = 's';

            foreach (var raide in zodis)
            {
                Console.WriteLine(raide);
            }

            Array.Resize(ref zodis, 8);

            zodis[6] = 'C';
            zodis[7] = '#';



            foreach (var raide in zodis)
            {
                Console.WriteLine(raide);
            }



            Console.ReadLine();

            **/

            //List<T> listai yra keiciamo dydzio, array ne 

            //sukurti lista

            //List<char> sarasas = new List<char>();

            //prideti i lista

            //List<string> savaitesDienos = new List<string>();

            /**
            savaitesDienos.Add("Pirmadienis");
            savaitesDienos.Add("Antradienis");

            savaitesDienos.Insert(2, "Treciadienis");


            string diena = savaitesDienos[0];

            int ilgis = savaitesDienos.Count();

            **/

            // 4 paskaita 3 dalis 1 uzduotis

            /**

            
            List<int> Sarasas = new List<int>();

              

            var randomas = new Random();

            

            for (int i = 0; i < 50; i++)
            {
                Sarasas.Add(randomas.Next(1000));
            }

            Console.WriteLine($"Nelyginiai skaičiai iš sąrašo:");

            foreach (int skaicius in Sarasas)
            {
                if (skaicius % 2 != 0)
                {
                    Console.Write($"{skaicius} ");
                }
            }

            Console.ReadLine();

            **/

            // 4 paskaita 3 dalis 2 uzduotis

            /**

            List<string> studentai = new List<string>();
            List<string> studentaiVelyvi = new List<string>();

            studentai.Add("Jonas Jonaitis");
            studentai.Add("Vardenė Pavardenė");
            studentai.Add("Petras Petraitinis");


            

            studentaiVelyvi.Add("Antanas Antanaitis");
            studentaiVelyvi.Add("Žibutė Saulutė");


            List<string> bendras = studentai.Union(studentaiVelyvi).ToList();

            bendras.Sort();


            foreach (string studentas in bendras)
            {
                
                    Console.WriteLine($"{studentas} ");
                
            }


            Console.ReadLine();

            **/

            // 4 paskaita 3 dalis 3 uzduotis

            /**

            List<string> vardai = new List<string>();

            vardai.Add("Spiderman");  
            vardai.Add("Batman");
            vardai.Add("Ironman");
            vardai.Add("Thor");
            vardai.Add("Superman");


            

            vardai.Add("Napoleonas");
            vardai.Add("Asteriksas");

            vardai.Remove(vardai[2]);
            vardai[vardai.FindIndex(ind => ind.Equals("Napoleonas"))] = "Kleopatra";


            foreach (string vardas in vardai)
            {

                Console.WriteLine($"Vardai: {vardas} ");

            }

            Console.ReadLine();


          **/

            // 4 paskaita 3 dalis 4 uzduotis

            /**

            List<int> pazymiai = new List<int> {1,2,3,4,5,6,7,8,9,10};

           

            for (; ; )
            {
                Console.WriteLine("Šiuo metu sąraše esantys pažymiai:");


                foreach (int pazymys in pazymiai)
                {

                    Console.Write($"{pazymys} ");

                }

                Console.WriteLine("\n");
                Console.WriteLine("Prašome pasirinkti norimą veiksmą.");
                Console.WriteLine("Galimi variantai: [0] - papildyti");
                Console.WriteLine("Galimi variantai: [1] - ištrinti");
                Console.WriteLine("Galimi variantai: [2] - įterpti");
                Console.WriteLine("Galimi variantai: [3] - parodytu pažymių vidurkį");
                Console.WriteLine("Galimi variantai: [4] - išeiti iš programos");

                string opcija = Console.ReadLine();

                switch (opcija)
                {
                    case "0":
                        Console.WriteLine("\n");
                        Console.WriteLine("Jūs pasirinkote variantą papildyti:");
                        Console.WriteLine("Įveskite naują pažymį:");
                        int papildomasPazymys = Convert.ToInt32(Console.ReadLine());
                        pazymiai.Add(papildomasPazymys);
                        Console.WriteLine("\n");                       
                        break;

                    case "1":
                        Console.WriteLine("\n");
                        Console.WriteLine("Jūs pasirinkote variantą ištrinti:");
                        Console.WriteLine("Pasirinkite kurį elementą/pažymį norite ištrinti:");
                        int istrintasPazymys = Convert.ToInt32(Console.ReadLine());
                        pazymiai.Remove(istrintasPazymys);
                        Console.WriteLine("\n");                        
                        break;

                    case "2":
                        Console.WriteLine("\n");
                        Console.WriteLine("Jūs pasirinkote variantą įterpti:");
                        Console.WriteLine("Įveskite naują pažymį:");
                        int iterptasPazymys = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Įveskite kelintu numeriu įterpti į sąrašą:");
                        int vieta = Convert.ToInt32(Console.ReadLine());
                        pazymiai.Insert(vieta, iterptasPazymys);
                        Console.WriteLine("\n");
                        break;

                    case "3":
                        Console.WriteLine("\n");
                        Console.WriteLine("Jūs pasirinkote variantą parodyti pažymių vidurkį:");
                        Console.WriteLine("Pažymių vidurkis yra:");
                        Console.WriteLine(pazymiai.Average());
                        Console.WriteLine("\n");
                        break;
                    
                    case "4":
                        
                        Console.WriteLine("\n");
                        Console.WriteLine("Jūs pasirinkote variantą išeiti!");
                        break;
                     
                }

                if (opcija == "4")
                    break;

            }

            Console.WriteLine("Programa baigia darbą, gražios dienos!");
            Console.ReadLine();

            **/

            // 4 paskaita 3 dalis 5 uzduotis

            /**
            List<int> sarasasPirmas = new List<int> { 1, 2, 4, 8};

            

            List<int> sarasasAntras = new List<int> { 2, 4, 8};

            if (sarasasPirmas.Any(x => sarasasAntras.Any(y => y == x)))
            {
                Console.WriteLine("Taip, antras sąrašas yra pirmo sąrašo dalimi.");
            }
            else
            {
                Console.WriteLine("Ne, antras sąrašas nėra pirmo sąrašo dalim ");
            }

            Console.ReadLine();
            **/

            // 4 paskaita 3 dalis 6 uzduotis

            
            List<string> sarasasAntras = new List<string> { "A", "U", "G","C" };
            


            // 4 paskaita 3 dalis 7 uzduotis

            /**

            List<int> Sarasas = new List<int>();
            var randomas = new Random();


            Console.WriteLine($"Skaičių generavimas.");
            for (int i = 0; i < 100000; i++)
            {
                Sarasas.Add(randomas.Next(1000000));
            }


            Console.WriteLine($"Skaičių rūšiavimas.");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Sarasas.Sort();
            watch.Stop();
            var elapsedMs=watch.ElapsedMilliseconds;    


            Console.WriteLine($"Trukmė:{elapsedMs} Ms");

            

          //foreach (int skaicius in Sarasas)
          //  {
          //      
          //          Console.Write($"{skaicius} ");
          //     
          // }

            Console.ReadLine();
            **/
            // 4 paskaita 3 dalis 8 uzduotis

            /**

            List<string> saliuSarasas = new List<string>();

            using (StreamReader saliuFailas = new StreamReader("countries.txt"))  //jeigu path tai dvigubi slashai

            {
                string nuskaitytaEilute;
                while ((nuskaitytaEilute = saliuFailas.ReadLine()) != null)

                {
                    saliuSarasas.Add(nuskaitytaEilute);

                }
            }

            saliuSarasas.Sort();

            

            using (StreamWriter irasomasFailas = new StreamWriter("countries_sorted.txt"))
            {
                foreach (var salis in saliuSarasas)
                {
                    irasomasFailas.WriteLine(salis);
                }


            }

            Console.ReadLine();

            **/

            //sarao uzpildymas is failu
            /**
            List<string> saliuSarasas = new List<string>();

            using (StreamReader saliuFailas = new StreamReader("countries.txt"))  //jeigu path tai dvigubi slashai

            {
                string nuskaitytaEilute;
                while ((nuskaitytaEilute = saliuFailas.ReadLine()) != null)

                {
                    saliuSarasas.Add(nuskaitytaEilute);
                
                }
            }


            foreach (var salis in saliuSarasas)
            {
                Console.WriteLine(salis);
            }

            Console.WriteLine($"Saliu skaicius: {saliuSarasas.Count}");


            Console.ReadLine();

            **/
        }
    }
}
