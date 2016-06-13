namespace MobilePhoneDevice
{    
    class MobilePhoneDeviceMain
    {
        static void Main()
        {
            GSM phone = new GSM("GT-9000", "SAMSUNG", 23.6856, "Petko Yanev", new Display(5.5, 32000), new Battery("Fixed", BatteryType.NiCd));

            System.Console.WriteLine(phone);

            Battery nokiabattery = new Battery("red", BatteryType.Silver_Oxide);

            System.Console.WriteLine(nokiabattery.HoursIdle.Elapsed);

            GSM phoneTes = new GSM("galaxy III", "SAMSUNG");

            System.Console.WriteLine(phoneTes.PriceOfGSM);


            phoneTes.DisplayInformation = new Display(654);


            phoneTes.BatteryInformation = new Battery("square", BatteryType.NiMH);

            //System.Console.WriteLine(phoneTes.BatteryInformation.BatteryType);
            phoneTes.OwnerOfGSM = "Dimitar";
           System.Console.WriteLine(phoneTes.OwnerOfGSM);
            System.Console.WriteLine(phone.DisplayInformation.NumberOfColoursOfDisplay.ToString());
            System.Console.WriteLine(phoneTes.DisplayInformation.NumberOfColoursOfDisplay);
            System.Console.WriteLine(phoneTes.DisplayInformation.SizeOfDisplay);
        }
    }
}
