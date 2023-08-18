using System.ComponentModel.DataAnnotations;

namespace MvcBook.Models
{
    public class Category
    {
        public int Id { get; set; }    
        public int? Type { get; set; }
        public string? Description { get; set; }    
    }
}