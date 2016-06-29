namespace _02.BankAccounts.Models.Accounts
{
    using System;
    using _02.BankAccounts.Interfaces;
    using Interfaces.Constants;

    public class Deposit : Account, IDepositable, IWithdrawable
    {
        //Fields
        private const decimal InitialAmountWithoutInterestMin = 0;
        private const decimal InitialAmountWithoutInterestMax = 1000;

        //Constructors
        public Deposit(Custumer custumer, DateTime startDate, decimal startBallance, decimal interestRate) : base(custumer, startDate, startBallance, interestRate) { }

        //Methods
        public override decimal CalculateInterestForDate(DateTime date)
        {
            var monthsPeriod = (date.Month + date.Year * 12) - (StartAccountDate.Month + StartAccountDate.Year * 12);

            if (BallanceInEuro > InitialAmountWithoutInterestMin && BallanceInEuro < InitialAmountWithoutInterestMax)
            {
                return GlobalConstants.ZeroInterestAmount;
            }
            else
            {
                BallanceInEuro += monthsPeriod * InterestRateMonthlyBased;
                return monthsPeriod * InterestRateMonthlyBased;
            }            
        }

        public decimal WithdrawMoney(decimal withdrawMoney)
        {
            BallanceInEuro -= withdrawMoney;
            return BallanceInEuro;
        }
    }
}
