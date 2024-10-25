using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Models;

namespace Models.ViewModels
{
    public class JobApplicationVM
    {

        public JobApplication jobApplication { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> TagList { get; set; }

    }
}
