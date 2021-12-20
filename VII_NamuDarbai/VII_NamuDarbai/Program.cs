using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VII_NamuDarbai
{
    public class Program
    {
        static void Main(string[] args)
        {

            string sakinys=string.Empty;
            SakinioApvertimas(sakinys);
        }

        public static string SakinioApvertimas(string sakinys)
        {
            while (true)
            {
                Console.WriteLine("Įveskite sakinį:");
                sakinys = Console.ReadLine();

                for (int i = sakinys.Length - 1; i >= 0; i--)
                { 
                    Console.Write(sakinys[i]);
                }

                Console.ReadLine();
            }


            

        }
    }
}
