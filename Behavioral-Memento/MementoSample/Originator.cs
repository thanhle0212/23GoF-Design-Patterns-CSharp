namespace MementoSample
{
    public class Originator
    {
        // For the sake of simplicity, the originator's state is stored inside a
        // single variable.
        private int _state;

        public Originator(int state)
        {
            this._state = state;
            Console.WriteLine("Originator: My initial state is: " + state);
        }

        // The Originator's business logic may affect its internal state.
        // Therefore, the client should backup the state before launching
        // methods of the business logic via the save() method.
        public void GenerateNewState(int state)
        {
            this._state = state; 
            Console.WriteLine($"Originator: and my state has changed to: {_state}");
        }

        // Saves the current state inside a memento.
        public IMemento Save()
        {
            return new ConcreteMemento(this._state);
        }

        // Restores the Originator's state from a memento object.
        public void Restore(IMemento memento)
        {
            this._state = memento.GetState();
            Console.Write($"Originator: My state has changed to: {_state}");
        }
    }
}