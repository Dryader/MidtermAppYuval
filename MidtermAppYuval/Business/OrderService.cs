using MidtermAppYuval.Models;

namespace MidtermAppYuval.Business;

public class OrderService
{
    List<Order> orders = new List<Order>();


    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    // public ReceiptModel CalculateReceipt(Order input)
    // {
    //     // var pricePerItem = GetBasePrice(input.PizzaType, input.PizzaSize);
    //     // var subtotal = pricePerItem * input.Quantity;
    //     //
    //     // var eligibleForDiscount = input.Quantity > 2;
    //     // var discountRate = eligibleForDiscount ? DiscountRate : 0m;
    //     // var discountAmount = RoundCurrency(subtotal * discountRate);
    //     //
    //     // var afterDiscount = subtotal - discountAmount;
    //     // var taxAmount = RoundCurrency(afterDiscount * TaxRateHst);
    //     // var total = RoundCurrency(afterDiscount + taxAmount);
    //
    //     public int Id { get; set; }
    //     public type type { get; set; }
    //     public  payment payment { get; set; }
    //     public string Color { get; set; }
    //     public int amount { get; set; } = 1;
    //     public bool tip { get; set; }
    //     public float Price { get; set; }
    //     public float Total { get; set; }
    //     return new ReceiptModel
    //     {
    //         type = input.CustomerName,
    // //             
    // //     };
    // }
    //
    //
    // public float GetCost(Order order)
    // {
    //     float subtotal = order.Price * order.amount;
    //     if (order.tip == true)
    //     {
    //         subtotal = (float)(subtotal * 1.05);
    //     }
    //
    //     return subtotal;
    // }
}