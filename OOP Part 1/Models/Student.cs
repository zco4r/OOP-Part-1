namespace OOP_Part_1.Models;

public class Student
{
    public int Gread { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    private string email { get; set; }
    int age { get; set; }

    public void Register(string Email)
    {
        this.email = Email;
        SendEmail();
    }

    public void SendEmail()
    {
        
    }
    
}