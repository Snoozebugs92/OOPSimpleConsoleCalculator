using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Calculator
{
    public class CalcBase
    { 
        double _inputOne;
        double _inputTwo;
     
        public double InputOne
        {
            get { return _inputOne; }
            set { _inputOne = value; }
        }

        public double InputTwo
        {
            get { return _inputTwo; }
            set { _inputTwo = value; }
        }
        
        public CalcBase()
        {
            _inputOne = InputOne;
            _inputTwo = InputTwo;
        }
    }
}
