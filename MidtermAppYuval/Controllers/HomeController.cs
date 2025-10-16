using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MidtermAppYuval.Models;

namespace MidtermAppYuval.Controllers;

public class HomeController : Controller
{    
    private readonly List<Order> _orderService;

    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(new Order());
    }

    [HttpPost]
    public IActionResult Index(Order input)
    {
        if (!ModelState.IsValid) return View(input);

        var receipt = input.Price;
        return View("Reciept", receipt);
    }
    
    
    public IActionResult OrderHistory()
    {
        return View("OrderHistory");
    }
    [HttpPost]
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}