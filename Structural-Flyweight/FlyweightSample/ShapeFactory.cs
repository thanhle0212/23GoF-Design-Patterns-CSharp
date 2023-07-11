namespace FlyweightSample
{
    // FlyweightFacory
    // This is a factory class used to create concrete objects of the ConcreteFlyweight type
    public class ShapeFactory
    {
        //The Following Dictionary is going to act as our Cache Memory
        private static Dictionary<string, IShape> shapeMapping = new Dictionary<string, IShape>();

        //The following Method is going to return the Shape Object
        public static IShape GetShape(string shapeType)
        {
            IShape? shape = null;
            if (shapeType.Equals("circle", StringComparison.CurrentCultureIgnoreCase))
            {
                //If the key shapeType i.e. circle is stored in the Cache, then return the value of the key
                //else create circle object, store it in the Cache, and return the object
                if (shapeMapping.TryGetValue("circle", out shape))
                {
                }
                else
                {
                    shape = new Circle();
                    shapeMapping.Add("circle", shape);
                    Console.WriteLine("Creating circle object without any color");
                }
            }
            return shape;
        }
    }
}