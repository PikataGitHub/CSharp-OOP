namespace _02.BankAccounts
{
    using _02.BankAccounts.Models;
    using Enumerations;
    using Models.Accounts;
    using System;

    public class BankAccountsMain
    {
        static void Main()
        {
            var alphaBank = new Bank();
            var telerikCompany = new Custumer(CustumerType.Company, "Telerik Progress Company");
            var telerikDeposit = new Deposit(telerikCompany, DateTime.Parse("05/10/2010"), 10000m, 10m);

            //Add one deposit account in bank
            alphaBank.BankAccounts.Add(telerikDeposit);

            Console.WriteLine("Test Adding account in Bank! Count= " + alphaBank.BankAccounts.Count);

            //Add two more acounts in bank - 1x Loan and 1x Mortgage
            alphaBank.BankAccounts.Add(new Loan(new Custumer(CustumerType.Company, "Telerik Progress Company"), DateTime.Parse("20/06/2012"), 5000m, 20m));
            alphaBank.BankAccounts.Add(new Mortgage(new Custumer(CustumerType.Company, "Telerik Progress Company"), DateTime.Parse("30/06/2014"), 20000m, 15m));

            // Test - Print Initial ballance of all accounts
            foreach (var account in alphaBank.BankAccounts)
            {
                Console.WriteLine(String.Format("\nInitial Ballance in {0} account is {1} EUR!", account.GetType(), account.BallanceInEuro));
            }            

            //Add three more acounts in bank - CustumerType = Individual - 1x Deposit, 1x Loan and 1x Mortgage
            alphaBank.BankAccounts.Add(new Deposit(new Custumer(CustumerType.Individual, "Ivan Ivanov"), DateTime.Parse("10/06/2000"), 1000m, 20m));
            alphaBank.BankAccounts.Add(new Loan(new Custumer(CustumerType.Individual, "Petar Petrov"), DateTime.Parse("15/01/2002"), 500m, 20m));
            alphaBank.BankAccounts.Add(new Mortgage(new Custumer(CustumerType.Individual, "Dimitar Dimitrov"), DateTime.Parse("01/02/2008"), 20000m, 8m));

            //Calculating Interest Rate Up To NOW for All Accounts
            Console.WriteLine("\n\nCalculating Interest Rate Up To NOW for All Accounts:");
            foreach (var account in alphaBank.BankAccounts)
            {
                Console.WriteLine("\nAccount Type: " + account.GetType());      
                Console.WriteLine(String.Format("Interest Rate for {0} account since {1:dd/MM/yyyy} to {2:dd/MM/yyyy} is {3:F2} EUR!", account.Custumer.CustumerName, account.StartAccountDate.Date, DateTime.Now.Date, account.CalculateInterestForDate(DateTime.Now)));

                Console.WriteLine(String.Format("Ballance for {0} account since {1:dd/MM/yyyy} to {2:dd/MM/yyyy} is {3:F2} EUR!", account.Custumer.CustumerName, account.StartAccountDate.Date, DateTime.Now.Date, account.BallanceInEuro));
            }
            Console.WriteLine();            
        }
    }
}
