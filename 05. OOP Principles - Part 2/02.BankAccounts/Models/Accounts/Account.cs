namespace _02.BankAccounts.Models.Accounts
{
    using System;
    using _02.BankAccounts.Interfaces;
    using Interfaces.Constants;

    public abstract class Account : IAccount, IDepositable
    {
        //Fields
        private decimal interestRateMonthlyBased;

        //Constructors
        public Account(Custumer custumer, DateTime startDate, decimal startBallance, decimal interestRate)
        {
            this.Custumer = custumer;
            this.StartAccountDate = startDate;
            this.BallanceInEuro = startBallance;
            this.InterestRateMonthlyBased = interestRate;            
        }

        //Properties
        public decimal BallanceInEuro { get; set; }

        public ICustumer Custumer { get; set; }

        public decimal InterestRateMonthlyBased
        {
            get { return this.interestRateMonthlyBased; }
            set
            {
                if (value < GlobalConstants.ZeroInterestRate)
                {
                    throw new ArgumentOutOfRangeException("Interest rate must NOT be negative!");
                }
                this.interestRateMonthlyBased = value;
            }
        }

        public DateTime StartAccountDate { get; set; }

        //Methods
        public decimal DepositMoney(decimal depositMoney)
        {
            BallanceInEuro += depositMoney;
            return BallanceInEuro;
        }

        public abstract decimal CalculateInterestForDate(DateTime date);        
    }
}
