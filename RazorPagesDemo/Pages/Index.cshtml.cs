using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //bind property allows the page to get input from the url. DO not use this feature to pass sensitive data
        //[BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public void OnGet()
        {
            if(Id == 0)
            {
                Id = 6;
            }
        }
    }
}
