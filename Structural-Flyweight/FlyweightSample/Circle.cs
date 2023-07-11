namespace FlyweightSample
{
    public class Circle : IShape
    {
        public string Color { get; set; }

        private readonly int XCor = 10;
        private readonly int YCor = 20;
        private readonly int Radius = 30;

        public void SetColor(string color)
        {
            this.Color = color;
        }

        public void Draw()
        {
            Console.WriteLine($" Circle: Draw() [Color : {Color}, X Cor : {XCor}, YCor :{YCor}, Radius :{Radius}");
        }
    }
}