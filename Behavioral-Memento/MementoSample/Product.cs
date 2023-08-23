namespace MementoSample
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Product(int id, string name, int quantity)
        {
            ID = id;
            Name = name;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Quantity: {Quantity}";
        }
    }
}