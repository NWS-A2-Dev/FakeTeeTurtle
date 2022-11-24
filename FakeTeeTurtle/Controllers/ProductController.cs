using FakeTeeTurtle.Models;
using FakeTeeTurtle.Services;
using Microsoft.AspNetCore.Mvc;

namespace FakeTeeTurtle.Controllers;

[Route("[Controller]")]
public class ProductController : Controller
{
    private readonly TShirtRepository TShirts;

    public ProductController(TShirtRepository repo)
    {
        TShirts = repo;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("page/{p}")]
    public IActionResult Page(int p)
    {
        return View(new PageModel
        {
            Page = p,
            TShirts = TShirts.GetPage(p)
        });
    }

    [HttpGet("{id}")]
    public IActionResult Product(Guid id)
    {
        return View(TShirts.Get(id));
    }
}