namespace MobilePhoneDevice
{
    using System.Diagnostics;

    public class Battery
    {
        private BatteryType batteryType;
        private string batteryModel;

        public Battery(BatteryType typeOfBattery)
        {
            this.BatteryType = typeOfBattery;
            this.HoursIdle = new Stopwatch();
            this.HoursTalk = new Stopwatch();
        }

        public Battery(string modelOfBattery, BatteryType typeOfBattery) : this(typeOfBattery)
        {
            this.BatteryModel = modelOfBattery;            
        }

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            private set
            {
                this.batteryModel = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            private set
            {
                this.batteryType = value;
            }
        }

        public Stopwatch HoursIdle { get; set; }

        public Stopwatch HoursTalk { get; set; }
    }
}

