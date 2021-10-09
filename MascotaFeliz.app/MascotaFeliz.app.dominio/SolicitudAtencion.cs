using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
//using System.Threading.Task;


namespace MascotaFeliz.app.dominio
{
    [Table("SolicitudAtencion")]

    public class SolicitudAtencion
    {
      [Key]
      [Column("IdSolicitudAtencion")]
      public int Id { get; set; }

       [Required]
       [Column("NombreMascota")]
       [StringLength(50,MinimumLength=5)]

       [Required]
       [Column("Fecha")]
       [StringLength(20,MinimumLength=5)]

       [Required]
       [Column("Descripcion")]
       [StringLength(50,MinimumLength=5)]

       public string NombreMascota { get; set; }

        
    }
}