namespace OOP_Part_1.Models;

public class Product
{

    public string ProductName  { get; set; }
    public double Price  { get; set; }
    public int StockQuantity   { get; set; }
    
    
    public void Sell(int quantity)
    {
        if (StockQuantity >= quantity)
        {
            StockQuantity -= quantity;
        }
        else
        {
            Console.WriteLine("Sorry, the available stock quantity is insufficient.");
        }
        LogTransaction();
    }

    public void Restock(int quantity)
    {
        StockQuantity += quantity;
        LogTransaction();
    }

    public void GetInventoryValue()
    {
        
    }

    private void PrintDetails()
    {
        
    }

    private void LogTransaction()
    {
        
    }
}