using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "please Enter The name of Tag")]
        public string Name { get; set; }
        //One-to-many
        public ICollection<JobApplication> JobApplications { get; set; }
    }
}
