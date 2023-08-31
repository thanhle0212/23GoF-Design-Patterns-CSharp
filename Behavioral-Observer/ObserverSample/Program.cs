//Create a Product with Out of Stock Status
using ObserverSample;

Publisher iphone15 = new Publisher("Apple Iphone15", 1500, "Out Of Stock");

Subscriber customer1 = new Subscriber("Thanh");
iphone15.RegisterSubscriber(customer1);

Subscriber customer2 = new Subscriber("Lee");
iphone15.RegisterSubscriber(customer2);

Subscriber customer3 = new Subscriber("Tom");
iphone15.RegisterSubscriber(customer3);

iphone15.RemoveSubscriber(customer3);

iphone15.SetAvailability();