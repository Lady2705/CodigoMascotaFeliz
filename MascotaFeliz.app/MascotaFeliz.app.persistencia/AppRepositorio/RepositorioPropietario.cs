using MascotaFeliz.app.dominio;
using System.Collections.Generic;
using System.Linq;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public class RepositorioPropietario : iRepositorioPropietario
    {
       bool valorRetorno=false;
        //Ingresar informacion 

        public bool IngresarPropietario(Propietario propietario)
        { 
          //Abriendo y Liebrando Recursos
          using(AppData.EfAppContext contexto = new AppData.EfAppContext())
         { 
            //Variable de tipo anonima con var
            var RegistroPropietario=contexto.Add(propietario);
            contexto.SaveChanges();
            if(contexto.SaveChanges()>=1)
            {
                valorRetorno=true;
             }
            return valorRetorno;
         }
        }
            //Borrar Propietario

        public bool BorrarPropietario(int IdPropietario)
        {
         using(AppData.EfAppContext contexto = new AppData.EfAppContext()) 
          {    
            var BusquedaPropietario=(from p in contexto.propietario where p.IdPropietario==IdPropietario select p);
            if (!(BusquedaPropietario==null))
            {
             contexto.Remove(BusquedaPropietario);
             contexto.SaveChanges();
             valorRetorno=true;

            }
            return valorRetorno;
          }   
         
        }
        
        ///<summary> 
        ///Actualizar Propietario para, actualizar informacion de Propietarios segun sus datos 
        /// </summary>
        /// </param name="Propietario"></param>
        /// <returns>bool</returns>
        
        public bool ActualizarPropietario(Propietario propietario)
        {
            
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
                var BusquedaPropietario= contexto.propietario.SingleOrDefault(o=>o.IdPropietario==propietario.IdPropietario);
                if(!(BusquedaPropietario==null))
                { 
                    BusquedaPropietario.Nombre=propietario.Nombre;
                    BusquedaPropietario.Telefono=propietario.Telefono;
                    BusquedaPropietario.Direccion=propietario.Direccion;
                    valorRetorno=true;
                 }
                return valorRetorno;
             }

        }

        //Consultar Propietario (lista)

        public IEnumerable<Propietario> ConsultarPropietario()
        {
            //Var Listas Propietario
          
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
             {
               //return contexto.pripietario;
               //linq
               var ListaPropietario=(from p in contexto.propietario select p).ToList();
               return ListaPropietario;


             }
         
        }
        //Consultar propietario

        public Propietario ConsultarPropietario(int IdPropieario)
        { 
        
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
              var ListaPropietario=(from p in contexto.propietario where p.IdPropietario==IdPropietario select p).First();
              return ListaPropietario;
              
             }
         }
  
    }
}