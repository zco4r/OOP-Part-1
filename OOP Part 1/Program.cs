namespace OOP_Part_1;

class Program
{
    static void Main()
    {

        Console.WriteLine("Select an account to view details:");
        Console.WriteLine("1. View Account Details");
        Console.WriteLine("2. Update Student Address");
        Console.WriteLine("3. Make a Deposit");
        Console.WriteLine("4. Withdraw");
        Console.WriteLine("5. View Product Details");
        Console.WriteLine("6. Exit");
        Console.Write("Enter option : ");
        
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                
                break;
            case "2":
                
                break;
            case "3" :
                break;
            
            default:
                Console.WriteLine("Invalid selection. Please restart and choose 1 or 2.");
                break;
        }
    }
}
