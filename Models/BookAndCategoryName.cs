using System.ComponentModel.DataAnnotations;

namespace MvcBook.Models
{
    public class BookAndCategoryName
    {
        public int Id { get; set; }
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string? CategoryName { get; set; }
        public string? Author { get; set; }
    }
}