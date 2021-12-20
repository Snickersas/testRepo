using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_paskaita_destytojo
{
    
   
    /// <summary>
    /// CALCULATOR
    /// </summary>
    internal class Program
    {
        private static readonly string[] validOperators = { "+", "-", "*", "/" };

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    double firstNum = GetNumberFromConsole();
                    double secondNum = GetNumberFromConsole();
                    string operatorValue = GetOperator();

                    double result = PerformCalculations(firstNum, secondNum, operatorValue);
                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error occured: {e.Message}");
                }
            }
        }

        public static double PerformCalculations(double firstNum, double secondNum, string operation)
        {
            double result = 0;
            ////Switch statement 
            switch (operation) 
            {
                case "+":
                    result = Add(firstNum, secondNum);
                    break;
                case "-":
                    result = Minus(firstNum, secondNum);
                   break;
                case "*":
                   result = Multiply(firstNum, secondNum);
                   break;
               case "/":
                   result = Divide(firstNum, secondNum);
                    break;
               default:
                   result = 0;
                    break;
            }

            //Switch expression C#8
           // return operation switch
           // {
           //     "+" => Add(firstNum, secondNum),
           //     "-" => Minus(firstNum, secondNum),
           //     "*" => Multiply(firstNum, secondNum),
           //     "/" => Divide(firstNum, secondNum),
           //     _ => 0
           // };

        }

        private static double GetNumberFromConsole()
        {
            bool isCorrectNumer = false;
            double argumentValue = 0;

            while (!isCorrectNumer)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter a number of q to exit:");
                string userInputValue = Console.ReadLine();
                CheckApplicationExit(userInputValue);

                if (double.TryParse(userInputValue, out argumentValue))
                {
                    isCorrectNumer = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            return argumentValue;
        }

        private static string GetOperator()
        {
            bool isCorrecOperator = false;
            string operatorValue = string.Empty;

            while (!isCorrecOperator)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter operator or q to exit. Allowed operators: {string.Join(", ", validOperators)}");
                string input = Console.ReadLine();

                CheckApplicationExit(input);
                if (IsOperatorValid(input))
                {
                    operatorValue = input;
                    isCorrecOperator = true;
                }
                else
                {
                    Console.WriteLine("Please enter valid operator.");
                }
            }

            return operatorValue;
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
                throw new ArgumentException("Can not divide by 0");
            }

            return firstNum / secondNum;
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
            Console.WriteLine("Press any key to close application....");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}