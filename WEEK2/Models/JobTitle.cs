using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace RAVIP1599.Models
{
    public class JobTitle
    {
        [DisplayName("Job ID")]
        public int? ID { get; set; }

        [DisplayName("Job Title")]
        [Required(ErrorMessage = "Job title is required")]
        [StringLength(80)]
        public string? title { get; set; }

        [DisplayName("Minimum Salary")]
        [Range(0, 10000.00)]
        public decimal? minimumSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(0, 500000.00)]
        public decimal? maximumSalary { get; set; }

        [DisplayName("Optional Start Date")]
        [DataType(DataType.Date)]
        public DateTime? optionalStartDate { get; set; }

        [DisplayName("Job Description")]
        [StringLength(60)]
        public string? jobDescription { get; set; }

        [DisplayName("Level")]
        public string? level { get; set; }

        [DisplayName("Type Of Employee")]
        [Required(ErrorMessage = "Type of Employee is required")]
        public string? typeOfEmployee { get; set; }

        public virtual List<Candidate> Candidates { get; set; } = new List<Candidate>();
    }
}
