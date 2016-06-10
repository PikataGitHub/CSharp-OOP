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

        }
    }
}
