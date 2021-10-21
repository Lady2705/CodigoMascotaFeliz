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
      public int IdRegistroAtencion { get; set; }

       [Required]
       [Column("NombreRegistro")]
       [StringLength(50,MinimumLength=5)]
       public string NombreRegistro { get; set; }

      [Required]
       [Column("FechaRegistro")]
       [StringLength(20,MinimumLength=5)]
       public string FechaRegistro { get; set; }

       [Required]
       [Column("DescripcionRegistro")]
       [StringLength(50,MinimumLength=5)]
       public string DescripcionRegistro { get; set; }

       

       
       
       [ForeignKey("IdSolicitudAtencio")]

        public virtual SolicitudAtencion SolicitudAtencion { get; set; }


  
      
    }
}