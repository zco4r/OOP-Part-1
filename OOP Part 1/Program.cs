namespace OOP_Part_1;
// class3
public class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int StockQuantity { get; set; }

    public void Sell(int quantity)
    {
        if (StockQuantity >= quantity)
        {
            StockQuantity -= quantity;
        }
        else
        {
            Console.WriteLine("Not enough stock to complete this sale.");
        }
        LogTransaction();
    }

    public void Restock(int quantity)
    {
        StockQuantity += quantity;
        LogTransaction();
    }

    public double GetInventoryValue()
    {
        PrintDetails();
        return Price * StockQuantity;
    }

    private void PrintDetails()
    {
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Stock Quantity: " + StockQuantity);
    }

    private void LogTransaction()
    {
        Console.WriteLine("The operation was successful.");
    }
}
// class2
public class Student
{
    public int Grade { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    private string email { get; set; }   
    int age { get; set; }                

    public static int TotalStudents;

    public static int GetTotalStudents()
    {
        return TotalStudents;
    }

    public Student()
    {
        TotalStudents++;
    }

    private string securityPin;
    public string SecurityPin
    {
        set { securityPin = value; }
    }

    public void Register(string Email)
    {
        email = Email;
        SendEmail();
    }

    public void SendEmail()
    {
        Console.WriteLine($"Sending email to {email}"); 
    }
    
}
// class1
public class BankAccount
{
    public int AccountNumber { get; set; }
    public string HolderName { get; set; }
    public double Balance { get; set; }

    public BankAccount() { }

    public BankAccount(int accountNumber, string holderName, double balance)
    {
        AccountNumber = accountNumber;
        HolderName = holderName;
        Balance = balance;
    }

    public bool IsOverdrawn
    {
        get { return Balance < 0; }
    }

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
        }
        SendEmail();
    }

    public double CheckBalance()
    {
        PrintInformation();
        return Balance;
       
    }

    private void PrintInformation()
    {
        Console.WriteLine("Name : " + HolderName);
        Console.WriteLine("Balance: " + Balance);
    }
    

    private void SendEmail()
    {
        Console.WriteLine("Sending email");
    }
}


public class Program
{
    static BankAccount account1 = new BankAccount { AccountNumber = 1163, HolderName = "Karim", Balance = 120 };
    static BankAccount account2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };

    static Student Student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
    static Student Student2 = new Student { Name = "Ahmed", Address = "Muscat", Grade = 70 };

    static Product Producut1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
    static Product Producut2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };




    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit == false)
        {

            Console.WriteLine("Select an account to view details:");
            Console.WriteLine("1. View Account Details");
            Console.WriteLine("2. Update Student Address");
            Console.WriteLine("3. Make a Deposit");
            Console.WriteLine("4. Withdraw");
            Console.WriteLine("5. View Product Details");
            Console.WriteLine("6. Register a Student");
            Console.WriteLine("7. Compare Two Account Balances");
            Console.WriteLine("8. Restock Product & Stock Level Check");
            Console.WriteLine("9. Transfer Between Accounts");
            Console.WriteLine("10. Update Student Grade (Validated)");
            Console.WriteLine("11. Student Report Card");
            Console.WriteLine("12. Account Health Status");
            Console.WriteLine("13. Bulk Sale With Revenue Calculation");
            Console.WriteLine("14. Scholarship Eligibility Check");
            Console.WriteLine("15. Full Balance Top-Up Flow");
            Console.WriteLine("16. Quick Account Opening [Parameterized Constructor]");
            Console.WriteLine("17. Total Students Counter [Static Fields & Methods]");
            Console.WriteLine("18. Overdrawn Account Check [Read-Only Property]");
            Console.WriteLine("19. Set Student Security PIN [Write-Only Property]");
            Console.WriteLine("20. Exit");
            Console.Write("Enter option : ");

            string choice;
            try
            {
                choice = (Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid selection. Please restart and choose 1 to 20.");
                continue;
            }

            switch (choice)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":
                    break;

                case "4":
                    break;

                case "5":
                    break;

                case "6":
                    break;

                case "7":
                    break;

                case "8":
                    break;

                case "9":
                    break;

                case "10":
                    break;

                case "11":
                    break;

                case "12":
                    break;

                case "13":
                    break;

                case "14":
                    break;

                case "15":
                    break;

                case "16":
                    break;

                case "17":
                    break;

                case "18":
                    break;

                case "19":
                    break;
                case "20":
                    exit = true;
                    Console.WriteLine("Good bye");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please restart and choose 1 or 2.");
                    break;
            }

            Console.WriteLine("press any key");
            Console.ReadKey();
            Console.Clear();
        }
    }
    
    static BankAccount ChooseAccount()
    {
        Console.Write("Choose account (1 or 2): ");
        string input = Console.ReadLine();
        if (input == "2")
        {
            return account2;
        }
        return account1;
    }

    static Student ChooseStudent()
    {
        Console.Write("Choose student (1 or 2): ");
        string input = Console.ReadLine();
        if (input == "2")
        {
            return Student2;
        }
        return Student1;
    }

    static Product ChooseProduct()
    {
        Console.Write("Choose product (1 or 2): ");
        string input = Console.ReadLine();
        if (input == "2")
        {
            return Producut2;
        }
        return Producut1;
    }
    
    static void ViewAccountDetails()
    {
        Console.Write("Choose account (1 or 2): ");
        int input = int.Parse(Console.ReadLine());

        if (input == 1)
        {
            double result = account1.CheckBalance();
            Console.WriteLine("returned balance" + result);
        }
        else if (input == 2)
        {
            double result = account2.CheckBalance();
            Console.WriteLine("returned balance" + result);
        }

        else
        {
            Console.WriteLine("Enter valid account number");

        }

            
        BankAccount choosen = ChooseAccount();
        choosen.CheckBalance();
    }
    
    static void UpdateStudentAddress()
    {
        Student student = ChooseStudent();

        Console.Write("Enter new address: ");
        string newAddress = Console.ReadLine();
        student.Address = newAddress;
        Console.WriteLine("Address updated to: " + student.Address);
    }
    
    static void MakeDeposit()
    {
        BankAccount account = ChooseAccount();
        Console.Write("Enter deposit amount: ");
        try
        {
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);
            Console.WriteLine(account.HolderName + "'s updated balance: " + account.Balance);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid amount entered.");
        }
    }
    
    static void MakeWithdrawal()
    {
        BankAccount account = ChooseAccount();
        Console.Write("Enter withdrawal amount: ");
        try
        {
            double amount = double.Parse(Console.ReadLine());
            account.Withdraw(amount);
            Console.WriteLine("Updated balance: " + account.Balance);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid amount entered.");
        }
    }
    
    static void ViewProductDetails()
    {
        Product product = ChooseProduct();
        double totalValue = product.GetInventoryValue();
        Console.WriteLine("Total inventory value: " + totalValue);
    }
    
    static void RegisterStudent()
    {
        Student student = ChooseStudent();
        Console.Write("Enter email: ");
        string email = Console.ReadLine();
        student.Register(email);
        Console.WriteLine(student.Name + " has been registered successfully.");
    }
    
    static void CompareAccountBalances()
    {
        if (account1.Balance > account2.Balance)
        {
            Console.WriteLine(account1.HolderName + " has a higher balance.");
        }
        else if (account2.Balance > account1.Balance)
        {
            Console.WriteLine(account2.HolderName + " has a higher balance.");
        }
        else
        {
            Console.WriteLine("Both accounts have equal balances.");
        }
    }
    
    static void RestockProduct()
    {
        Product product = ChooseProduct();
        Console.Write("Enter quantity to restock: ");
        try
        {
            int quantity = int.Parse(Console.ReadLine());
            product.Restock(quantity);

            if (product.StockQuantity < 10)
            {
                Console.WriteLine("Stock level: Low (" + product.StockQuantity + ")");
            }
            else if (product.StockQuantity < 50)
            {
                Console.WriteLine("Stock level: Moderate (" + product.StockQuantity + ")");
            }
            else
            {
                Console.WriteLine("Stock level: Well Stocked (" + product.StockQuantity + ")");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid quantity entered.");
        }
    }
    static void TransferBetweenAccounts()
    {
        Console.WriteLine("Choose SOURCE account:");
        BankAccount source = ChooseAccount();
        Console.WriteLine("Choose DESTINATION account:");
        BankAccount destination = ChooseAccount();

        Console.Write("Enter transfer amount: ");
        try
        {
            double amount = double.Parse(Console.ReadLine());

            if (source.Balance >= amount)
            {
                source.Withdraw(amount);
                destination.Deposit(amount);
                Console.WriteLine("Transfer successful.");
                Console.WriteLine(source.HolderName + "'s new balance: " + source.Balance);
                Console.WriteLine(destination.HolderName + "'s new balance: " + destination.Balance);
            }
            else
            {
                Console.WriteLine("Transfer failed: insufficient balance in source account.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid amount entered.");
        }
    }
    
    static void UpdateStudentGrade()
    {
        Student student = ChooseStudent();
        Console.Write("Enter new grade: ");

        int newGrade;
        try
        {
            newGrade = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input: grade must be a number. No change made.");
            return;
        }

        if (newGrade < 0 || newGrade > 100)
        {
            Console.WriteLine("Invalid grade: must be between 0 and 100. No change made.");
            return;
        }

        student.Grade = newGrade;
        Console.WriteLine("Grade updated to: " + student.Grade);
    }
    
    static void StudentReportCard()
    {
        Student student = ChooseStudent();
        string status = student.Grade >= 60 ? "Pass" : "Fail";

        Console.WriteLine("----- Report Card -----");
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Address: " + student.Address);
        Console.WriteLine("Grade: " + student.Grade);
        Console.WriteLine("Status: " + status);
    }
    
    static void AccountHealthStatus()
    {
        BankAccount account = ChooseAccount();
        string status;

        if (account.Balance < 50)
        {
            status = "Low Balance";
        }
        else if (account.Balance <= 1000)
        {
            status = "Healthy";
        }
        else
        {
            status = "Premium";
        }

        Console.WriteLine("Account status: " + status);
    }
    
    static void BulkSaleWithRevenue()
    {
        Product product = ChooseProduct();
        Console.Write("Enter quantity to sell: ");

        try
        {
            int quantity = int.Parse(Console.ReadLine());

            if (product.StockQuantity < quantity)
            {
                int shortfall = quantity - product.StockQuantity;
                Console.WriteLine("Not enough stock. You need " + shortfall + " more unit(s) to fulfill this order.");
            }
            else
            {
                double revenue = quantity * product.Price;
                product.Sell(quantity);
                Console.WriteLine("Sale completed. Revenue: " + revenue);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid quantity entered.");
        }
    }
    
    static void ScholarshipEligibilityCheck()
    {
        Student student = ChooseStudent();
        BankAccount account = ChooseAccount();

        bool gradeOk = student.Grade >= 80;
        bool balanceOk = account.Balance >= 100;

        if (gradeOk && balanceOk)
        {
            Console.WriteLine("Eligible for Scholarship Bonus.");
        }
        else if (!gradeOk && !balanceOk)
        {
            Console.WriteLine("Not eligible: grade is below 80 AND balance is below 100.");
        }
        else if (!gradeOk)
        {
            Console.WriteLine("Not eligible: grade is below 80.");
        }
        else
        {
            Console.WriteLine("Not eligible: balance is below 100.");
        }
    }
    
    static void FullBalanceTopUpFlow()
    {
        BankAccount account = ChooseAccount();

        if (account.Balance < 50)
        {
            double before = account.Balance;
            double topUp = 100 - account.Balance;
            account.Deposit(topUp);
            Console.WriteLine("Balance before top-up: " + before);
            Console.WriteLine("Balance after top-up: " + account.Balance);
        }
        else
        {
            Console.WriteLine("No top-up needed - balance is already 50 or above.");
        }
    }
    
    static void QuickAccountOpening()
    {
        Console.Write("Enter new account number: ");
        int accountNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter holder name: ");
        string holderName = Console.ReadLine();
        Console.Write("Enter starting balance: ");
        double balance = double.Parse(Console.ReadLine());

        BankAccount newAccount = new BankAccount(accountNumber, holderName, balance);

        Console.WriteLine("New account created:");
        Console.WriteLine("Account Number: " + newAccount.AccountNumber);
        Console.WriteLine("Holder Name: " + newAccount.HolderName);
        Console.WriteLine("Balance: " + newAccount.Balance);
    }
    
    static void TotalStudentsCounter()
    {
        int total = Student.GetTotalStudents();
        Console.WriteLine("Total students registered in the system: " + total);
    }

    static void OverdrawnAccountCheck()
    {
        BankAccount account = ChooseAccount();
        if (account.IsOverdrawn)
        {
            Console.WriteLine("This account is overdrawn.");
        }
        else
        {
            Console.WriteLine("This account is not overdrawn.");
        }
    }


    
}