namespace TemperatureSensor_Delegate_Turorial
{
    class TempArgs : EventArgs 
    {
        // can be adding more details
        public int Temperature  { get; set; }
        public TempArgs(int temp)
        {
            Temperature = temp;
        }
    }

}
