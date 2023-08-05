//Create the chain links
using CoRSample;

IHandler tech = new TechManager();
IHandler cto = new CTO();
IHandler ceo = new CEO();

tech.SetTheNextHandler(cto);
cto.SetTheNextHandler(ceo);

// Generate and process purchase requests
var purchase1 = new Product("DELL Laptop", 1600);
tech.Process(purchase1);

var purchase2 = new Product("Macbook Pro", 4000);
tech.Process(purchase2);

var purchase3 = new Product("New Car", 30000);
tech.Process(purchase3);

