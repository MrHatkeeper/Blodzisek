using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers;

public class MyController : Controller
{
    // GET
    private Posts _posts = new Posts();

    public IActionResult Home()
    {

        List<OnePost> data = _posts.ReadPosts();
        ViewData["posts"] = _posts;
        ViewData["data"] = data;
        return View();
    }

    [HttpPost]
    public Task<IActionResult> AddPost(string header, string body)
    {
        _posts.AddPost(header, body);
        return Task.FromResult<IActionResult>(RedirectToAction("Home"));
    }


    [HttpPost]
    public Task<IActionResult> Remove(int id)
    {
        _posts.RemovePost(id);
        return Task.FromResult<IActionResult>(RedirectToAction("Home"));
    }

    [HttpPost]
    public Task<IActionResult> Edit(int id, string header, string body)
    {
        _posts.EditPost(id, header, body);
        return Task.FromResult<IActionResult>(RedirectToAction("Home"));
    }

}