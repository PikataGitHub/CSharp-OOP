namespace MobilePhoneDevice.Tests
{
    using System;
    using System.Linq;

    class GSMCallHistoryTest
    {
        public static void CallHistoryTest()
        {
            Console.WriteLine(Environment.NewLine + "Problem 12. Call history test" + Environment.NewLine);

            // Create instance of GSM
            GSM testPhone = new GSM("GT-9000", "SAMSUNG", 156.99, "Georgi Georgiev", new Display(4.2, 32000), new Battery(BatteryModel.Super_Alcaline, BatteryType.NiMH));

            // Add few calls
            testPhone.AddCall(new Call(DateTime.Now, "++35988856479", 180));
            testPhone.AddCall(new Call(DateTime.Now.AddMinutes(10), "++35988856479", 1020));
            testPhone.AddCall(new Call(DateTime.Now.AddMinutes(20), "++35988856479", 100));
            testPhone.AddCall(new Call(DateTime.Now.AddMinutes(30), "++35988856479", 480));
            testPhone.AddCall(new Call(DateTime.Now.AddMinutes(40), "++35988856479", 222));

            // Display information about calls
            for (int i = 0; i < testPhone.CallHistory.Count; i++)
            {
                Console.WriteLine(testPhone.CallHistory[i]);
            }
            Console.WriteLine();

            //Calculate and print total price            
            Console.WriteLine("Total price of calls in history is: {0:f2} EUR", testPhone.GetTotalPrice());

            //Find and remove longest call from history and calculate total price again
            var longestCallIndex = testPhone.CallHistory
                .FindIndex(c => c.DurationOfCall == testPhone.CallHistory.Max
                (item => item.DurationOfCall));

            testPhone.RemoveCall(longestCallIndex);

            Console.WriteLine("Total price of calls in history after removing the longest call is: {0:f2} EUR", testPhone.GetTotalPrice());

            //Clear call history and print to show that is empty
            testPhone.ClearCallHistory();
            Console.WriteLine(testPhone.CallHistory.Count);
        }
    }
}
