namespace MobilePhoneDevice
{
    using System;

    public class Display
    {
        private double displaySize;
        private int numberOfColours;

        public Display(double sizeOfDisplay)
        {
            this.SizeOfDisplay = sizeOfDisplay;
        }

        public Display(int numberOfColoursOfDisplay)
        {
            this.NumberOfColoursOfDisplay = numberOfColoursOfDisplay;
        }

        public Display(double sizeOfDisplay, int numberOfColoursOfDisplay) : this(sizeOfDisplay)
        {
            this.NumberOfColoursOfDisplay = numberOfColoursOfDisplay;
        }

        public double SizeOfDisplay
        {
            get
            {
                return this.displaySize;
            }
            private set
            {
                if (value <= 0)
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
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Display Colours should be bigger than Zero");
                }
                this.numberOfColours = value;
            }
        }

        public override string ToString()
        {
            return $"Size of Display: {this.SizeOfDisplay} inch, Colours: {this.NumberOfColoursOfDisplay} number of colors";
        }
    }
}
