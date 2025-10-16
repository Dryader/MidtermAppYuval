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

    [Required(ErrorMessage = "Customer name is required")]
    [Display(Name = "Customer Name")]
    public int Id { get; set; }

    public type type { get; set; }
    public  payment payment { get; set; }
    public string Colorr { get; set; }
    public int amount { get; set; } = 1;
    public bool tip { get; set; }
    public float Price { get; set; }
    public float Total { get; set; }
}