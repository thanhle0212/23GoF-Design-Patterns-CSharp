using MementoSample;

// Client code.
Originator originator = new Originator(1);
Caretaker caretaker = new Caretaker(originator);

caretaker.Backup();
originator.GenerateNewState(5);

caretaker.Backup();
originator.GenerateNewState(10);

caretaker.Backup();
originator.GenerateNewState(100);

Console.WriteLine();
caretaker.ShowHistory();

Console.WriteLine("\nClient: Now, let's rollback!\n");
caretaker.Undo();

Console.WriteLine("\n\nClient: Once more!\n");
caretaker.Undo();

Console.WriteLine();