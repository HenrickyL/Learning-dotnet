using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Shop.Models
{
    [Table("Categoria")]
    public class Category
    {
        [Key]
        [Column("Cat_ID")]
        public int Id { get; set; }

        [Required(ErrorMessage ="[Category] campo obrigatório!")]
        [Column("Title")]
        [MaxLength(60,ErrorMessage ="[Category] out of Range 3 -60 characters!")]
        [MinLength(3,ErrorMessage ="[Category] out of Range 3 -60 characters!")]
        public string Title { get; set; }


    }
}