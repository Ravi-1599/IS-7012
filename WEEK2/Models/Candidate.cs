using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace RAVIP1599.Models

{
    public class Candidate
    {

        [DisplayName("Candidate ID")]
        public int? ID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "First Name cannot exceed 100 characters.")]
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First name is required")]
        [StringLength(60)]
        [RegularExpression("^[A-Za-z]+$")]
        public string? firstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(60)]
        [RegularExpression("^[A-Za-z]+$")]
        public string? lastName { get; set; }

        [DisplayName("Target Salary")]
        [Range(0, 200000.00)]
        public decimal? targetSalary { get; set; }

        [DisplayName("Optional Start Date")]
        [DataType(DataType.Date)]
        public DateTime? optStartDate { get; set; }

        [DisplayName("Contact Number")]
        [Required(ErrorMessage = "Contact number is required")]
        [StringLength(20)]
        public string? contactNumber { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100)]
        public string? address { get; set; }

        [DisplayName("Relocation")]
        public bool? relocation { get; set; }

        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime? dateOfBirth { get; set; }

        [DisplayName("Reference name")]
        [Required(ErrorMessage = "Reference name is required")]
        [StringLength(100)]
        public string? reference { get; set; }

        [DisplayName("Reference ID")]
        [StringLength(10)]
        public string? referenceID { get; set; }

        [DisplayName("Company ID")]
        [Range(1, 500)]
        public int? CompanyId { get; set; }

        [DisplayName("Job Title ID")]
        [Range(1, 100000)]
        public int JobTitleId { get; set; }

        [DisplayName("Industry ID")]
        [Range(1, 100)]
        public int IndustryId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual JobTitle? JobTitle { get; set; }
        public virtual Industry? Industry { get; set; }
    }
}
