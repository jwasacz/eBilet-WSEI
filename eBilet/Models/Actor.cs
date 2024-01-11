using System.ComponentModel.DataAnnotations;

namespace eBilet.Models
{
    public class Actor
    {
        [Key]

        public int Id { get; set; }
        [Display(Name = "Profile picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "FullName")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relacje
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
