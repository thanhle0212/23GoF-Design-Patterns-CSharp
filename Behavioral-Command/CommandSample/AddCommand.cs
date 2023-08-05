using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandSample
{
    public class AddCommand : ICommand
    {
        private readonly double _valueToAdd;
        public AddCommand(double valueToAdd)
        {
            _valueToAdd = valueToAdd;
        }

        public double Execute(double currentValue)
        {
            var calculatorBiz = new CalculatorBiz();
            return calculatorBiz.Add(currentValue, _valueToAdd);
        }
        public double Undo(double currentValue)  
        {
            var calculatorBiz = new CalculatorBiz();
            return calculatorBiz.Subtract(currentValue, _valueToAdd);
        }
    }
}