namespace OOP_Part_1.Models;

public class BankAccount
{
    public int AccountNumber { get; set; }
    public string HolderName { get; set; }
    public double Balance { get; set; }

    public void Deposit(double amount)
    {
        Balance += amount;
        SendEmail();
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            SendEmail();
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }

    public void CheckBalance()
    {
        PrintInformation();
        return;
    }

    private void PrintInformation()
    {
        Console.WriteLine($"Account number: {HolderName}");
    }

    private void SendEmail()
    {
        Console.WriteLine($"Sending email to {HolderName}");
    }
    
    
}