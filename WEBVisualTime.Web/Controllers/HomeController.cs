using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;
using System.Diagnostics;
using WEBVisualTime.Web.Models;

namespace WEBVisualTime.Web.Controllers;

public class HomeController : Controller
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        var reference = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        var error = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        if (error is not null)
            HttpContext.RequestServices.GetRequiredService<ILogger<HomeController>>()
                .LogError(error, "Unhandled request failure. Reference: {Reference}", reference);
        Response.StatusCode = 500;
        return View(new ErrorViewModel(reference));
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
