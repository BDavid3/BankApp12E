using Microsoft.Testing.Platform.Extensions.Messages;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BankApp12E
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int AccountBalance { get; set; }

        public Account(string accountNumber, string accountName, int accountBalance)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            AccountBalance = accountBalance;
        }
    }
}
