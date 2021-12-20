using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VI_paskaita_calc
{
    internal class Program
    {

        private static readonly string[] validOperators = { "+", "-", "*", "/" };

        static void Main(string[] args)
        {
        }


        public static double PerformCalculations(double firstNum, double secondNum, string operation)

        {
            //switch statement
            double result = 0;
            switch (operation)
            { 
            
            case"+":    
                    result = Add (firstNum, secondNum); 
                    break;  

                    case"-":
                    result=Minus (firstNum, secondNum);
                    break;

                    case"*":
                    result = Multiply(firstNum, secondNum);
                    break ;
                    case"/":
                    result = Divide (firstNum, secondNum);
                    break;
                default:
                    result = 0;
                    break;
   
            }
        
        // switch exxpression c#8
        //    return operation switch
         //   { 
         //   "+" => Add(firstNum, secondNum),
         //   "-" => Minus(firstNum, secondNum),
         //   "*" => Multiply(firstNum, secondNum),
         //   "/" => Divide(firstNum, secondNum),
         //   _ => 0
         //   };

            
        }

        private static double GetNumberFromConsole(string input)
        {
            bool isCorrectNumber = false;
            double argumentValue = 0;
                while (!isCorrectNumber)
            {
                Console.WriteLine();
                Console.WriteLine($"enter a number of q to exit:");
                string userInputValue=Console.ReadLine();
                CheckApplicationExit(userInputValue);

                if (double.TryParse(userInputValue, out argumentValue))
                {
                    isCorrectNumber = true;
                }
                else
                {
                    Console.WriteLine("Please enter valid number.");
                }
            }

            return argumentValue;
        }

        private static GetOperator()
        {
            bool isCorrectOperator = false;
            string operatorValue = string.Empty;


            while (isCorrectOperator)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter oeprator or q to exit. Allowed oeprators:{string.Join(",", validOperators)}");
                    string userInput=Console.ReadLine();

                    CheckApplicationExit(input);
                    if (IsOperatorValid(input))
                    {}
            }
        }


        private static double Add(double firstNum, double secondNum)
        { 
        return firstNum + secondNum;    
        }

        private static double Minus(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }


        private static double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }


        private static double Divide(double firstNum, double secondNum)
        {
            if (secondNum == 0)
            {
                throw new ArgumentException("Can`t divide fromo0");
            }
            
            return firstNum /secondNum;
        }

        private static bool IsOperatorValid(string operatorValue)
        { 
        return validOperators.Contains(operatorValue);
        }

        private static void CheckApplicationExit(string userInputValue)
        {
            if (userInputValue.Equals("q", StringComparison.OrdinalIgnoreCase))
            {
                CloseApplication();
            }
        }

        private static void CloseApplication()
        {
            Console.WriteLine("Goodbye");
            Console.WriteLine("Press any key to close calculator!");
            Console.ReadKey();
            Console.Exit(0);
        }


    }
}
