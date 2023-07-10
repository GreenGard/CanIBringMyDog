using System.ComponentModel.DataAnnotations;

namespace CanIBringMyDog.Models
{
    public class DogFriendlyPlace
    {
        [Key]//Annotering, primary key 
        public int Id { get; set; }

        [Required]//får inte var null men måste vara med
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty;
    }
}