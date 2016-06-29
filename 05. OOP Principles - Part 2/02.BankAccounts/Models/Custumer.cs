namespace _02.BankAccounts.Models
{
    using Enumerations;
    using _02.BankAccounts.Interfaces;

    public class Custumer : ICustumer
    {
        //Constructors
        public Custumer(CustumerType custumerType, string custumerName)
        {
            this.CustumerName = custumerName;
            this.Type = custumerType;           
        }

        //Properties        
        public string CustumerName { get; private set; }

        public CustumerType Type { get; private set; }
    }
}
