using System;
using Microsoft.EntityFrameworkCore;
using MascotaFeliz.app.dominio;

namespace MascotaFeliz.app.persistencia.AppData
{
    //Propiedad
    public class EfAppContext: DbContext
    {
        public DbSet<Persona> persona {get; set;}
        public DbSet<Medicos> medicos {get; set;}
        public DbSet<Propietario> propietario {get; set;}
        public DbSet<Empresa> empresa {get; set;}
        public DbSet<Mascota> mascota {get; set;}
        public DbSet<TipoAnimal> tipoAnimal {get; set;}
        public DbSet<RegistroAtencion> registroAtencion {get; set;}
        public DbSet<SolicitudAtencion> solicitudAtencion {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            //cadena de conexion
            if (!optionsBuilder.IsConfigured)
            {
              optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=MascotaFeliz;Integrated Security=True");
            }
        }
    }
}