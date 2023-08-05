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

        public double Execute(double currentValue) => currentValue += _valueToAdd;
        public double Undo(double currentValue) => currentValue -= _valueToAdd;
    }
}