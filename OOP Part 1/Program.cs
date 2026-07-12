namespace OOP_Part_1;

//Case 1 - View Account Details
public class BankAccount
{
    public string AccountHolder { get; set; }
    public decimal Balance { get; set; }

    public void CheckBalance()
    {
        Console.WriteLine($"\n--- Account Details ---");
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Current Balance: ${Balance:F2}");
        Console.WriteLine($"-----------------------\n");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount { AccountHolder = "John Doe", Balance = 5000.00m };
        BankAccount account2 = new BankAccount { AccountHolder = "Jane Smith", Balance = 7500.50m };

        Console.WriteLine("Select an account to view details:");
        Console.WriteLine("1. John Doe");
        Console.WriteLine("2. Jane Smith");
        Console.Write("Enter choice (1 or 2): ");
        
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                account1.CheckBalance();
                break;
            case "2":
                account2.CheckBalance();
                break;
            default:
                Console.WriteLine("Invalid selection. Please restart and choose 1 or 2.");
                break;
        }
    }
}