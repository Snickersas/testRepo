using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XVI_Paskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var inputFilePath = "C:\\Vaidotas\\Mano\\JiraTask\\.NET\\GIT\\testRepo\\XVI_Paskaita\\XVI_Paskaita\\data\\some_data.txt";
            var outputFilePath = "C:\\Vaidotas\\Mano\\JiraTask\\.NET\\GIT\\testRepo\\XVI_Paskaita\\XVI_Paskaita\\data\\some_data_output.txt";

            var textFileProcessor = new TextFileProcessor(inputFilePath,outputFilePath);    

            //var command = args[0];

            //if (command == "--file")
            //{
            //    var filePath = args[1];
            //    Console.WriteLine($"Pasirinkta viena byla: {filePath} ");
            //    ProcessSingleFile(filePath);


            //}
            //else if (command == "--dir")
            //{ 
            //    var fileType = args[1];
            //    var dirPath = args[2];

            //    ProcessDirectory(dirPath, fileType);
            
            //}
        }

        private static void ProcessDirectory(string dirPath, string fileType)
        {
            switch (fileType)
            {
                case "TEXT":
                           string[] textFiles = Directory.GetFiles(dirPath, "*.txt")
                        foreach (var textFile in textFiles)

                    {
                        Console.WriteLine(textFile);
                    }
                break;
                default:
                    Console.WriteLine($"Kladia, tipas nepalaikomasL {fileType}");
                    break;

            }
        }

        private static void ProcessSingleFile(string filePath)
        { 
            var fileProcessor = new FileProcessor();
            fileProcessor.Process();
        
        }

    }
}
