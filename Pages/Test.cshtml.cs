using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1Razor.Pages;

public class Test : PageModel
{
    public void OnGet()
    {
        
    } public void OnPostTest()
    {
        Console.WriteLine("OnPostTest");
    }
}