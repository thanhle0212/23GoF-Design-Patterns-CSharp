// Build a collection
using IteratorSample;

ConcreteCollection collection = new ConcreteCollection();
collection.AddEmployee(new Elempoyee("Thanh", 1));
collection.AddEmployee(new Elempoyee("Dave", 2));
collection.AddEmployee(new Elempoyee("Matt", 3));
collection.AddEmployee(new Elempoyee("Leon", 4));
collection.AddEmployee(new Elempoyee("Peter", 5));
collection.AddEmployee(new Elempoyee("Tom", 6));

// Create iterator
Iterator iterator = collection.CreateIterator();
//looping iterator      
Console.WriteLine("Iterating over collection:");

for (Elempoyee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
{
    Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
}
