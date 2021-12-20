using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saskaita
{
    public struct Saskaita
    {
        private static string[] SaskaitosNr =
            {
            "SNR001",
            "SNR002",
            "SNR003",
            "SNR004",
            "SNR005"
            };

        private static decimal[] Viso =
            {
             18.50m,
             41.73m,
             90.13m,
             57.59m,
             38.88m
            };


        public Saskaita(string[] saskaitosnr, decimal[] viso)
        {
            SaskaitosNr = saskaitosnr;
            Viso = viso;
        }

        private static void VisoSuma( List<decimal> viso)
        {
            decimal suma = 0;
            for (int i = 0; i <= viso.Count; i++)
            {
                suma += viso[i];
            }

           
            Console.WriteLine($"Suma: {suma}");
        }



    }
}
