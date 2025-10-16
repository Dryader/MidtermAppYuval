namespace MidtermAppYuval.Models;

public class Order
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }
    public int amount { get; set; }
    public string payment { get; set; }
    public float tip { get; set; }
    public float Price { get; set; }
}