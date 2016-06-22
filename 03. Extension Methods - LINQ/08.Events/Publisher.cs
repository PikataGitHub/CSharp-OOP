namespace _08.Events
{
    using System;
    using System.Threading;

    public class Publisher
    {
        public event EventHandler<PublisherEventArgs> Handler;

        //Constructor
        public Publisher(int interval)
        {
            this.Interval = interval;
        }

        //Propertie
        public int Interval { get; }

        //Methods
        public void Start()
        {
            if (this.Interval <= 0)
            {
                throw new ArgumentException("Time Interval Must be a Positive Integer");
            }

            while (! Console.KeyAvailable)
            {
                if (Handler != null)
                {
                    Thread.Sleep(this.Interval * 1000);
                    Handler(this, new PublisherEventArgs());
                }
                else
                {
                    Console.WriteLine("There are no subscribers!");
                    break;
                }
            }
        }
    }
}

