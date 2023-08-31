namespace MementoSample
{
    public class ConcreteMemento: IMemento
    {
        private int _state;
        private DateTime _date;
        public ConcreteMemento(int state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        // The Originator uses this method when restoring its state.
        public int GetState()
        {
            return this._state;
        }
        
        // The rest of the methods are used by the Caretaker to display
        // metadata.
        public string GetName()
        {
            return $"{this._date} / ({this._state})";
        }
    }
}