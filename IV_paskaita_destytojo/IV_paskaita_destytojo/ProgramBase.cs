namespace IV_paskaita_destytojo
{
    internal class ProgramBase
    {

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
    }
}