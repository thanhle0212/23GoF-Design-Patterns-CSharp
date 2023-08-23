namespace MementoSample
{
    public class Memento
    {
        public Product ProductSnapshot { get; private set; }

        public Memento(Product product)
        {
            ProductSnapshot = new Product(product.ID, product.Name, product.Quantity);
        }
    }
}