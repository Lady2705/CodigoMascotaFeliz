using MascotaFeliz.app.dominio;
using System.Collections.Generic;
using System.Linq;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public class RepositorioMascota : IRepositorioMascota
    {
       bool valorRetorno=false;
        //Ingresar informacion 

        public bool IngresarMascota(Mascota mascota)
        { 
          //Abriendo y Liebrando Recursos
          using(AppData.EfAppContext contexto = new AppData.EfAppContext())
         { 
            //Variable de tipo anonima con var
            var RegistroMascota=contexto.Add(mascota);
            contexto.SaveChanges();
            if(contexto.SaveChanges()>=1)
            {
                valorRetorno=true;
             }
            return valorRetorno;
         }
        }
            //Borrar Medico

        public bool BorrarMascota(int IdMascota)
        {
         using(AppData.EfAppContext contexto = new AppData.EfAppContext()) 
          {    
            var BusquedaMascota=(from p in contexto.mascota where p.IdMascota==IdMascota select p);
            if (!(BusquedaMascota==null))
            {
             contexto.Remove(BusquedaMascota);
             contexto.SaveChanges();
             valorRetorno=true;

            }
            return valorRetorno;
          }   
         
        }
        
        ///<summary> 
        ///Actualizar Mascota para, actualizar informacion de mascota segun sus datos 
        /// </summary>
        /// </param name="Mascota"></param>
        /// <returns>bool</returns>
        
        public bool ActualizarMascota(Mascota mascota)
        {
            
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
                var BusquedaMascota= contexto.mascota.SingleOrDefault(o=>o.IdMascota==medicos.IdMascota);
                if(!(BusquedaMascota==null))
                { 
                    BusquedaMascota.Nombre=mascota.Nombre;
                    BusquedaMascota.ColorOjos=mascota.ColorOjos;
                    BusquedaMascota.ColorPiel=mascota.ColorPiel;
                    BusquedaMascota.Estatura=mascota.Estatura;
                    BusquedaMascota.Peso=mascota.Peso;
                    BusquedaMascota.Peso=mascota.Peso;
                    BusquedaMascota.FrecuenciaCardiaca=mascota.FrecuenciaCardiaca;
                    BusquedaMascota.FrecuenciaCardiaca=mascota.FrecuenciaRespiratoria;
                    valorRetorno=true;
                 }
                return valorRetorno;
             }

        }

        //Consultar Mascota (lista)

        public IEnumerable<Mascota> ConsultarMascota()
        {
            //Var Listas Mascota
          
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
             {
               //return contexto.mascota;
               //linq
               var ListaMascota=(from p in contexto.mascota select p).ToList();
               return ListaMascota;


             }
         
        }
        //Consultar mascota

        public Mascota ConsultarMascota(int IdMascota)
        { 
        
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
              var ListaMascota=(from p in contexto.mascota where p.IdMascota==IdMascota select p).First();
              return ListaMascota;
              
             }
         }
  
    }
}