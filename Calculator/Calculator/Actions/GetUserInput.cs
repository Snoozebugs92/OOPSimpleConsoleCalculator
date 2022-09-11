using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Actions
{
    public class GetUserInput
    {
        public static double GetInputOne()
        {
            Console.WriteLine("Enter the first number: ");
            var Input = double.Parse(Console.ReadLine());
            return Input;
        }

        public static double GetInputTwo()
        {
            Console.WriteLine("Enter the second number: ");
            var Input = double.Parse(Console.ReadLine());
            return Input;
        }
    }
}
