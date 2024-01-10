using System.ComponentModel.DataAnnotations;

namespace eBilet.Models
{
    public class Actor
    {
        [Key]

        public int Id { get; set; }
        [Display(Name = "Profile picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }

        //Relacje
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
