namespace MementoSample
{
    public class Originator
    {
        public Product Product { get; set; }

        public Memento CreateMemento()
        {
            return new Memento(Product);
        }

        public void RestoreMemento(Memento memento)
        {
            Product = memento.ProductSnapshot;
        }
    }
}