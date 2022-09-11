using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Calculator
{
    public class CalcOperations : CalcBase
    { 
        public double Result { get; set; }

        public static double Add(double InputOne, double InputTwo)
        {
            double Result = InputOne + InputTwo;
            return Result;
        }

        public static double Subtract(double InputOne, double InputTwo)
        {
            double Result = InputOne - InputTwo;
            return Result;
        }

        public static double Multiply(double InputOne, double InputTwo)
        {
            double Result = InputOne * InputTwo;
            return Result;
        }
        public static double Divide(double InputOne, double InputTwo)
        {

            double Result = InputOne / InputTwo;
            return Result;
        }
    }
}
