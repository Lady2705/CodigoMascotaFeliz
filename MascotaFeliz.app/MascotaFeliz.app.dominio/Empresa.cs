using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
//using System.Threading.Task;


namespace MascotaFeliz.app.dominio
{
    [Table("EmpresaDb")]

    public class Empresa
    {
       [Column("Nit")]
       [Key]
       public int Nit { get; set; }

       [Required]
       [Column("NombreEmpresa")]
       [StringLength(50, MinimumLength=5)]

       public string NombreEmpresa { get; set; }
       
       [Required]
       [Column("DireccionEmpresa")]
       [StringLength(50, MinimumLength=5)]

       public string DireccionEmpresa { get; set; }
       
       [Required]
       [Column("TelefonoEmpresa")]
       [StringLength(12, MinimumLength=5)]

       public string TelefonoEmpresa { get; set; }   

       
       
    }
        
    
 }