// See https://aka.ms/new-console-template for more information
using FactoryMethodSample;

var client = new Client();

// Deliver by Ship
client.Deliver(new CheapShipping());

// Deliver by Car
client.Deliver(new RegularShipping());

// Deliver by Aircraft
client.Deliver(new FastShipping());