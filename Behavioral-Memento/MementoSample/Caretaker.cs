namespace MementoSample
{
    public class Caretaker
    {
        private List<Memento> mementos = new List<Memento>();

        public void AddMemento(Memento memento)
        {
            mementos.Add(memento);
        }

        public Memento GetMemento(int index)
        {
            return mementos[index];
        }
    }
}