using System.ComponentModel.DataAnnotations;

namespace Mission06_Ward.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
