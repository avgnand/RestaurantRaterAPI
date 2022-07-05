using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantRaterAPI.Models
{
    public class Rating
    {
        [Key]
        public int Id {get; set;}

        [Required]
        [ForeignKeyAttribute("Restaurant")]
        public int RestaurantId {get; set;}

        [Required]
        public double FoodScore {get; set;}

        [Required]
        public double CleanlinessScore {get; set;}

        [Required]
        public double AtmosphereScore {get; set;}

        [Required]
        public double Score {get; set;}
    }
}