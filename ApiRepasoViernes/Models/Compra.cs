using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiRepasoViernes.Models
{
    [Table("COMPRAS")]
    public class Compra
    {
        [Key]
        [Column("IdCompra")]
        public int IdCompra { get; set; }
        [Column("FechaCompra")]
        public DateTime FechaCompra { get; set; }
        [Column("IdPelicula")]
        public int IdPelicula { get; set; }
        [Column("IdUsuario")]
        public int IdUsuario { get; set; }
        [Column("Cantidad")]
        public int Cantidad { get; set; }

    }
}
