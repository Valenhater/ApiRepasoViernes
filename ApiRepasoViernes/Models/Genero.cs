﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiRepasoViernes.Models
{
    [Table("GENEROS")]
    public class Genero
    {
        [Key]
        [Column("IdGenero")]
        public int IdGenero { get; set; }
        [Column("Nombre")]
        public string Nombre { get; set; }
    }
}
