// See https://aka.ms/new-console-template for more information

/// <summary>
/// Represents a simple bank account with encapsulated balance.
/// </summary>
class BankAccount
{
    private decimal balance; // Encapsulated field

    /// <summary>
    /// Adds a valid amount to the account balance.
    /// </summary>
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
        else
        {
            Console.WriteLine($"Invalid deposit amount: {amount}");
        }
    }

    /// <summary>
    /// Returns the current account balance.
    /// </summary>
    public decimal GetBalance()
    {
        return balance;
    }
}
