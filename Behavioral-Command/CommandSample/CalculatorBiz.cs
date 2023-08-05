using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandSample
{
    public class CalculatorBiz
    {
        public double Add(double currentValue, double _valueToAdd) => currentValue += _valueToAdd;
        public double Subtract(double currentValue, double _valueToSubtract) => currentValue -= _valueToSubtract;
        public double Multiply(double currentValue, double _valueToMultiply) => currentValue *= _valueToMultiply;
        public double Divide(double currentValue, double _valueToDivide) => currentValue /= _valueToDivide;
    }
}