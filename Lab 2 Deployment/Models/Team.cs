using System.ComponentModel.DataAnnotations;

namespace Lab_1_Teams_with_Membership_System.Models
{
    public class Team
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Established Date")]
        [DataType(DataType.Date)]
        public DateTimeOffset? EstablishedDate { get; set; }
    }
}
