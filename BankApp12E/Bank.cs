namespace BankApp12E
{
    public class Bank
    {
        Dictionary<string, int> accounts = new Dictionary<string, int>();

        public void CreateAccount(string account)
        {
            accounts.Add(account, 0);
        }

        public int GetBalance(string account)
        {
            if (!accounts.ContainsKey(account))
            {
                throw new ArgumentException("Invalid account");
            }
            return accounts[account];
        }

        public void Deposit(string account, int amount)
        {
            if (!accounts.ContainsKey(account))
            {
                throw new ArgumentException("Invalid account");
            }
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount");
            }
            accounts[account] += amount;
        }

        public bool Withdraw(string account, int amount)
        {
            if (!accounts.ContainsKey(account))
            {
                throw new ArgumentException("Invalid account");
            }
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount");
            }
            if (accounts[account] < amount)
            {
                return false;
            }

            accounts[account] -= amount;
            return true;
        }
    }
}
