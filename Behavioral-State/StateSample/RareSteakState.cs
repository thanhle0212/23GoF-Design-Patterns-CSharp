namespace StateSample
{
    public class RareSteakState : IStateOfSteak
    {
        public void Cook(Steak steak)
        {
            if (steak.GetTemperature() < 130)
            {
                Console.WriteLine("Cooking the steak rare.");
            }
            else
            {
                Console.WriteLine("Cooking the steak medium-rare.");
                steak.SetState(new MediumRareSteakState());
            }
        }
    }
}