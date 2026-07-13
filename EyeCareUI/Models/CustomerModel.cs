using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EyeCareUI.Models
{
    [Table("Customer")]
    public class CustomerModel : BaseModel<long>
    {
        [Required]
        [Display(Name = "Company")]
        public int IdCompany { get; set; }


        [Display(Name = "Branch")]
        public int? IdBranch { get; set; }


        [Display(Name = "Department")]
        public int? IdDepartment { get; set; }

        [Required]
        [Display(Name = "Patient ID")]
        public string CustomerId { get; set; } = null!;

        [Required]
        [Display(Name = "Patient Name")]
        public string CustomerName { get; set; } = null!;

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; } = null!;

        [Display(Name = "Email")]
        public string? Email { get; set; }


        [Required]
        [Display(Name = "Mobile")]
        public string Mobile { get; set; } = null!;

        [Required]
        [Display(Name = "Age")]
        public int CustomerAge { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string? CustomerAddress { get; set; }

        [Required]
        [Display(Name = "Follow UP Count")]
        public int FollowupCount { get; set; }

    }
}
