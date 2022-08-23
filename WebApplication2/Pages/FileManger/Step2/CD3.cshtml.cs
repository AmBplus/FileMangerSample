using Microsoft.AspNetCore.Mvc.RazorPages;
using ViewModels.FileManger;

namespace WebApplication2.Pages.FileManger.Step2
{
    public class CD3Model : PageModel
    {
        public CD3Model()
        {
            viewModel = new();
        }
        [Microsoft.AspNetCore.Mvc.BindProperty]
        public CD3ViewModel viewModel { get; set; }
        public void OnGet()
        {
            viewModel.DirectoryName = "Test";
        }

        public void OnPost()
        {

        }

    }
}
