using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
//using System.Threading.Task;


namespace MascotaFeliz.app.dominio
{
    [Table("TipoAnimal")] 
    public class TipoAnimal
    {
      [Key]
      [Column("IdTipoAnimal")]
      public int IdAnimal { get; set; }

      [Column("Nombre")]
      [Required]
      public string Nombre { get; set; }


    }
}