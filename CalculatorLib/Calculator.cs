using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class Calculator
    {
        public int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public int Subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public int Multiplication(int num1, int num2)
        {
            try
            {
                if(num1 <= 0 || num2 <=0)
                {
                    throw new CustomException("First no or Second can't be less than or equal to 0.");
                }
                int result = num1 * num2;
                return result;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Division(int num1, int num2)
        {
            try
            {
                int result = num1 / num2;
                return result;
            }
            catch(DivideByZeroException dbze)
            {
                throw dbze;
            }
            catch (Exception objEx)
            {

                throw objEx;
            }

        }
    }
}
