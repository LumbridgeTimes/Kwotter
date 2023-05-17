using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServerlessFollowerCounter.Pages
{
    public class IndexModel : PageModel
    {
public int Counter { get; set; }

        public void OnGet()
        {
            Counter = 0;
        }

        public IActionResult OnPost()
        {
            Counter++;
            return Page();
        }
    }
}