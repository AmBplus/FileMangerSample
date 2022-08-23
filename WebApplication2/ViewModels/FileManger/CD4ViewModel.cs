using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.FileManger;

public class CD4ViewModel : object
{
    public CD4ViewModel() : base()
    {
        
    }
    [Required]
    [StringLength( maximumLength:20,MinimumLength = 2,ErrorMessage = "{0} Len Must min {2} and max {1}")]
    [DisplayName("Directory Name")]
    public string DirectoryName { get; set; }
}