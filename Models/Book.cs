using System.ComponentModel.DataAnnotations;

namespace MvcBook.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public int? Category { get; set; }
        public string? Author { get; set; }
    }
}