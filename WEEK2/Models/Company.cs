using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RAVIP1599.Models
{
    public class Company
    {
        [DisplayName("Company ID")]
        public int? ID { get; set; }

        [DisplayName("Company Name")]
        [Required(ErrorMessage = "Company name is required")]
        [StringLength(60)]
        public string? name { get; set; }

        [DisplayName("Company Position")]
        [Required(ErrorMessage = "Company position is required")]
        [StringLength(80)]
        public string? position { get; set; }

        [DisplayName("Minimum Salary")]
        [Range(0, 10000.00)]
        public decimal? minimumSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(0, 500000.00)]
        public decimal? maximumSalary { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? startDate { get; set; }

        [DisplayName("Company Location")]
        [Required(ErrorMessage = "Company Location is required")]
        public string? location { get; set; }

        [DisplayName("Number Of Employees")]
        [Range(0, 10000000)]
        public int? noOfEmployees { get; set; }

        [DisplayName("Company Revenue")]
        public string? revenue { get; set; }

        [DisplayName("ISIN")]
        [Required(ErrorMessage = "ISIN is required")]
        [StringLength(20)]
        public string? ISIN { get; set; }

        [Required(ErrorMessage = "Website is required")]
        [DisplayName("Website")]
        [StringLength(100)]
        public string? website { get; set; }

        [DisplayName("Key People")]
        public string? keyPeople { get; set; }

        [DisplayName("Industry ID")]
        public int IndustryId { get; set; }

        // Navigation properties
        public virtual Industry? Industry { get; set; }
        public virtual List<Candidate> Candidates { get; set; } = new List<Candidate>();
    }
}
