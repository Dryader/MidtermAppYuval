using MidtermAppYuval.Models;

namespace MidtermAppYuval.Business;

public class OrderService
{
    List<Order> orders = new List<Order>();


    public void AddOrder(Order order)
    {
        orders.Add(order);
    }


    public float GetCost(Order order)
    {
        float subtotal = order.Price * order.amount;
        if (order.tip == true)
        {
            subtotal = (float)(subtotal * 1.05);
        }

        return subtotal;
    }
}