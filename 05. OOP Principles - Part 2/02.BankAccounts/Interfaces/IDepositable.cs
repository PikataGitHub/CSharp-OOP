namespace _02.BankAccounts.Interfaces
{
    using System;

    public interface IDepositable
    {
        //Methods
        decimal DepositMoney(decimal depositMoney);

        decimal CalculateInterestForDate(DateTime date);
    }
}
