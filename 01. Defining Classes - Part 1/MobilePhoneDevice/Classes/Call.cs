namespace MobilePhoneDevice
{
    using System;

    public class Call
    {
        public const double PricePerMinute = 0.37;

        public Call(DateTime date, string dialedNumber, int durationOfCall)
        {
            this.DateAndTime = date;
            this.DialedNumber = dialedNumber;
            this.DurationOfCall = durationOfCall;
        }

        public DateTime DateAndTime { get; private set; }

        public string DialedNumber { get; private set; }

        public int DurationOfCall { get; private set; }

        public override string ToString()
        {
            return $"{this.DateAndTime.Date : dd/MM/yyyy}, {this.DateAndTime.TimeOfDay}, {this.DialedNumber}, {this.DurationOfCall} seconds";
        }
    }
}
