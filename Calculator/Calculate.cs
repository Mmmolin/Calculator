using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class Calculate
    {
        public static List<string> NumbersAndOperators = new List<string>();
        private static int Addition(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        private static int Subtraction(int num1, int num2)
        {
            int sum = num1 - num2;
            return sum;
        }
        private static int Division(int num1, int num2)
        {
            int sum = num1 / num2;
            return sum;
        }
        private static int Multiplication(int num1, int num2)
        {
            int sum = num1 * num2;
            return sum;
        }

        public static int CalculateResult()
        {
            int result = int.Parse(NumbersAndOperators[0]);
            string[] operators = { "+", "-", "/", "X" };
            for (int i = 1; i < NumbersAndOperators.Count; i++)
            {
                if (NumbersAndOperators[i] == "+")
                {
                    result = Addition(result, int.Parse(NumbersAndOperators[i + 1]));
                }
                else if(NumbersAndOperators[i] == "-")
                {
                    result = Subtraction(result, int.Parse(NumbersAndOperators[i + 1]));
                }
                else if(NumbersAndOperators[i] == "/")
                {
                    result = Division(result, int.Parse(NumbersAndOperators[i + 1]));
                }
                else if(NumbersAndOperators[i] == "X")
                {
                    result = Multiplication(result, int.Parse(NumbersAndOperators[i + 1]));
                }
            }
            return result;
        }
    }
}
