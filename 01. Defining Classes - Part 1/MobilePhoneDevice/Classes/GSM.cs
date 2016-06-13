namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        public static GSM iPhone4S = new GSM("iPhone 4S", "Apple")
        {
            PriceOfGSM = 899.99,
            OwnerOfGSM = "Unknown owner",       
            DisplayInformation = new Display(5.3, 1600000),
            BatteryInformation = new Battery(BatteryModel.Super_Alcaline, BatteryType.Li_Ion)
        };

        private string model;
        private string manufacturer;
        private double price;
        private string owner;        

        public GSM(string modelOfGSM, string manufacturerOfGSM)
        {
            this.ModelOfGSM = modelOfGSM;
            this.ManufacturerOfGSM = manufacturerOfGSM;
            this.CallHistory = new List<Call>();
        }

        public GSM(string modelOfGSM, string manufacturerOfGSM, double priceOfGSM, string ownerOfGSM, Display displayOfGSM, Battery batteryOfGSM) : this(modelOfGSM, manufacturerOfGSM)
        {
            this.PriceOfGSM = priceOfGSM;
            this.OwnerOfGSM = ownerOfGSM;
            this.DisplayInformation = displayOfGSM;
            this.BatteryInformation = batteryOfGSM;
        }

        public string ModelOfGSM
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Model name should be at least three characters");
                }
                this.model = value;
            }
        }

        public string ManufacturerOfGSM
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Model name should be at least three characters");
                }
                this.manufacturer = value;
            }
        }

        public double PriceOfGSM
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price of GSM must be more than Zero");
                }
                this.price = value;
            }
        }

        public string OwnerOfGSM
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length < 6)
                {
                    throw new AggregateException("name of the Owner must be at least Six characters");
                }
                this.owner = value;
            }
        }

        public Display DisplayInformation { get; set; }

        public Battery BatteryInformation { get; set; }

        public List<Call> CallHistory { get; set; }

        public void AddCall(Call inputCall)
        {
            this.CallHistory.Add(inputCall);
        }

        public void RemoveCall(int callIndexPosition)
        {
            if (callIndexPosition > CallHistory.Count)
            {
                throw new IndexOutOfRangeException("There isn't such a call!");
            }
            this.CallHistory.RemoveAt(callIndexPosition);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public double GetTotalPrice()
        {
            double sum = 0;
            foreach (var call in this.CallHistory)
            {
                sum += call.DurationOfCall * Call.PricePerMinute / 60;
            }
            return sum;
        }

        public override string ToString()
        {
            return $"Model: {this.ModelOfGSM}, Manufacturer: {this.ManufacturerOfGSM}, Price: {this.PriceOfGSM:F2} EUR, Owner: {this.OwnerOfGSM}, Display-{this.DisplayInformation}, Battery-{this.BatteryInformation}";
        }
    }
}
