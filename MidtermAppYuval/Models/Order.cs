using System.ComponentModel.DataAnnotations;

namespace MidtermAppYuval.Models;

public enum payment
{
    Credit, Debit
}

public enum type
{
    Android, Iphone, Galaxy
}

public class Order
{
    
    public int Id { get; set; }

    public type type { get; set; }
    public  payment payment { get; set; }
    public string Color { get; set; }
    public int amount { get; set; } = 1;
    public bool tip { get; set; }
    public float Price { get; set; }
    public float Total { get; set; }
}