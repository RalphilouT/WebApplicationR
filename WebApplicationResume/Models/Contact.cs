using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationResume.Models
{
    public class Contact
    {
        [Key]
        public int id { get; set; }

        [Required]
        [DisplayName("Name of person")]//Displays Name instead of name when validation is required
        public string name { get; set; }

        [Required]
        [DisplayName("Email")]//Displays Name instead of name when validation is required
        public string email { get; set; }

        [Required]
        [DisplayName("Subject title")]//Displays Name instead of name when validation is required
        public string subject { get; set; }

        [Required]
        [DisplayName("Message")]//Displays Name instead of name when validation is required
        public string message { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
