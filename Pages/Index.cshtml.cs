using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace project_website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string Search { get; set; } = null!;
        [BindProperty]
        public string Region { get; set; } = null!;
        public List<SelectListItem> Options { get; set; } = null!;

        public void OnGet()
        {
            Options = new List<SelectListItem>
            {
                new SelectListItem { Text = "EUNE", Value = "eun1", Selected = true },
                new SelectListItem { Text = "EUW", Value = "euw1" },
                new SelectListItem { Text = "NA", Value = "na1" },
            };
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("Profile", new { region = Region, account = Search });
        }
    }
}
