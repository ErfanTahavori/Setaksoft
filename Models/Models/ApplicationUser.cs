using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string? Name { get; set; }
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        [ValidateNever]
        public Company Company { get; set; }

    }
}
