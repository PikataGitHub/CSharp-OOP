namespace Timer_07
{
    using System;
    using System.Diagnostics;

    //Delegate definition
    public delegate void TimerDelegate();

    public class Timer
    {
        //Fields
        private int seconds;

        //Constructors
        public Timer(int seconds)
        {
            this.Seconds = seconds;
        }

        //Properties
        public int Seconds
        {
            get
            {
                return this.seconds;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Timer must must be set with positive values!");
                }
                this.seconds = value;
            }
        }

        //Methods
        public void GetTimeWithDelegate()
        {
            GetSomeTime();
            Stopwatch timerToStop = new Stopwatch();
            timerToStop.Start();
            TimerDelegate delegateToCall = new TimerDelegate(GetSomeTime);

            do
            {
                if (timerToStop.Elapsed.Seconds != Seconds)
                {
                    continue;                                     
                }
                delegateToCall.Invoke();
                timerToStop.Restart();
            } while (! Console.KeyAvailable);            
        }

        public void GetSomeTime()
        {
            Console.WriteLine( String.Format("{0}:{1}:{2}", DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond));
        }
    }
}
