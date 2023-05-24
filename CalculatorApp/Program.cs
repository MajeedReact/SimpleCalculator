using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {

        public double addition(double value1, double value2)
        {
            return value1 + value2;
        }
        public double minus(double value1, double value2)
        {
            return value1 - value2;
        }
        public double multiplication(double value1, double value2)
        {
            return value1 * value2;
        }
        public double division(double value1, double value2)
        {
            return value1 / value2;
        }

    }

    enum operations
    {
        multiplication,
        addition,
        division,
        minus
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            while (true)
            {

                Console.WriteLine("Enter your first number");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Choose your operation: (Enter 1 - 4) 0 to exit");
                Console.WriteLine("1. " + operations.addition);
                Console.WriteLine("2. " + operations.minus);
                Console.WriteLine("3. " + operations.multiplication);
                Console.WriteLine("4. " + operations.division);
                int input = int.Parse(Console.ReadLine());
                if (input == 0) break;
                Console.WriteLine("Enter the second number");
                double num2 = double.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        {
                            var result = calculator.addition(num1, num2);
                            Console.WriteLine("Choosen operation is addition and total is: " + result);
                            break;
                        }
                    case 2:
                        {
                            var result = calculator.minus(num1, num2);
                            Console.WriteLine("Choosen operation is minus and total is: " + result);
                            break;
                        }
                    case 3:
                        {
                            var result = calculator.multiplication(num1, num2);
                            Console.WriteLine("Choosen operation is multiplication and total is: " + result);
                            break;
                        }
                    case 4:
                        {
                            var result = calculator.division(num1, num2);
                            Console.WriteLine("Choosen operation is division and total is: " + result);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong input");
                            break;
                        }
                }
            }
        
        }
    }
}
