using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandSample
{
    public interface ICommand
    {
        double Execute(double value);
        double Undo(double value);
    }
}