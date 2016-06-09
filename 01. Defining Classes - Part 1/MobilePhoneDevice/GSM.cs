namespace MobilePhoneDevice
{
    using System.Text;

    public class GSM
    {
        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        private Display displayInfo = new Display();
        private Battery batteryInfo = new Battery();

        public GSM(string modelOfGSM, string manufacturerOfGSM)
        {
            this.model = modelOfGSM;
            this.manufacturer = manufacturerOfGSM;
        }

        public GSM(string modelOfGSM, string manufacturerOfGSM, int priceOfGSM, string ownerOfGSM, Display displayOfGSM, Battery batteryOfGSM) : this(modelOfGSM, manufacturerOfGSM)
        {
            this.price = priceOfGSM;
            this.owner = ownerOfGSM;
            this.displayInfo = displayOfGSM;
            this.batteryInfo = batteryOfGSM;
        }


        public override string ToString()
        {
            var informationAboutGSM = new StringBuilder();


            return base.ToString();
        }
    }
}
