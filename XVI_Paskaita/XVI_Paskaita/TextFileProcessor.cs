using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XVI_Paskaita
{
    public class TextFileProcessor
    {
        public string InputFilePath { get; }
        public string OutputFilePath { get; }

        public TextFileProcessor()
        {
        }

        public TextFileProcessor(string inputFilePath, string outputFilePath)
        {
            InputFilePath = inputFilePath;
            OutputFilePath = outputFilePath;    
        }



        public void Process()
        {
            string originalText = File.ReadAllText(InputFilePath);
            string processedText = originalText.ToUpperInvariant();

            File.WriteAllText(OutputFilePath, processedText);   
        }


    }
}
