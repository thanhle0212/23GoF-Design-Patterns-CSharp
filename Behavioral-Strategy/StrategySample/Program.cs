// The client code picks a concrete strategy and passes it to the context. 
// The client should be aware of the differences between strategies in order to make the right choice.
//Create an instance of Direction Strategy
using StrategySample;

IDirection strategy = new BicycleRoute();

//Pass Direction Strategy as an argument to the DirectionContext constructor
DirectionContext ctx = new DirectionContext(strategy);
ctx.FindBestRoute();

//Changing the Strategy using SetStrategy Method
ctx.SetStrategy(new CarRoute());
ctx.FindBestRoute();
Console.Read();