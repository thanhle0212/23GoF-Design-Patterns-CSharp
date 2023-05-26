namespace CompositeSample
{
    // The Leaf class represents the end objects. 
    // A leaf can't have any children.
    // The Leaf object is the Object which does the actual work
    public class Leaf : IComponent
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Leaf(string productName, double price)
        {
            this.ProductName = productName;
            this.Price = price;
        }
        public void DisplayPrice()
        {
            Console.WriteLine($"\tProduct Name : {ProductName} and Price : {Price}");
        }
    }
}