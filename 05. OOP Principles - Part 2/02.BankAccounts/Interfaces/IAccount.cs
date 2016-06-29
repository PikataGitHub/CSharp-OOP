namespace _02.BankAccounts.Interfaces
{
    using System;

    public interface IAccount
    {
        //Properties
        DateTime StartAccountDate { get; set; }

        decimal BallanceInEuro { get; set; }

        decimal InterestRateMonthlyBased { get; set; }

        ICustumer Custumer { get; }
    }
}
