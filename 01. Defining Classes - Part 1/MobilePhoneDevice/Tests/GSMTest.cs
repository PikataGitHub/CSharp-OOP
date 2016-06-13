namespace MobilePhoneDevice.Tests
{
    using MobilePhoneDevice;
    using System;

    public class GSMTest
    {
        public static void TestDevice()
        {
            Console.WriteLine("Problem 7. GSM test" + Environment.NewLine);

            //Create an array of GSMs
            var testArray = new GSM[]
                {
                    new GSM("Galaxy S III", "SAMSUNG"),
                    new GSM("Galaxy S IV", "SAMSUNG", 689.99, "Ivan Ivanov", new    Display(5.1, 32000), new    Battery(BatteryModel.Super_Alcaline, BatteryType.Li_Ion)),
                    new GSM("Galaxy S V", "SAMSUNG", 799.99, "Petar Petrov", new    Display(32000), new    Battery(BatteryType.Silver_Oxide)),
                    GSM.iPhone4S
                };

            //Display info about GSM and IPhone4S
            foreach (var gsm in testArray)
            {
                Console.WriteLine(gsm.ToString());
                Console.WriteLine();
            }
        }
    }
}
