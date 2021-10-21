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
    public class Propietario:Persona
    {

        [Column("IdPropietario")]

        public int IdPropietario { get; set; }

        [ForeignKey("IdRegistroAtencion")]
       public virtual RegistroAtencion RegistroAtencion { get; set; }
        
        [ForeignKey("IdMascota")]
        public virtual Mascota Mascota { get; set; }

         public Propietario(int Id, string Nombre, string Apellido, string Direccion, string Telefono, int idPropietario):base(Id,  Nombre, Apellido, Direccion, Telefono)
        {
            this.IdPropietario = idPropietario;

        }

        

    }
}