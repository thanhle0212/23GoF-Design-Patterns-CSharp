using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandSample
{
    public class DivideCommand : ICommand
    {
        private readonly double _valueToDivide;
        public DivideCommand(double valueToDivide)
        {
            _valueToDivide = valueToDivide;
        }
        public double Execute(double currentValue)
        {
            var calculatorBiz = new CalculatorBiz();
            return calculatorBiz.Divide(currentValue, _valueToDivide);
        }
        public double Undo(double currentValue)
        {
            var calculatorBiz = new CalculatorBiz();
            return calculatorBiz.Multiply(currentValue, _valueToDivide);
        }
    }
}