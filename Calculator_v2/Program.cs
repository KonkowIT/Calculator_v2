using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
first number = input from user ~ if number is not numeric -> Warning
second number = input from user ~ if number is not numeric -> Warning 
operation = input from user ~ lower case the operation name (case insensivity) ~~ if operation symbol is not recognized -> Warning
*/
namespace Calculator_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Provide first number:");
                double firstInt = inputConverter.ConvertToInt(Console.ReadLine());

                Console.WriteLine("Provide second number:");
                double secondInt = inputConverter.ConvertToInt(Console.ReadLine());

                Console.WriteLine("Provide operation type:");
                string operationType = Console.ReadLine();

                double result = calculatorEngine.Calculate(operationType, firstInt, secondInt);
                Console.WriteLine(result);
            } catch(Exception ex) {
                Console.WriteLine("ERROR: {0}", ex.Message);
            }

        }
    }
}
