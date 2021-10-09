using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
//using System.Threading.Task;


namespace MascotaFeliz.app.dominio
{
    [Table("PropietarioDb")]
    public class Propietario
    {

        [Key]
        [Column("IdPropietario")]

        public int IdPropietario { get; set; }

        [Required]
        [Column("Nombre")]
        [StringLength(50,MinimumLength=5)]

        public string Nombre { get; set; }

        [Required]
        [Column("Telefono")]
        [StringLength(12,MinimumLength=5)]

        public string Telefono { get; set; }

        [Required]
        [Column("Direccion")]
        [StringLength(50,MinimumLength=5)]

        public string Direccion { get; set; }

        

    }
}