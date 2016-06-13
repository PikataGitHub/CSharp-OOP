namespace MobilePhoneDevice
{
    using System.Diagnostics;

    public class Battery
    {
        private BatteryType batteryType;
        private BatteryModel batteryModel;

        public Battery(BatteryType typeOfBattery)
        {
            this.BatteryType = typeOfBattery;
            this.HoursIdle = new Stopwatch();
            this.HoursTalk = new Stopwatch();
            this.BatteryModel = BatteryModel.Unknown_Model;
        }

        public Battery(BatteryModel modelOfBattery, BatteryType typeOfBattery) : this(typeOfBattery)
        {
            this.BatteryModel = modelOfBattery;            
        }

        public BatteryModel BatteryModel
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

        public override string ToString()
        {
            return $"Battery Model: {this.BatteryModel}, Battery Type: {this.BatteryType}, Idle: {this.HoursIdle.Elapsed} hours idle, Talk: {this.HoursTalk.Elapsed} hours talk";
        }
    }
}

