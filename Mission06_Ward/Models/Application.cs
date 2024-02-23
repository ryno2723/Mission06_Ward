using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Ward.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Sorry, you must enter a title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Sorry, you must enter a year")]
        [Range(1888, int.MaxValue, ErrorMessage = "Sorry, you must enter a valid year")]
        public int Year { get; set; }
        public string? Director {  get; set; }
        public string? Rating { get; set; }
        [Required]
        public bool Edited {  get; set; }
        public string? LentTo {  get; set; }
        [Required]
        public bool CopiedToPlex { get; set; }

        [StringLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string? Notes { get; set; }
    }
}
