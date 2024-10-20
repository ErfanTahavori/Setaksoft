using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "please Enter The name of Tag")]
        public string Name { get; set; }
        //many-to-many
        public ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>();
    }
}
