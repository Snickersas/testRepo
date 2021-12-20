using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IV_paskaita_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /**
            //paprast for ciklas
            for (int i = 0; i < 10 i++)
            {
                //veiksmas
            }


            //mazejantis ciklas

            for (int 1=10-1; 1>0; ++)
            {
                Console.WriteLine($"I={1}");
                
            }


            //Ciklo zingsniai

            for (int i = 0; 1 < 10; 1 += 3)

            {
                Console.WriteLine($"I={1}");
            }


            //iteracija per stringa
            string vardas = "C#Kursas+1lvl1";

            for (int i = 0; i < length; i++)
            {
                char current = vardas[1];
                Console.WriteLine(current); 
            }

            //progress bar
            
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("#");
            }

            Console.WriteLine();
            Console.WriteLine("Pabaiga");

           

            //amzinasis ciklas

            for (; ;)
            {
                Console.WriteLine("?");
                break; 
                //return;

            }
            Console.WriteLine("HELP!");
             

            //iteracija per string foreach tas pats kas for tik grazesne forma

            string raides = "C#Kursas+1lvl1";

            foreach (char raide in raides)
            {
                Console.WriteLine(raide);            
            }

            Console.ReadLine();

            //for (int i = 0; i < length; i++)
            //{
            //    char current = vardas[1];
            //    Console.WriteLine(current);
            //}
            
            
            **/

            // 4 paskaita 1 dalis 1 uzduotis

            /**
            Console.WriteLine("Įveskite, bet kokį skaičių");

           

            int skaicius = Convert.ToInt32(Console.ReadLine());
            int suma = 0;

            for (int i = 0; i <= skaicius; i++)
            {

                suma += i;
            }

            Console.WriteLine($"Suma yra: {suma}");
            Console.ReadKey();

            
             **/

            // 4 paskaita 1 dalis 2 uzduotis

            /**

            Console.WriteLine("Įveskite, bet kokį skaičių");

            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i <= skaicius2; i+=2)
            {

                Console.Write($"{i},");
            }

            
            Console.ReadKey();

            **/

            // 4 paskaita 1 dalis 3 uzduotis


            /**


                Console.WriteLine("Iveskite sakini:");
                string sakinys = Console.ReadLine();

                for (int i = sakinys.Length - 1; i >=0; i--)
                {
                Console.Write(sakinys[i]);
                }
            
                Console.ReadLine();

              

            **/


            // 4 paskaita 1 dalis ND 1 uzduotis

            /**
            
            Console.WriteLine("Įveskite, bet kokį skaičių");
            decimal skaicius = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i <= skaicius; i++)
            {

                decimal kintamasis = i;

               
                Thread.Sleep(1000);

                decimal procentas = kintamasis / skaicius * 100;
                    Console.WriteLine("\r{0}% ", procentas);
            }
            
           
            
            **/




            // 4 paskaita 1 dalis ND 2 uzduotis

            /**

             Console.WriteLine("Įveskite norimą sakinį:");
             
             string sakinys = Console.ReadLine();

         
             string[] zodziai = sakinys.Split(' ');

             

             Array.Reverse(zodziai);

             var skaiciai = String.Join(" ", zodziai);

             foreach (var zodis in zodziai)
             {
                 System.Console.Write($"{zodis} ");
             }


             Console.ReadKey();   
           
            
            **/

            // 4 paskaita 1 dalis ND 3 uzduotis


            /**

                for (; ; )
            {

                int atsakymas = 0;
                Console.WriteLine("Įveskite norimą pirmą skaičių:");
                int skaicius = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Įveskite norimą antrą skaičių:");
                int skaicius2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Įveskite operacijos simbolį ['x', '/','+' arba '-']:");
                string operacija = Console.ReadLine();



                switch (operacija)
                {
                    case "x":
                        atsakymas = skaicius * skaicius2;
                        Console.WriteLine($"Suma: {atsakymas}");
                        break;
                    case "/":
                        atsakymas = skaicius / skaicius2;
                        Console.WriteLine($"Suma: {atsakymas}");
                        break;
                    case "+":
                        atsakymas = skaicius + skaicius2;
                        Console.WriteLine($"Suma: {atsakymas}");
                        break;
                    case "-":
                        atsakymas = skaicius - skaicius2;
                        Console.WriteLine($"Suma: {atsakymas}"); ;
                        break;
                }

                Console.WriteLine("Ar norite tęsti? taip/ne");
                string inputas = Console.ReadLine();
                    if (inputas == "ne")
                        break;


            }
                Console.WriteLine("Skaičiuotuvas baigė darbą!");    
            Console.ReadLine();

            **/


            ////////////
            //PASKAITA//
            ///////////


            /**
            //kolekcijos masyvai, sarasai ir zodynai

            string[] savaitesDienos =

            {
                "pirmadienis",
                "antradienis",
                "treciadienis",
                "ketvirtadienis",
                "penktadinies",
                "sestadienis",
                "sekmadienis"
            };


            //Pries
             for (int i = 0; i < savaitesDienos.Length; i++)
            {
                 Console.WriteLine(savaitesDienos[i]);   
             }


            //po

            savaitesDienos[2] = "TRECIADIENIS";

            for (int i = 0; i < savaitesDienos.Length; i++)
            {
                Console.WriteLine(savaitesDienos[i]);
            }

            Console.ReadLine();

            //  foreach (var savaitesDiena in savaitesDienos)
            // {
            //     Console.Writeline(savaitesDiena);
            //  }


            ///

            // int[] ints = {1,4,9 };

            // Console.WriteLine("Kuria savaites diena parodyti ?");
            // Console.WriteLine("Diena - skaicius");

            // int index = int.Parse(Console.ReadLine());

            // string pasirinktaDiena=savaitesDienos[index-1];

            //  Console.WriteLine($"Jusu pasrinkta diena:{pasirinktaDiena}");

            //  Console.ReadLine();


           

            //kolekcija kur nera duomenu, bet rezervuojam tam tikra kieki simboliu

            int[] skaiciai = new int[10];
            Random random  = new Random();

            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = random.Next(1, 100);
            }



            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine($"Tavo skaiai:{skaicius}");
            }

            Console.ReadLine();

           

            //daugiamatis masyvas multidimensionall Array



            int[,] matrica = new int[5, 4]
            {
                {1,1,1,1 },
                {0,1,1,1 },
                {0,1,1,1 },
                { 0,1,1,1 },
                { 0,1,1,1 }
            };

            var skaicius matrica[0, 0]; // pirmas simbolis eilute, antas simbolis skaicius nuo 0 skaiciavimai



            for (int i = 0; i <= matrica.GetUpperBound(0);i++)

                for (int j = 0; j <= matrica.GetUpperBound(1); j++)
                {
                    Console.Write(matrica[i,j]);
                }

            Console.ReadLine();
             
            **/


            //ND

            // 4 paskaita 2 dalis 1 uzduodis

            /**

            int[] Masyvas = new int[5];
            int i = 0;


            for (i = 0; i < Masyvas.Length; i++)
            {

                Console.WriteLine("Įveskite norimą skaičių į masyvą:");
                string input = Console.ReadLine();

                if (input == "")
                    break;
                else
                    int.TryParse(input, out Masyvas[i]);
            }


            Array.Reverse(Masyvas);  

            var skaiciai = String.Join(",", Masyvas);


            Console.Write($"Įvesti skaičiai atvirkštine tvarka: {skaiciai}");
             

            Console.WriteLine("\n");
           


            Console.ReadLine();


             **/

            // 4 paskaita 2 dalis 2 uzduodis

            /**

             int[] Masyvas = new int[5];
             int i = 0;


             for (i = 0; i < Masyvas.Length; i++)
             {

                 Console.WriteLine("Įveskite norimą skaičių į masyvą:");
                 string input = Console.ReadLine();

                 if (input == "")
                     break;
                 else
                     int.TryParse(input, out Masyvas[i]);
             }


             int suma = Masyvas.Sum();


             Console.Write($"Masyvo suma: {suma}");

             Console.WriteLine("\n");
             Console.ReadLine();

            **/

            // 4 paskaita 2 dalis 3 uzduodis

            /**

            int[] Masyvas = new int[5];
            int i = 0;


            for (i = 0; i < Masyvas.Length; i++)
            {

                Console.WriteLine("Įveskite norimą skaičių į masyvą:");
                string input = Console.ReadLine();

                if (input == "")
                    break;
                else
                    int.TryParse(input, out Masyvas[i]);
            }


           

            int[] Masyvas2 = Masyvas.ToArray();


            var skaiciai = String.Join(",", Masyvas2);

            Console.Write($"Masyvo suma: {skaiciai}");



            Console.WriteLine("\n");
            Console.ReadLine();

            
            **/

            // 4 paskaita 2 dalis 4 uzduodis

            /**

            int[] skaiciai= new int[10];
            Random Random = new Random();


            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = Random.Next(1, 100);
            }



            int max = skaiciai.Max();
            int min = skaiciai.Min();



           

            Console.WriteLine($"Didžiausias elementas: {max}");
            Console.WriteLine("\n");
            Console.WriteLine($"Mažiausias elementas: {min}");
            Console.WriteLine("\n");


            Array.Sort(skaiciai);
            var visi = String.Join(",", skaiciai);



            Console.Write($"Visi įvesti elementai: {visi}");
            Console.ReadLine();


            **/

            // 4 paskaita 2 dalis 5 uzduodis

            /**
            
            int[] pirmasMasyvas = new int[10];
            Random pirmasRandom = new Random();
            

            for (int i = 0; i < pirmasMasyvas.Length; i++)
            {
                pirmasMasyvas[i] = pirmasRandom.Next(1,100);
            }

            var pirmas = String.Join(";", pirmasMasyvas);

            int[] antrasMasyvas = new int[10];
            Random antrasRandom = new Random();
            
            for (int i = 0; i < antrasMasyvas.Length; i++)
            {
                antrasMasyvas[i] = antrasRandom.Next(100,1000);
            }

            var antras = String.Join(";", antrasMasyvas);

            int[] bendrasMasyvas = pirmasMasyvas.Concat(antrasMasyvas).ToArray();
            Array.Sort(bendrasMasyvas);

            var bendras = String.Join(";", bendrasMasyvas);

            
            Console.Write($"Bendras surušiuotas masyvas: {bendras}");
            Console.WriteLine("\n");
            Console.Write($"Pirmas masyvas: {pirmas}");
            Console.WriteLine("\n");
            Console.Write($"Antras masyvas: {antras}");
            

            Console.ReadLine();

            **/




            // 4 paskaita 2 dalis 6 uzduodis

            //mano

            /**
            

            int[] Masyvas= new int[10];
            Random Random = new Random();


            for (int i = 0; i < Masyvas.Length; i++)
            {
                Masyvas[i] = Random.Next(1, 3);
            }



            var skaiciai = Masyvas.GroupBy(s =>s);
            foreach (var skaicius in skaiciai)

            {
                Console.WriteLine("Reikšmė {0} pasikartojo {1} k.!", skaicius.Key, skaicius.Count());

            }

            

            Console.WriteLine("\n");
           


            Console.ReadLine();

           **/

            //destytojo

            /**
            int[] pasikartojimai = new int[10];
            int[] skaiciai = new int[10];
            Random pirmasRandom = new Random();


            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = pirmasRandom.Next(1, 100);
            }



            for (int i = 0; i < pasikartojimai.Length; i++)
            {
                pasikartojimai[i] = -1;


            }

            for (int i = 0; i < skaiciai.Length; i++)
            {
                int pasikartojimas = 1;

                for (int j = i+1; j < skaiciai.Length; j++)
                {

                    if (skaiciai[i] == skaiciai[j])
                    {
                        pasikartojimas++;
                        pasikartojimai[j] = 0;
                    }

                }



                if (pasikartojimai[i]!=0)
                {
                    pasikartojimai[i] = pasikartojimas;
                }
            }

            for (int i = 0; i < skaiciai.Length; i++)
            { 
                    if (pasikartojimai[i] !=0)
            }






            //var pirmas = String.Join(";", pirmasMasyvas)

            Console.WriteLine("\n");



            Console.ReadLine();

            **/
            // 4 paskaita 2 dalis 7 uzduodis

            

            int[] Masyvas = new int[10];
            Random Random = new Random();


            for (int i = 0; i < Masyvas.Length; i++)
            {
                Masyvas[i] = Random.Next(1, 100);
            }

            Console.WriteLine("Random sugeneruotas masyvas:");
            Console.WriteLine(String.Join(",", Masyvas));
            Console.WriteLine("Kurį norite skaičių ištrinti?");
            
            int skaicius = Convert.ToInt32(Console.ReadLine());

            

            Masyvas = Masyvas.Except(new int[] {skaiscius}).ToArray();
           

            foreach (var skaiciai in Masyvas)
            {
                Console.Write($"{skaiciai} ");
            }

            

            Console.ReadLine();        
            
            


            // 4 paskaita 2 dalis 8 uzduodis

            //papildyti po to masyva, kad usersi pats suvestu duomenis

            /**

            int[] elementai = new int[10];
            int i = 0;


            for ( i = 0; i < elementai.Length; i++)
            {

                Console.WriteLine("Įveskite norimą skaičių į masyvą:");
                string input = Console.ReadLine();

                if (input == "")
                    break;
                else
                    int.TryParse(input, out elementai[i]);
            }

            

            int max = elementai.Max();
            int min = elementai.Min();


            
            int smax = min;
            int smin = max;

           
            for (i = 0; i < elementai.Length; i++)
            {
                if (elementai[i] < max && elementai[i] > smax) smax = elementai[i];
                if (elementai[i] > min && elementai[i] < smin) smin = elementai[i];
            }



            Console.WriteLine($"Antras didžiausias elementas: {smax}");
            Console.WriteLine("\n");
            Console.WriteLine($"Antras mažiausias elementas: {smin}");
            Console.WriteLine("\n");
            
            var visi = String.Join(",", elementai);

            Console.Write($"Visi įvesti elementai: {visi}");
            Console.ReadLine();

            **/


            // 4 paskaita 2 dalis 9 uzduodis

            /**
            int[,] matrica = new int[3, 3]
            {
                {1,2,3},
                {1,2,3},
                {1,2,3},
                
            };

            int sum = 0;
            foreach (var element in matrica)
            {
                sum += element;  
            }
            Console.WriteLine($"Matricos suma: {sum}");



            int rows, cols, sumRow, sumCol;

            // var skaicius matrica[0, 0]; // pirmas simbolis eilute, antas simbolis skaicius nuo 0 skaiciavimai

            // Console.WriteLine($"{skaicius}");

            rows = matrica.GetLength(0);
            cols = matrica.GetLength(1);


            for (int i = 0; i < rows; i++)
            {
                sumRow = 0;
                for (int j = 0; j < cols; j++)
                {
                    sumRow = sumRow + matrica[i, j];
                }
                Console.WriteLine("Suma " + (i + 1) + " eilutės: " + sumRow);
            }


            for (int i = 0; i < cols; i++)
            {
                sumCol = 0;
                for (int j = 0; j < rows; j++)
                {
                    sumCol = sumCol + matrica[j, i];
                }
                Console.WriteLine("Suma " + (i + 1) + " stulpelio " + sumCol);
            }



       

            Console.ReadLine();

            **/


            // 4 paskaita 2 dalis 10 uzduodis



        }
}
}
