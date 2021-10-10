using MascotaFeliz.app.dominio;
using System.Collections.Generic;
using System.Linq;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public class RepositorioTipoAnimal : iRepositorioTipoAnimal
    {
       bool valorRetorno=false;
        //Ingresar informacion 

        public bool IngresarTipoAnimal(TipoAnimal tipoAnimal)
        { 
          //Abriendo y Liebrando Recursos
          using(AppData.EfAppContext contexto = new AppData.EfAppContext())
         { 
            //Variable de tipoAnimal con var
            var RegistroTipoAnimal=contexto.Add(tipoAnimal);
            contexto.SaveChanges();
            if(contexto.SaveChanges()>=1)
            {
                valorRetorno=true;
             }
            return valorRetorno;
         }
        }
            //Borrar Medico

        public bool BorrarTipoAnimal(int IdTipoAnimal)
        {
         using(AppData.EfAppContext contexto = new AppData.EfAppContext()) 
          {    
            var BusquedaTipoAnimal=(from p in contexto.tipoAnimal where p.IdTipoAnimal==IdTipoAnimal select p);
            if (!(BusquedaTipoAnimal==null))
            {
             contexto.Remove(BusquedaTipoAnimal);
             contexto.SaveChanges();
             valorRetorno=true;

            }
            return valorRetorno;
          }   
         
        }
        
        ///<summary> 
        ///Actualizar TipoAnimal para, actualizar informacion de TipoAnimal segun sus datos 
        /// </summary>
        /// </param name="TipoAnimal"></param>
        /// <returns>bool</returns>
        
        public bool ActualizarTipoAnimal(TipoAnimal tipoAnimal)
        {
            
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
                var BusquedaTipoAnimal= contexto.tipoAnimal.SingleOrDefault(o=>o.IdTipoAnimal==tipoAnimal.IdTipoAnimal);
                if(!(BusquedaTipoAnimal==null))
                { 
                    BusquedaTipoAnimal.Nombre=tipoAnimal.Nombre;
                    valorRetorno=true;
                 }
                return valorRetorno;
             }

        }

        //Consultar TipoAnimal (lista)

        public IEnumerable<TipoAnimal> ConsultarTipoAnimal()
        {
            //Var Listas TipoAnimal
          
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
             {
               //return contexto.TipoAnimal;
               //linq
               var ListaTipoAnimal=(from p in contexto.tipoAnimal select p).ToList();
               return ListaTipoAnimal;


             }
         
        }
        //Consultar TipoAnimal

        public TipoAnimal ConsultarTipoAnimal(int IdTipoAnimal)
        { 
        
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
              var ListaTipoAnimal=(from p in contexto.tipoAnimal where p.IdTipoAnimal==IdTipoAnimal select p).First();
              return ListaTipoAnimal;
              
             }
         }
  
    }
}