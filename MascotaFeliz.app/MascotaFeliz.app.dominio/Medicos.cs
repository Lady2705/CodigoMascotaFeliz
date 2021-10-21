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

    public class Medicos : Persona
    {
        [Column("IdMedico")]
        public int IdMedico { get; set; }

        [Required]
        [Column("TarjetaProfecional")]

        public int TarjetaProfecional { get; set; }

        [Required]
        [Column("Especialidad")]
        [StringLength(20, MinimumLength = 5)]

        public string Especialidad { get; set; }

        [ForeignKey("IdAnimal")]

        public virtual TipoAnimal TipoAnimal { get; set; }

        [ForeignKey("Nit")]

        public virtual Empresa Empresa { get; set; }

        
        public Medicos(int Id, string Nombre, string Apellido, string Direccion, string Telefono, int idMedico, int tarjetaProfecional, string especialidad) : base(Id, Nombre, Apellido, Direccion, Telefono)
        {
            this.IdMedico = idMedico;
            this.TarjetaProfecional = tarjetaProfecional;
            this.Especialidad = especialidad;



        }


    }
}