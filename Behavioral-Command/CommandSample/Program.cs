using CommandSample;

var calculator = new Calculator();
calculator.ExecuteCommand(new AddCommand(20)); // -> 20
calculator.ExecuteCommand(new SubtractCommand(10)); // -> 10
calculator.ExecuteCommand(new MultiplyCommand(5)); // -> 50
calculator.ExecuteCommand(new DivideCommand(5)); // -> 10
Console.WriteLine(calculator.CurrentValue); // output 10

calculator.Undo(); // 50
Console.WriteLine(calculator.CurrentValue); // output 50