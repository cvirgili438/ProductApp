using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarlosAPP.Models
{
    public class Product
    {
       
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nombre")]
        public string? Name { get; set; }
        [Required]
        [DisplayName("Descripcion")]
        public string? Description { get; set; }
        [Required]
        [DisplayName("Precio en USD")]
        public decimal PriceUSD { get; set; }
        [Required]
        [DisplayName("Imagen")]
        [Url]
        public string? ImageURL { get; set; }


    }

}
