namespace StateSample
{
    public class Steak
    {
        private IStateOfSteak state;
        private int temperature;
        public Steak()
        {
            // Initialize with the rare state and a low temperature
            state = new RareSteakState();
            temperature = 0;
        }
        public void SetState(IStateOfSteak newState)
        {
            state = newState;
        }
        public void Cook()
        {
            temperature += 10; // Simulate cooking and raising the temperature
            Console.WriteLine($"Current temperature: {temperature} degrees");
            state.Cook(this);
        }
        public int GetTemperature()
        {
            return temperature;
        }
    }
}