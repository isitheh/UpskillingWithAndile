// 5. Encapsulation
// Definition: Encapsulation is bundling data and methods together, while restricting direct access to some components (using private, public, etc.).
public class BankAccount
{
    private decimal balance;  // hidden from outside

    public void Deposit(decimal amount)
    {
        if (amount > 0) balance += amount;
    }

    public decimal GetBalance() => balance; // controlled access
}

BankAccount acc = new BankAccount();
acc.Deposit(100);
Console.WriteLine(acc.GetBalance());  // 100
