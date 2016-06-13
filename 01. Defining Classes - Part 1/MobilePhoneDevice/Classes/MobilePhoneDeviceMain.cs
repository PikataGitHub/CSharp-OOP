namespace MobilePhoneDevice
{
    using MobilePhoneDevice.Tests;
    
    class MobilePhoneDeviceMain
    {
        static void Main()
        {
            GSMTest.TestDevice();

            GSMCallHistoryTest.CallHistoryTest();            
        }
    }
}
