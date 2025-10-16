using MidtermAppYuval.Models;

namespace MidtermAppYuval.Business;

public class OrderService
{
    List<Order> orders = new List<Order>();


    public void AddOrder(Order order)
    {
        orders.Add(order);
    }


    public void GetCost(Order orders)
    {
        float totalcost = 0;
        foreach (Order i in orders)
        {
            totalcost = i.amount * i.Price * i.tip;
        }

        orders.Add(totalcost);
    }
}