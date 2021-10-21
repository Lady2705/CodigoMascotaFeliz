using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
//using System.Threading.Task;


namespace MascotaFeliz.app.dominio
{
    [Table("SolicitudAtencionDb")]

    public class SolicitudAtencion
    {
      [Key]
      [Column("IdSolicitudAtencion")]
      public int IdSolicitudAtencion { get; set; }

       [Required]
       [Column("NombreSolicitud")]
       [StringLength(50,MinimumLength=5)]
       public string  NombreSolicitud{ get; set; }

       [Required]
       [Column("FechaSolicitud")]
       [StringLength(20,MinimumLength=5)]
       public string FechaSolicitud  { get; set; }
       [Required]
       [Column("DetalleSolicitud")]
       [StringLength(40,MinimumLength=5)]

       public string DetalleSolicitud { get; set; }

       [ForeignKey("IdMascota")]

        public virtual Mascota Mascota { get; set; }

       [ForeignKey("IdAnimal")]

        public virtual TipoAnimal TipoAnimal { get; set; }

        
    }
}