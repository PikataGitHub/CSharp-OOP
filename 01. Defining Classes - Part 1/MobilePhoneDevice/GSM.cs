namespace MobilePhoneDevice
{
    using System;
    

    public class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;

        public GSM(string modelOfGSM, string manufacturerOfGSM)
        {
            this.ModelOfGSM = modelOfGSM;
            this.ManufacturerOfGSM = manufacturerOfGSM;        
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

        public override string ToString()
        {
            var informationAboutGSM = new StringBuilder();


            return base.ToString();
        }
    }
}
