using System.ComponentModel.DataAnnotations;

namespace MvcBook.Models
{
    public class CategoryAndType
    {
        public int Id { get; set; }    
        public string? Type { get; set; }
        public string? Description { get; set; }    
    }
}