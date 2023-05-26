// The client code works with all of the components (Both Leaf and Composite) via the base interface i.e. IComponent.
// IComponent means the class that implements the IComponent Interface
//Creating Leaf Objects or you can say child objects
using CompositeSample;

IComponent headPhone = new Leaf("Head Phone", 250);
IComponent usb = new Leaf("USB", 15);
IComponent iphoneCase = new Leaf("Iphone Case", 5);
IComponent mouse = new Leaf("Mouse", 200);
IComponent lamp = new Leaf("Lamp", 150);
IComponent keyboard = new Leaf("Keyboard", 300);

//Creating Composite Objects
Composite box1 = new Composite("Box 1");
Composite box2 = new Composite("Box 2");
Composite box3 = new Composite("Box 3");
//Creating Tree Structure i.e. Adding Child Components inside the Composite Component
//Adding CPU and RAM in Mother Board
box1.AddComponent(headPhone);
box1.AddComponent(usb);
//Adding Mother Board and Hard Disk in Cabinet
box2.AddComponent(iphoneCase);
box2.AddComponent(mouse);
//Adding Mouse and Keyboard in peripherals
box3.AddComponent(lamp);
box3.AddComponent(keyboard);

//To Display the Price of the Box 1 i.e. it will display the Price of all components
Console.WriteLine("Price of Box 1 Composite Components");
box1.DisplayPrice();
//To display the Price of the Head Phone
Console.WriteLine("\nPrice of Head Phone Child or Leaf Component:");
headPhone.DisplayPrice();

//To display the Price of the Box 2
Console.WriteLine("\nPrice of Box 2 Composite Component:");
box2.DisplayPrice();

//To display the Price of the Box 3
Console.WriteLine("\nPrice of Box 3 Composite Component:");
box3.DisplayPrice();
Console.ReadLine();