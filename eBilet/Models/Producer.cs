using System.ComponentModel.DataAnnotations;

namespace eBilet.Models
{
    public class Producer
    {
        [Key]

        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }

        //Relacje
        public List<Movie> Movies { get; set; }
    }
}
