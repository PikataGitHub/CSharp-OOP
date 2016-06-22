namespace InfiniteConvergentSeries_20
{
    using System;

    class InfiniteConvergentSeries
    {
        static void Main()
        {
            //Problem 20.* Infinite convergent series
            var firstConvergentSum = ConvergentFirstSum(index => 1 / Math.Pow(2, index - 1), 0.01);
            Console.Write("First Convergent Sum:  ");
            Console.WriteLine("{0:F2}", firstConvergentSum);

            //var secondConvergentSum = ConvergentSecondSum(index => (1 /(index - 1)), 0.01);
            //Console.Write("Second Convergent Sum:  ");
            //Console.WriteLine("{0:F2}", secondConvergentSum);

            var thirdConvergentSum = ConvergentThirdSum(index => 1 / Math.Pow(2, index - 1), 0.01);
            Console.Write("Third Convergent Sum:  ");
            Console.WriteLine("{0:F2}", thirdConvergentSum);


        }
        
        public static double ConvergentFirstSum(Func<int, double> termValue, double precision)
        {
            double sum = 1;
            int counter = 2;

            do
            {
                sum += termValue(counter);
                counter++;

            } while (Math.Abs(termValue(counter)) > precision);
            return sum;
        }

        //To Be tested ...
        private static double ConvergentSecondSum(Func<int, double> termValue, double precision)
        {
            double sum = 1;
            int counter = 2;
            double previous = termValue(counter);
            
            do
            {
                sum += termValue(counter);
                counter++;

            } while (Math.Abs(termValue(counter)) > precision);
            return sum;
        }


        public static double ConvergentThirdSum(Func<int, double> termValue, double precision)
        {
            double sum = 1;
            int counter = 2;

            do
            {
                if (counter % 2 != 0)
                {
                    sum -= termValue(counter);
                    counter++;
                    continue;                  
                }
                sum += termValue(counter);
                counter++;

            } while (Math.Abs(termValue(counter)) > precision);
            return sum;
        }
    }
}
