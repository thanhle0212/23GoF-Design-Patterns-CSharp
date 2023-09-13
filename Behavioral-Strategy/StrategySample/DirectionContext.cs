namespace StrategySample
{
    // The Context Provides the interface which is going to be used by the Client.
    public class DirectionContext
    {
        // The Context has a reference to one of the Strategy objects. 
        // The Context does not know the concrete class of a strategy. 
        // It should work with all strategies via the Strategy interface.
        private IDirection _direction;


        //Initializing the Strategy Object i.e. Direction using Constructor
        public DirectionContext(IDirection direction)
        {
            // The Context accepts a strategy through the constructor, 
            // but also provides a setter method to change the strategy at runtime
            _direction = direction;
        }

          //The Context allows replacing a Strategy object at runtime.
        public void SetStrategy(IDirection direction)
        {
            _direction = direction;
        }

         // The Context delegates the work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void FindBestRoute()
        {
            //The CompressFolder method is going to be invoked based on the strategy object
            _direction.FindBestRoute();
        }
    }
}