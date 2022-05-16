using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetCRUD.Models
{
    [Table("Product")]
    public class Product
    {
        [Column("Id")]
        [Display(Name = "Código")] // nome que vai aparecer na tela
        public int Id { get; set; }

        [Column("Name")]
        [Display(Name = "Name")] // nome que vai aparecer na tela
        public string Name { get; set; }

        [Column("Quantity")]
        [Display(Name = "Quantity")] // nome que vai aparecer na tela
        public int Quantity { get; set; }

    }
}
