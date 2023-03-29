namespace BuilderSample.Builder
{
    // The Builder Abstract Class specifies methods for creating the different parts
    // of the Product objects.
    public abstract class HouseBuilder
    {
        protected House houseObject;

        public abstract void SetDoor();
        public abstract void SetWindows();
        public abstract void SetWall();
        public abstract void SetFoundation();
        public abstract void SetRoof();
        public void CreateNewHouse()
        {
            houseObject = new House();
        }

        public House GetHouse()
        {
            return houseObject;
        }
    }
}