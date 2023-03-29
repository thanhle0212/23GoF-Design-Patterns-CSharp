
namespace BuilderSample.Builder
{
    public class FancyHouseBuilder: HouseBuilder
    {
         public override void SetDoor()
        {
            houseObject.Door = 4;
        }

         public override void SetWindows()
        {
            houseObject.Windows = 10;
        }

         public override void SetWall()
        {
            houseObject.Wall = "Wood Wall";
        }

        public override void SetFoundation()
        {
            houseObject.Foundation = "Wood Foundation";
        }

        public override void SetRoof()
        {
            houseObject.Roof = "Woof Roof";
        }
    }
}