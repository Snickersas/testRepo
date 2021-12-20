using netcore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_paskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // Book book= new Book("Super_knyga", "125"); geriau naudoti var

            var book = new Book("Super_knyga", "125");

            //book.TestProperty = 5;

          // var value=book.TestProperty;    

            var id = book.Id;
            var LocalID = book.LocalId;
        }
    }
}
