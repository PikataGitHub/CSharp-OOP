namespace MobilePhoneDevice
{
    using System.Diagnostics;

    public class Battery
    {
        private BatteryType batteryType = new BatteryType();
        private string batteryModel;

        private Stopwatch hoursIdle = new Stopwatch();
        private Stopwatch hoursTalk = new Stopwatch();

        //Remark* Stopwatch objects cannot be set to 'null' because they throw NullReferenceException *

        public Battery(string modelOfBattery, BatteryType typeOfBattery)
        {
            this.BatteryModel = modelOfBattery;
            this.BatteryType = typeOfBattery;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;           
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

        public Stopwatch HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }

        public Stopwatch HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }
    }
}
