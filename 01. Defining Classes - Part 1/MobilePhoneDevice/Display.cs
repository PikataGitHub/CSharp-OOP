namespace MobilePhoneDevice
{
    using System;

    public class Display
    {
        private double displaySize;
        private int numberOfColours;

        public Display(double sizeOfDisplay, int numberOfColoursOfDisplay)
        {
            this.SizeOfDisplay = sizeOfDisplay;
            this.NumberOfColoursOfDisplay = numberOfColoursOfDisplay;
        }

        public double SizeOfDisplay
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Display Size should be bigger than Zero");
                }
                this.displaySize = value;
            }
        }

        public int NumberOfColoursOfDisplay
        {
            get
            {
                return this.numberOfColours;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Display Colours should be bigger than Zero");
                }
                this.numberOfColours = value;
            }
        }
    }
}
