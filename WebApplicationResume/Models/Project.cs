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


        [Required]
        [DisplayName("Content")]//Displays Name instead of name when validation is required
        public string content { get; set; }

        [Required]
        [DisplayName("Source")]//Displays Name instead of name when validation is required
        public string source { get; set; }

        

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
