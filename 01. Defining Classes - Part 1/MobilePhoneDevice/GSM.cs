namespace MobilePhoneDevice
{
    public class GSM
    {
        readonly string model;
        readonly string manufacturer;
        int price;
        string owner;
        private Display display = new Display();
        private Battery battery = new Battery();

        public GSM(string modelOfGSM, string manufacturerOfGSM)
        {
            this.model = modelOfGSM;
            this.manufacturer = manufacturerOfGSM;
        }

        public GSM(string modelOfGSM, string manufacturerOfGSM, Display displayOfGSM, Battery batteryOfGSM) : this(modelOfGSM, manufacturerOfGSM)
        {

            this.display = displayOfGSM;
            this.battery = batteryOfGSM;
        }
    }
}
