using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EyeCareUI.Models
{
    public abstract class BaseModel<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required virtual T Id { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public required string ClientIp { get; set; }
    }
}
