namespace _02.BankAccounts.Models.Accounts
{
    using Enumerations;
    using Interfaces;
    using Interfaces.Constants;
    using System;

    public class Loan : Account, IDepositable
    {
        //Fields
        private const int InitialPeriodWithoutInterestByIndividuals = 3;
        private const int InitialPeriodWithoutInterestByCompanies = 2;        

        //Constructors
        public Loan(Custumer custumer, DateTime startDate, decimal startBallance, decimal interestRate) : base(custumer, startDate, startBallance, interestRate) { }

        //Methods
        public override decimal CalculateInterestForDate(DateTime date)
        {
            var monthsPeriod = (date.Month + date.Year * 12) - (StartAccountDate.Month + StartAccountDate.Year * 12);

            if (monthsPeriod > InitialPeriodWithoutInterestByIndividuals && Custumer.Type == CustumerType.Individual)
            {
                int monthsWithInterest = monthsPeriod - InitialPeriodWithoutInterestByIndividuals;
                BallanceInEuro += monthsWithInterest * InterestRateMonthlyBased;
                return monthsWithInterest * InterestRateMonthlyBased;
            }
            else if (monthsPeriod > InitialPeriodWithoutInterestByCompanies && Custumer.Type == CustumerType.Company)
            {
                int monthsWithInterest = monthsPeriod - InitialPeriodWithoutInterestByCompanies;
                BallanceInEuro += monthsWithInterest * InterestRateMonthlyBased;
                return monthsWithInterest * InterestRateMonthlyBased;
            }
            else
            {
                return GlobalConstants.ZeroInterestAmount;
            }
        }
    }
}
