using Microsoft.AspNetCore.Mvc;

namespace TestTimeConsumingOperationWebAPI.Controllers;

public class TestLongOperationController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}