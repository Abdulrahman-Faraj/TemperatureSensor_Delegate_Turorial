namespace TemperatureSensor_Delegate_Turorial
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Sensor sensor = new Sensor();
            Display display = new Display();
            Alarm alarm = new Alarm(35);
            sensor.SensorChanged += display.ShowTemperature;
            sensor.SensorChanged += alarm.FireAlarm;
            while (true)
            {
                Console.WriteLine("Welcome to the temperature system");
                Console.WriteLine("1. Set the temperature ");
                Console.WriteLine("2. Set the alarm value (default 20)");
                Console.WriteLine("3. Exit");///test
                var chioce = Console.ReadLine();
                switch(chioce)
                {
                    case "1":
                        Console.WriteLine("Please enter the temperature value is degrees");
                        int temp = Convert.ToInt32(Console.ReadLine());
                        sensor.ChangeTemperature(temp);
                        break;
                    case "2":
                        Console.WriteLine("Please enter the temperature value for alarm");
                        int alarmvalue = Convert.ToInt32(Console.ReadLine());
                        alarm.SetAlarmValue(alarmvalue);
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("wrong input, please enter correct value");
                        break;
                }
            }
        }
    }
}
