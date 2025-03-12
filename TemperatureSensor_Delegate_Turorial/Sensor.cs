namespace TemperatureSensor_Delegate_Turorial
{

    class Sensor
    {
        //declare event
        public event EventHandler<TempArgs> SensorChanged;
        private int CurrentTemperature { get; set; }
        
        public void ChangeTemperature(int newTemperatue)
        {
            CurrentTemperature = newTemperatue;
            SensorChanged.Invoke(this,new TempArgs(newTemperatue));
        }


    }
}
