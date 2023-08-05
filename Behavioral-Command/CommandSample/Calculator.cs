using System.Reflection.Emit;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandSample
{
    public class Calculator
    {
        public double CurrentValue
        {
            get; private set;
        }

        public Stack<ICommand> _commandHistory = new();

        public void ExecuteCommand(ICommand command)
        {
            CurrentValue = command.Execute(CurrentValue);
            _commandHistory.Push(command);
        }

        public void Undo()
        {
            var command = _commandHistory.Pop();
            CurrentValue = command.Undo(CurrentValue);
        }
    }
}