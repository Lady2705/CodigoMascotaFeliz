using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
//using System.Threading.Task;

namespace MascotaFeliz.app.dominio
{
    [Table("RegistroAtencionDb")]
    public class RegistroAtencion
    {    
      [Key]
      [Column("IdRegistroAtencion")]
      public int IdAnimal { get; set; }

       [Required]
       [Column("Nombre")]
       [StringLength(50,MinimumLength=5)]

      [Required]
       [Column("Fecha")]
       [StringLength(20,MinimumLength=5)]

       [Required]
       [Column("Descripcion")]
       [StringLength(50,MinimumLength=5)]

       public string Nombre { get; set; }

       [ForeignKey("IdPropietario")]

       public virtual Propietario Propietario { get; set; }



  
      
    }
}