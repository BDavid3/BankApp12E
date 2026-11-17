using Microsoft.Testing.Platform.Extensions.Messages;
using System.Security.Cryptography;

namespace BankApp12E
{
    public class Bank
    {
        List<Account> accounts = new List<Account>();

        public void CreateAccount(string number, string name, int balance)
        {
            Account newAccount = new Account(number,name,balance);
            accounts.Add(newAccount);
        }

        public int GetBalance(string account)
        {
            foreach (var i in accounts)
            {
                if (i.AccountNumber == account)
                {
                    return i.AccountBalance;
                }
            }
            throw new ArgumentException("Invalid account");
        }

        public void Deposit(string account, int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount");
            }

            foreach (var i in accounts)
            {
                if (i.AccountNumber == account)
                {
                    i.AccountBalance += amount;
                    return;
                }
            }

            throw new ArgumentException("Invalid account");
        }

        public bool Withdraw(string account, int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount");
            }


            foreach (var i in accounts)
            {
                if (i.AccountNumber == account)
                {
                    if (i.AccountBalance < amount)
                    {
                        return false;
                    }

                    i.AccountBalance -= amount;
                    return true;
                }
            }
            throw new ArgumentException("Invalid account");
        }

        public bool Transfer(string fromAccount, string toAccount, int amount)
        {
            bool tempBoolfrom = false;
            bool tempBoolTo = false;

            foreach (var i in accounts)
            {
                if (i.AccountNumber == fromAccount)
                {
                    tempBoolfrom = true;    
                }
                if (i.AccountNumber == toAccount)
                {
                    tempBoolTo = true;
                }
            }
            if (!tempBoolfrom || !tempBoolTo)
            {
                throw new ArgumentException("Invalid account");
            }

            if (tempBoolfrom && tempBoolTo)
            {
                if (amount <= 0)
                    throw new ArgumentException("Invalid amount");
            }

            if (tempBoolfrom && tempBoolTo)
            {
                foreach (var i in accounts)
                {
                    if (i.AccountNumber == fromAccount)
                        if (i.AccountBalance < amount)
                            return false;
                }
            }

            if (tempBoolfrom && tempBoolTo)
            {
                foreach (var i in accounts)
                {
                    if (i.AccountNumber == fromAccount)
                        i.AccountBalance -= amount;
                }

                foreach (var i in accounts)
                {
                    if (i.AccountNumber == toAccount)
                        i.AccountBalance += amount;
                }

                return true;
            }

            return false;
         
        }

        public void CloseAccount(string account)
        {
            foreach (var i in accounts)
            {
                if (i.AccountNumber == account)
                    if (i.AccountBalance > 0)
                        throw new InvalidOperationException("Amount not zero");
            }

            foreach (var i in accounts)
            {
                if (i.AccountNumber == account)
                    accounts.Remove(i);
            }

            throw new ArgumentException("Invalid account");
        }
    }
}
