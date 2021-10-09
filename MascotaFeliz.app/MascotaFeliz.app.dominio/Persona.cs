using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
//using System.Threading.Task;


namespace MascotaFeliz.app.dominio
{
    [Table("PersonaDb")]  

    public class Persona
    {
        [Column("IdPersona")]
        [Key]
        public int Id { get; set; }

        
        [Required]
        [Column("Nombre")]
        [StringLength(50, MinimumLength=5)]
        public string Nombre { get; set; }

         [Required]
        [Column("Apellido")]
        [StringLength(50, MinimumLength=5)]
        public string Apellido { get; set; }

         [Required]
        [Column("Telefono")]
        [StringLength(20, MinimumLength=5)]
        public string Telefono { get; set; }
    }
}