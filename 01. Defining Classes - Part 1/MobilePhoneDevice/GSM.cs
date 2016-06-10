namespace MobilePhoneDevice
{
    using System.Text;

    public class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Display displayInformation;
        private Battery batteryInformation;

        public GSM(string modelOfGSM, string manufacturerOfGSM)
        {
            this.model = modelOfGSM;
            this.manufacturer = manufacturerOfGSM;
        }

        public GSM(string modelOfGSM, string manufacturerOfGSM, double priceOfGSM, string ownerOfGSM, Display displayOfGSM, Battery batteryOfGSM) : this(modelOfGSM, manufacturerOfGSM)
        {
            this.price = priceOfGSM;
            this.owner = ownerOfGSM;
            this.displayInformation = displayOfGSM;
            this.batteryInformation = batteryOfGSM;
        }

        public override string ToString()
        {
            var informationAboutGSM = new StringBuilder();


            return base.ToString();
        }
    }
}
