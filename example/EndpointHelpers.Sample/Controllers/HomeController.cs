using System.Diagnostics;
using EndpointHelpers.Sample.Models;
using Microsoft.AspNetCore.Mvc;

namespace EndpointHelpers.Sample.Controllers;

[GenerateLinkGenerator]
[GenerateRedirectToAction]
[GenerateViewHelpers]
public partial class HomeController : Controller
{
    public IActionResult Index()
    {
        return IndexView();
    }
    
    public IActionResult Privacy()
    {
        return PrivacyView();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
