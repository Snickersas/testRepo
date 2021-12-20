using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuoniDu
{
    public struct Miskas
    {

        public List<int> Medziai {get; set;}
        




        public Miskas(List<int> medziai)
        {
            Medziai = medziai;
        }

       

        public  void PasodintiMedi()
        {                      
            
           
            Medziai.Add(1);
            
        }

        public void VisoMedziu(List<int> medziai)
        {
            Console.WriteLine("Medžiai:");

            foreach (int medis in medziai)
            {
                Console.Write($"{medziai} ");
            }

        }


    }
}
