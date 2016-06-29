namespace _03.RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        //Constructors
        public InvalidRangeException(string errorMessage, T start, T end) : base(errorMessage)
        {
            this.Start = start;
            this.End = end;
        }

        //Properties
        public T Start { get; private set; }

        public T End { get; private set; }
    }
}
