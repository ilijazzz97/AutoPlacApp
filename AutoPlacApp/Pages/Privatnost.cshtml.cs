using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoPlacApp.Pages
{
    public class PrivatnostModel : PageModel
    {
        private readonly ILogger<PrivatnostModel> _logger;

        public PrivatnostModel(ILogger<PrivatnostModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}