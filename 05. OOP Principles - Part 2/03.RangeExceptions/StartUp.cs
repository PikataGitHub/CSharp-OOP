namespace _03.RangeExceptions
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            //Test with int value outside range
            try
            {
                int inputNumber = 260;
                Console.WriteLine("Number = " + inputNumber);

                if (inputNumber < 1 || inputNumber > 100)
                {
                    throw new InvalidRangeException<int>("Invalid Number, Not in range:", 1, 100);
                }
            }
            catch (InvalidRangeException<int> exeption)
            {
                Console.WriteLine(String.Format("{0} [{1};{2}]",exeption.Message, exeption.Start, exeption.End));
            }
            Console.WriteLine();
            
            //Test with dates outside range
            try
            {
                DateTime inputDate = DateTime.Parse("10/10/2015");
                Console.WriteLine("Date = " + inputDate);

                if (inputDate < new DateTime(1980, 1, 1) || inputDate > new DateTime(2013, 12, 31))
                {
                    throw new InvalidRangeException<DateTime>("Invalid Date, Not in range:", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                }
            }
            catch (InvalidRangeException<DateTime> exeption)
            {
                Console.WriteLine(String.Format("{0} [{1:dd/MM/yyyy};{2:dd/MM/yyyy}]", exeption.Message, exeption.Start.Date, exeption.End.Date));
            }
            Console.WriteLine();
        }
    }
}
