namespace TemperatureSensor_Delegate_Turorial
{
    class Alarm
    {
        private int AlarmValue { get; set; }
        public Alarm(int alarmtemp)
        {
            AlarmValue = alarmtemp;
        }
        public void SetAlarmValue(int newAlarmValue)
        {
            AlarmValue = newAlarmValue;
        }
        public void FireAlarm(object? obj,TempArgs tempArgs)
        {
            if (tempArgs.Temperature > AlarmValue)
            {
                Console.WriteLine($"Take care, the temp value {tempArgs.Temperature} is grater than {AlarmValue}");
            }
        }
    }
}
