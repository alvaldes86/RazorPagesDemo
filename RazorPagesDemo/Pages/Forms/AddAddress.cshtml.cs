using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Models;

namespace RazorPagesDemo.Pages.Forms
{
    public class AddAddressModel : PageModel
    {
        [BindProperty]
        public AddressModel Address { get; set; }
        
        public void OnGet()
        {
        }

        //capture the info from the form
        public IActionResult OnPost()
        {

        }
    }
}
