using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buhalterija
{
    public struct Buhalterija
    {


        public static List<string> Saskaita = new List<string> 
        { "SNR001",
          "SNR002",
          "SNR003",
          "SNR004",
          "SNR005"
        };
        



        public Buhalterija(List<string> saskaita)
        {
            Saskaita = saskaita;
           
        }

        private static void VisoSaskaitu(List<int> saskaita)
        {
            saskaita.Count();
        }




    }
}
