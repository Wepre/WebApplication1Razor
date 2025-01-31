using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1Razor.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Console.WriteLine("ss");
         
    }

    public void OnPostTest()
    {
        Console.WriteLine("TestFinnian");
         
    }
    // public async Task<IActionResult> OnPostAsync()
    // {
    //     Console.WriteLine("OnPostAsync");
    //     return RedirectToPage("/Index");
    // }

    
}