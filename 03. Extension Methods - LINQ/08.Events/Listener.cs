namespace _08.Events
{
    using System;

    public class Listener
    {
        //Properties
        public int Counter { get; private set; }

        public int MaxCounter { get; set; }

        //Constructor
        public Listener(int maxCounter)
        {
            this.Counter = 0;
            this.MaxCounter = maxCounter;
        }

        //Methods
        protected virtual void OnHandler(object sender, PublisherEventArgs e)
        {
            this.Counter++;

            Console.WriteLine("Seconds Elapsed: {0}", this.Counter);
            Console.WriteLine("Current Time:{0} ", e.Time);

            if (this.Counter == this.MaxCounter)
            {
                Unsubscribe((Publisher)sender);
            }
        }

        public void Subscribe(Publisher publisher)
        {
            publisher.Handler += OnHandler;
        }

        public void Unsubscribe(Publisher publisher)
        {
            publisher.Handler -= OnHandler;
        }
    }
}
