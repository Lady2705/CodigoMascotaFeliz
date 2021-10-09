using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
//using System.Threading.Task;


namespace MascotaFeliz.app.dominio
{
    [Table("MascotaDb")]

    public class Mascota
    {
       [Column("IdMascota")]
       [Key]
       public int IdMascota { get; set; }

       
       [Column("Nombre")]
       [Required]
       [StringLength(50,MinimumLength=5)]

       public string Nombre { get; set; }
       
       
       [Column("ColorOjos")]
       [Required]
       [StringLength(20,MinimumLength=5)]
       
       public string ColorOjos { get; set; }

       
       [Column("ColorPiel")]
       [Required]
       [StringLength(20,MinimumLength=5)]
       
       public string ColorPiel { get; set; }
       
       
       [Column("Estatura")]
       [Required]

       public int Estatura { get; set;}

       
       [Column("Peso")]
       [Required]
       public int Peso { get; set;}

       
       [Column("FrecuenciaCardiaca")]
       [Required]
       public int FrecuenciaCardiaca { get; set;} 

       
       [Column("FrecuenciaRespiratoria")]
       [Required]
       public int FrecuenciaRespiratoria { get; set;}  

       [ForeignKey("IdPropietario")]

       public virtual Propietario Propietario { get; set; } 
       
    

    }
}