namespace _02.BankAccounts.Models.Accounts
{
    using Enumerations;
    using Interfaces;
    using Interfaces.Constants;
    using System;

    public class Mortgage : Account, IDepositable
    {
        //Fields
        private const int InitialMonthsPeriodOfDecreasedInterest = 12;
        private const decimal InitialInterestRateCoefficient = 0.5m;
        private const int InitialNoInterestPeriod = 6;

        //Constructors
        public Mortgage(Custumer custumer, DateTime startDate, decimal startBallance, decimal interestRate) : base(custumer, startDate, startBallance, interestRate) { }

        //Methods
        public override decimal CalculateInterestForDate(DateTime date)
        {
            var monthsPeriod = (date.Month + date.Year * 12) - (StartAccountDate.Month + StartAccountDate.Year * 12);

            if (Custumer.Type == CustumerType.Company)
            {
                if (monthsPeriod <= InitialMonthsPeriodOfDecreasedInterest)
                {
                    InterestRateMonthlyBased *= InitialInterestRateCoefficient;
                    BallanceInEuro += monthsPeriod * InterestRateMonthlyBased;

                    return monthsPeriod * InterestRateMonthlyBased;
                }
                else
                {
                    BallanceInEuro += InitialMonthsPeriodOfDecreasedInterest * InitialInterestRateCoefficient * InterestRateMonthlyBased + (monthsPeriod - InitialMonthsPeriodOfDecreasedInterest) * InterestRateMonthlyBased;

                    return InitialMonthsPeriodOfDecreasedInterest * InitialInterestRateCoefficient * InterestRateMonthlyBased + (monthsPeriod - InitialMonthsPeriodOfDecreasedInterest) * InterestRateMonthlyBased;
                }
            }
            else
            {
                if (monthsPeriod <= InitialNoInterestPeriod)
                {
                    return GlobalConstants.ZeroInterestRate;
                }
                else
                {
                    BallanceInEuro += monthsPeriod * InterestRateMonthlyBased;
                    return monthsPeriod * InterestRateMonthlyBased;
                }
            }            
        }
    }
}
