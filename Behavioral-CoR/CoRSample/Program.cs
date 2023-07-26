//Create the chain links
using CoRSample;

IHandler tech = new TechManager();
IHandler cto = new CTO();
IHandler ceo = new CEO();

tech.SetTheNextHandler(cto);
cto.SetTheNextHandler(ceo);

// Generate and process purchase requests
var purchase1 = new GadgetPurchase("DELL Laptop", 1600);
tech.Process(purchase1);

var purchase2 = new GadgetPurchase("Macbook Pro", 3000);
tech.Process(purchase2);

var purchase3 = new GadgetPurchase("New Car", 30000);
tech.Process(purchase3);

