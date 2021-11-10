using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="[Product] campo obrigatório!")]
        [MaxLength(60,ErrorMessage ="[Product] out of Range 3-60 characters!")]
        [MinLength(3,ErrorMessage ="[Product] out of Range 3-60 characters!")]
        public string Title { get; set; }

        [MaxLength(1024,ErrorMessage ="[Product] out range 0-1024 characters")]
        public string Description { get; set; }
        
        [Required(ErrorMessage ="[Product] campo obrigatório!")]
        [Range(1,int.MaxValue, ErrorMessage ="[Product] Price greater than 0!")]
        public decimal Price { get; set; }

        [Required(ErrorMessage ="[Product] campo obrigatório!")]
        [Range(1,int.MaxValue, ErrorMessage ="[Product] Invalid categoryId!")]
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}