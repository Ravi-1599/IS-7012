using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace RAVIP1599.Models
{
    public class Industry
    {
        [DisplayName("Industry ID")]
        public int? ID { get; set; }

        [DisplayName("Industry Name")]
        [Required(ErrorMessage = "Industry name is required")]
        [StringLength(60)]
        [RegularExpression("^[A-Za-z]+$")]
        public string? Name { get; set; }

        [DisplayName("Number Of Companies")]
        [Range(0, 10000)]
        public int? NumberOfCompanies { get; set; }

        [DisplayName("Created Date")]
        [DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; }

        // Navigation properties
        public virtual List<Candidate> Candidates { get; set; } = new List<Candidate>();
        public virtual List<Company> Companies { get; set; } = new List<Company>();


    }
}
