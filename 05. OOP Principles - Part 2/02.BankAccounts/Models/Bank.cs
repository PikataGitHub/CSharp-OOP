namespace _02.BankAccounts.Models
{
    using Accounts;
    using System.Collections.Generic;

    public class Bank
    {
        //Contructors
        public Bank()
        {
            this.BankAccounts = new List<Account>();
        }

        public Bank(List<Account> bankAccounts) : base()
        {            
        }

        //Properties
        public List<Account> BankAccounts { get; set; }
    }
}
