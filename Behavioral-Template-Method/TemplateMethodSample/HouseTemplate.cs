namespace TemplateMethodSample
{
    public abstract class HouseTemplate
    {
         // Template Method defines the sequence for building a house
        public void BuildHouse()
        {
            //Define the Steps to Build a House
            BuildFoundation(); //Step1
            BuildPillars(); //Step2
            BuildWalls(); //Step3
            BuildWindows(); //Step4
            Console.WriteLine("House is Built");
        }

        // Default implementation 
        protected virtual void BuildFoundation()
        {
            Console.WriteLine("Building foundation with cement, iron rods and sand");
        }

        // Methods to be implemented by subclasses
        protected abstract void BuildPillars();
        protected abstract void BuildWalls();
        protected abstract void BuildWindows();
    }
}