using MascotaFeliz.app.dominio;
using System.Collections.Generic;
using System.Linq;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public class RepositorioPersona : iRepositorioPersona
    {
      bool valorRetorno=false;
        //Ingresar informacion 

        public bool IngresarPersona(Persona persona)
        { 
          //Abriendo y Liebrando Recursos
          using(AppData.EfAppContext contexto = new AppData.EfAppContext())
         { 
            //Variable de tipo anonima con var
            var RegistroPersona=contexto.Add(persona);
            contexto.SaveChanges();
            if(contexto.SaveChanges()>=1)
            {
                valorRetorno=true;
             }
            return valorRetorno;
         }
        }
            //Borrar Persona

        public bool BorrarPersona(int IdPersona)
        {
         using(AppData.EfAppContext contexto = new AppData.EfAppContext()) 
          {    
            var BusquedaPersona=(from p in contexto.persona where p.IdPersona==IdPersona select p);
            if (!(BusquedaPersona==null))
            {
             contexto.Remove(BusquedaPersona);
             contexto.SaveChanges();
             valorRetorno=true;

            }
            return valorRetorno;
          }   
         
        }
        
        ///<summary> 
        ///Actualizar Persona para, actualizar informacion de Persona segun sus datos 
        /// </summary>
        /// </param name="Persona"></param>
        /// <returns>bool</returns>
        
        public bool ActualizarPersona(Persona persona)
        {
            
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
                var BusquedaPersona= contexto.persona.SingleOrDefault(o=>o.IdPersona==persona.IdPersona);
                if(!(BusquedaPersona==null))
                { 
                    BusquedaPersona.Nombre=persona.Nombre;
                    BusquedaPersona.Telefono=persona.Telefono;
                    BusquedaPersona.Direccion=persona.Direccion;
                    valorRetorno=true;
                 }
                return valorRetorno;
             }

        }

        //Consultar Persona (lista)

        public IEnumerable<Persona> ConsultarPersona()
        {
            //Var Listas Persona
          
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
             {
               //return contexto.pripietario;
               //linq
               var ListaPersona=(from p in contexto.persona select p).ToList();
               return ListaPersona;


             }
         
        }
        //Consultar persona

        public Persona ConsultarPersona(int IdPropieario)
        { 
        
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
              var ListaPersona=(from p in contexto.persona where p.IdPersona==IdPersona select p).First();
              return ListaPersona;
              
             }
         }
    
    }
}