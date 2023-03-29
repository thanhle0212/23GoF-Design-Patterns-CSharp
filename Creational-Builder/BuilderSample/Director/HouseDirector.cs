using BuilderSample.Builder;

namespace BuilderSample.Director
{
    // The Director is only responsible for executing the building steps in a particular order. 
    // It is helpful when producing products according to a specific order or configuration. 
    public class HouseDirector
    {
        public House BuildHouse(HouseBuilder houseBuilder)
        {
            houseBuilder.CreateNewHouse();
            houseBuilder.SetDoor();
            houseBuilder.SetWindows();
            houseBuilder.SetWall();
            houseBuilder.SetFoundation();
            houseBuilder.SetRoof();
            return houseBuilder.GetHouse();
        }
    }
}