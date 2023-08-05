using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandSample
{
    public class SubtractCommand : ICommand
    {
        private readonly double _valueToSubtract;
        public SubtractCommand(double valueToSubtract)
        {
            _valueToSubtract = valueToSubtract;
        }
        public double Execute(double currentValue)
        {
            var calculatorBiz = new CalculatorBiz();
            return calculatorBiz.Subtract(currentValue, _valueToSubtract);
        }
        public double Undo(double currentValue)
        {
            var calculatorBiz = new CalculatorBiz();
            return calculatorBiz.Add(currentValue, _valueToSubtract);
        }
    }
}