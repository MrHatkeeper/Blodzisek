using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers;

public class MyController : Controller
{
    // GET

    public IActionResult Home()
    {
        Posts posts = new Posts();
        List<OnePost> data = posts.ReadPosts();
        ViewData["posts"] = posts;
        ViewData["data"] = data;
        return View();
    }

    [HttpPost]
    public IActionResult AddPost(string header, string body)
    {
        ViewBag.
        return View();
    }
    
}