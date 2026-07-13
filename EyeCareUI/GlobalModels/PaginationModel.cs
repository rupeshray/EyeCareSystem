using System.ComponentModel.DataAnnotations;

namespace EyeCareUI.GlobalModels
{
    public class PaginationModel
    {
        public static readonly IReadOnlyCollection<int> PageSizeList = new List<int> { 10, 15, 20, 30, 50, 100, 150, 200, 300, 400 }.AsReadOnly();

        [Range(1, int.MaxValue)]
        public int Page { get; set; } = 1;

        [Range(10, 400)]
        public int PageSize { get; set; } = 10;

    }
}
