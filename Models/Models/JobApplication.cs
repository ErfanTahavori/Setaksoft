using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{

    public class JobApplication
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title field must be completed!")]
        [MaxLength(50, ErrorMessage = "You cannot put more than 40 characters in the title field!")]
        public string Title { get; set; }
        [Required]
        public List<Tag> Tags { get; set; } = new List<Tag>();


        //holds id
        [NotMapped]
        public List<int> SelectedTags { get; set; } = new List<int>();
        //holds id


        public enum CooperationType
        {
            None = 0,
            FullTime = 1,
            PartTime = 2,
            Remote = 3
        }
        public enum CityEnum
        {
            None = 0,
            Tehran = 1,
            Mashhad = 2,
            Isfahan = 3,
            Shiraz = 4,
            Tabriz = 5
        }
        public enum SexEnum
        {
            None = 0,
            Male = 1,
            Female = 2
        }
        public enum MilitaryStatus
        {
            None = 0,
            Completed = 1,
            EducationalExemption = 2,
            Exemption = 3,
            NotCompleted = 4
        }
        public enum LastDegree
        {
            None = 0,
            AssociateDegree = 1,
            BachelorDegree = 2,
            MasterDegree = 3,
            DoctoralDegree = 4
        }

        [Required]
        [DisplayName("Cooperation Type")]
        public CooperationType Cooperation_Type { get; set; }
        [Required]
        [DisplayName("Last Degree")]
        public LastDegree Last_Degree { get; set; }

        [Required]
        public CityEnum City { get; set; }

        [Required]
        public SexEnum Sex { get; set; }
        [Required]
        [DisplayName("Military Status")]
        public MilitaryStatus Military_Status { get; set; }
        [DisplayName("Negotiated Salary")]
        public bool Negotiated_Salary { get; set; }
        [DisplayName("Starting Salary")]
        public double Start_Salary { get; set; }
        [DisplayName("Ending Salary")]
        public double End_Salary { get; set; }


        [Required(ErrorMessage = "Work Experience field must be completed!")]
        [Range(0, 100, ErrorMessage = "This work experience is not possible!")]
        [DisplayName("Work Experience (year)")]
        public double Work_Experience { get; set; }

        [Required(ErrorMessage = "Description field must be completed!")]
        [MaxLength(500, ErrorMessage = "You cannot put more than 500 characters in the description field!")]
        public string Description { get; set; }

        public bool IsAccepted { get; set; }
    }
}


