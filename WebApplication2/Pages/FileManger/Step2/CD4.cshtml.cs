using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewModels.FileManger;

namespace WebApplication2.Pages.FileManger.Step2
{
    public class CD4Model : PageModel
    {
        public CD4Model()
        {
            viewModel = new();
        }
        [BindProperty]
        public CD4ViewModel viewModel { get; set; }
        public void OnGet()
        {
            viewModel.DirectoryName = "Test";
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            return RedirectToPage("/Index");
        }
    }
}
