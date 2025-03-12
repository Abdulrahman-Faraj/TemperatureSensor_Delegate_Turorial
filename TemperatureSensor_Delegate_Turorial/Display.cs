namespace TemperatureSensor_Delegate_Turorial
{
    class Display
    {
        public void ShowTemperature(object? obj , TempArgs tempArgs)
        {
            Console.WriteLine($"The temperature new set to {tempArgs.Temperature}");
        }
    }
}
