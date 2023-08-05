using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandSample
{
    public class MultiplyCommand : ICommand
    {
        private readonly double _valueToMultiply;
        public MultiplyCommand(double valueToMultiply)
        {
            _valueToMultiply = valueToMultiply;
        }
        public double Execute(double currentValue)
        {
            var calculatorBiz = new CalculatorBiz();
            return calculatorBiz.Multiply(currentValue, _valueToMultiply);
        }
        public double Undo(double currentValue)
        {
            var calculatorBiz = new CalculatorBiz();
            return calculatorBiz.Divide(currentValue, _valueToMultiply);
        }
    }

}