using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplicationResume.Models
{
    public class Project
    {
        [Key]
        public int id { get; set; }

        [Required]
        [DisplayName("Title")]//Displays Name instead of name when validation is required
        public string title { get; set; }

        public double gpa { get; set; }

        [Required]
        [DisplayName("City")]//Displays Name instead of name when validation is required
        public string city { get; set; }

        [Required]
        [DisplayName("Diploma")]//Displays Name instead of name when validation is required
        public string diploma { get; set; }

        [Required]
        [DisplayName("Content")]//Displays Name instead of name when validation is required
        public string content { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
