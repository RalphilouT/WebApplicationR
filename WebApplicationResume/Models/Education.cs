using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationResume.Models
{
    public class Education
    {
        [Key]
        public int id { get; set; }

        [Required]
        [DisplayName("School")]//Displays Name instead of name when validation is required
        public string title { get; set; }

        [Required]
        [DisplayName("School website")]//Displays Name instead of name when validation is required
        public string website { get; set; }

        [Required]
        [DisplayName("GPA")]//Displays Name instead of name when validation is required
        public string gpa { get; set; }

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
