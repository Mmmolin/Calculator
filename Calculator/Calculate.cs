using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculate
    {
        public static List<string> NumbersAndOperators = new List<string>();
        
        private static decimal Result(string op, decimal num1, decimal num2)
        {
            switch (op)
            {
                case "+": return num1 + num2;
                case "-": return num1 - num2;
                case "/": return num1 / num2;
                case "X": return num1 * num2;
                default: return -1;
            }
        }
        public static decimal CalculateResult()
        {
            decimal result = decimal.Parse(NumbersAndOperators[0]);
            string[] operators = { "+", "-", "/", "X" };
            for (int i = 1; i < NumbersAndOperators.Count; i++)
            {
                if (operators.Contains<string>(NumbersAndOperators[i]))
                {
                    result = Result(NumbersAndOperators[i], result, decimal.Parse(NumbersAndOperators[i + 1]));
                }                
            }
            return Math.Round(result, 2);
        }
    }
}
