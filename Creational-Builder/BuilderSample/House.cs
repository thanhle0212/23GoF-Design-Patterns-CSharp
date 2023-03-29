namespace BuilderSample
{
    // It makes sense to use the Builder Design Pattern only 
    // when your products are quite complex 
    // and require extensive configuration.
    // Using the following House class, we can configure different types of House
    public class House
    {
        public int Door { get; set; }
        public int Windows { get; set; }
        public string Wall { get; set; }
        public string Foundation { get; set; }
        public string Roof { get; set; }

        public void PrintHouseInfo()
        {
            Console.WriteLine($"Door : {this.Door}");
            Console.WriteLine($"Windows : {this.Windows}");
            Console.WriteLine($"Wall : {this.Wall}");
            Console.WriteLine($"Foundation : {this.Foundation}");
            Console.WriteLine($"Roof : {this.Roof}");
        }
    }
}