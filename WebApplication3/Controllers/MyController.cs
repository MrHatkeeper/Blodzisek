using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers;

public class MyController : Controller
{
    // GET

    public IActionResult Home()
    {
        Posts posts = new Posts();
        List<OnePost> data = posts.ManagePosts();
        ViewData["posts"] = data;
        return View(data);
    }
}