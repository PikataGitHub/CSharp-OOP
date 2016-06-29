namespace _02.BankAccounts.Interfaces
{
    using Enumerations;

    public interface ICustumer
    {
        //Properties
        string CustumerName { get; }

        CustumerType Type { get; }
    }
}
