namespace EyeCareUI.Models
{
    public class BaseModel<T> where T : class
    {
        public T? Id { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public required string ClientIp { get; set; }
    }
}
