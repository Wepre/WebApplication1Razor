using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1Razor.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Console.WriteLine("get");
    }

    public IActionResult OnPost()
    {
        Console.WriteLine("post");
        return RedirectToPage("Error");
    }

    public IActionResult OnPostLogin()
    {
        Console.WriteLine("这是新学的login");
        return RedirectToPage("Register");
    }
    public void OnPostTest()
    {
        Console.WriteLine("TestTestTestTest");
    }
}