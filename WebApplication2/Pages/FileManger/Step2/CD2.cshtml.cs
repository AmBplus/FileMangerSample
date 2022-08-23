using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages.FileManger.Step2
{
    public class CD2Model : PageModel
    {
        public void OnGet()
        {
            DirectoryName = "Test";
        }
        [BindProperty]
        public string DirectoryName { get; set; }

        public void OnPost()
        {

        }
    }
}
