using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_paskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //NO PARAMS CONSTRUCTOR

            var customer = new Customer();
            customer.FirstName = "Jonas";
            customer.LastName = "Jonauskas";

            //PARAMS CONSTRUCT
            var customer3 = new Customer("Petras", "Petrauskas");

            // nes yra reference tipo objektai, klases -- structas yra value tipo, neveiktu kaip pvz 
            
            int x;
            x = 10;
            int y = x;
            y = 100;

            //ats 10
            var customer1 = new Customer();
            customer.FirstName = "Jonas";


            var customer2 = customer1;
            customer2.FirstName = "Petras";
            //ats petras


            //Console.WriteLine(customer);



            var zinduolis = new Zinduolis();
            var kate =new Kate();   
            var zuvis= new Zuvis();
        }
    }
}
