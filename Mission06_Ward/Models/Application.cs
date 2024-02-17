using System.ComponentModel.DataAnnotations;

namespace Mission06_Ward.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director {  get; set; }
        [Required]
        public string Rating { get; set; }
        public bool? Edited {  get; set; }
        public string? LentTo {  get; set; }

        [StringLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string? Notes { get; set; }
    }
}
