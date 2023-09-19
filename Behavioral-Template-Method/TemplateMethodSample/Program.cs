using TemplateMethodSample;

Console.WriteLine("Build a Concrete House\n");
HouseTemplate houseTemplate = new ConcreteHouse();
//Call the Template Method to Build the Concrete House
houseTemplate.BuildHouse();
Console.WriteLine();
Console.WriteLine("Build a Wooden House\n");
houseTemplate = new WoodenHouse();
//Call the Template Method to Build the Wooden House
houseTemplate.BuildHouse();
Console.Read();