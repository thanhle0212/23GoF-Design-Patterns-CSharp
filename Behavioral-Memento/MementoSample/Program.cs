using MementoSample;

Originator originator = new Originator();
Caretaker caretaker = new Caretaker();

originator.Product = new Product(1, "Item A", 10);
caretaker.AddMemento(originator.CreateMemento());

originator.Product = new Product(2, "Item B", 20);
caretaker.AddMemento(originator.CreateMemento());

originator.Product = new Product(3, "Item C", 30);
caretaker.AddMemento(originator.CreateMemento());

originator.RestoreMemento(caretaker.GetMemento(1));
Console.WriteLine($"Current product: {originator.Product}");