using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
//using System.Threading.Task;

namespace MascotaFeliz.app.dominio
{
    [Table("MedicosDb")]

    public class Medicos
    {
       [Column("IdMedico")]
       [Key]
       public int IdMedico { get; set; }

       [Required]
       [Column("Nombre")]
       [StringLength(50, MinimumLength=5)]

       public string Nombre { get; set; }
       
       [Required]
       [Column("TarjetaProfecional")]

       public int TarjetaProfecional { get; set; }
       
       [Required]
       [Column("Especialidad")]
       [StringLength(20, MinimumLength=5)]

       public string Especialidad { get; set; }   

       [ForeignKey("IdAnimal")]

       public virtual TipoAnimal TipoAnimal { get; set; }
       
        }
}