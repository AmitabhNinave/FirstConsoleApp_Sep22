using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLib;

namespace FirstConsoleApp
{
    class MyNewClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Calculator Application -----");
            //
            try
            {
                char choice;
                do
                {
                    Console.WriteLine("Press 1 for Addition, 2 for Subtration, 3 for Multiplication, 4 Division and 5 to Exit.");
                    int arithmeticOperation;
                    arithmeticOperation = Convert.ToInt32(Console.ReadLine());
                    Calculator objCalculator = new Calculator();
                    int result;
                    //
                    switch (arithmeticOperation)
                    {
                        case 1:
                            //Addition
                            int num1Add;
                            int num2Add;
                            Console.WriteLine("Enter first no.");
                            num1Add = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter second no.");
                            num2Add = Convert.ToInt32(Console.ReadLine());
                            //
                            result = objCalculator.Addition(num1Add, num2Add);
                            Console.WriteLine("Addition of two numbers: " + result);
                            break;
                        case 2:
                            //Subtraction
                            int num1Sub;
                            int num2Sub;
                            Console.WriteLine("Enter first no.");
                            num1Sub = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter second no.");
                            num2Sub = Convert.ToInt32(Console.ReadLine());
                            //
                            result = objCalculator.Subtraction(num1Sub, num2Sub);
                            Console.WriteLine("Subtraction of two numbers: " + result);
                            break;
                        case 3:
                            //Multiplication
                            int num1Multiply;
                            int num2Multiply;
                            Console.WriteLine("Enter first no.");
                            num1Multiply = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter second no.");
                            num2Multiply = Convert.ToInt32(Console.ReadLine());
                            //
                            result = objCalculator.Multiplication(num1Multiply, num2Multiply);
                            Console.WriteLine("Multiplication of two numbers: " + result);
                            break;
                        case 4:
                            //Division
                            int num1Divide;
                            int num2Divide;
                            Console.WriteLine("Enter first no.");
                            num1Divide = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter second no.");
                            num2Divide = Convert.ToInt32(Console.ReadLine());
                            //
                            result = objCalculator.Division(num1Divide, num2Divide);
                            Console.WriteLine("Division of two numbers: " + result);
                            break;
                        case 5:
                            //Exit
                            Environment.Exit(0);
                            break;
                        default:
                            //Default logic
                            Console.WriteLine("Chose correct option.");
                            break;
                    }
                    Console.WriteLine("Do you want to continue? Press 'y' to continue or 'n' to exit.");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'y');

            }
            catch(CustomException ce)
            {
                Console.WriteLine(ce.Message);
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine(dbze.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //
            Console.ReadLine();
        }

        /*
        static int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        static int Subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        static int Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        static int Division(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
        */
    }
}
