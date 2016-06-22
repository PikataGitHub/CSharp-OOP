namespace _08.Events
{
    using System;

    public class PublisherEventArgs : EventArgs
    {
        //Constrictor
        public PublisherEventArgs()
        {
            this.Time = DateTime.Now;
        }

        //Propertie
        public DateTime Time { get; }
    }
}