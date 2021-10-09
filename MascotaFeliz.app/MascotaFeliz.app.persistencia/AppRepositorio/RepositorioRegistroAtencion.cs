using MascotaFeliz.app.dominio;
using System.Collections.Generic;
using System.Linq;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public class RepositorioRegistroAtencion : iRepositorioRegistroAtencion
    {
        bool valorRetorno=false;
        //Ingresar informacion 

        public bool IngresarRegistroAtencion(RegistroAtencion registroAtencion)
        { 
          //Abriendo y Liebrando Recursos
          using(AppData.EfAppContext contexto = new AppData.EfAppContext())
         { 
            //Variable de tipo anonima con var
            var RegistroAtencion=contexto.Add(RegistroAtencion);
            contexto.SaveChanges();
            if(contexto.SaveChanges()>=1)
            {
                valorRetorno=true;
             }
            return valorRetorno;
         }
        }
            //Borrar SolicitudAtencion

        public bool BorrarRegistroAtencion(int IdRegistroAtencion)
        {
         using(AppData.EfAppContext contexto = new AppData.EfAppContext()) 
          {    
            var BusquedaRegistroAtencion=(from p in contexto.registroAtencion where p.IdRegistroAtencion==IdRegistroAtencion select p);
            if (!(BusquedaSolicitudAtencion==null))
            {
             contexto.Remove(BusquedaRegistroAtencion);
             contexto.SaveChanges();
             valorRetorno=true;

            }
            return valorRetorno;
          }   
         
        }
        
        ///<summary> 
        ///Actualizar RegistroAtencion para, actualizar informacion de registroAtencion segun sus datos 
        /// </summary>
        /// </param name="RegistroAtencion"></param>
        /// <returns>bool</returns>
        
        public bool ActualizarMedicoRegistroAtencion(RegistroAtencion registroAtencion))
        {
            
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
                var BusquedaRegistroAtencion= contexto.registroAtencion.SingleOrDefault(o=>o.IdRegistroAtencion==registroAtencion.IdRegistroAtencion);
                if(!(BusquedaRegistroAtencion==null))
                { 
                    BusquedaRegistroAtencion.Nombre=registroAtencion.Nombre;
                    BusquedaRegistroAtencion.Fecha=registroAtencion.Fecha;
                    BusquedaRegistroAtencion.Descripcion=registroAtencion.Descripcion;

                    valorRetorno=true;
                 }
                return valorRetorno;
             }

        }

        //Consultar RegistroAtencion (lista)

        public IEnumerable<RegistroAtencion> ConsultarRegistroAtencion()
        {
            //Var Listas RegistroAtencion
          
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
             {
               //return contexto.RegistroAtencion;
               //linq
               var ListaRegistroAtencion=(from p in contexto.registroAtencion select p).ToList();
               return ListaRegistroAtencion;


             }
         
        }
        //Consultar RegistroAtencion

        public Medicos ConsultarRegistroAtencion(int IdRegistroAtencion)
        { 
        
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
              var ListaRegistroAtencion=(from p in contexto.registroAtencion where p.IdRegistroAtencion==IdRegistroAtencion select p).First();
              return ListaRegistroAtencion;
              
             }
         }
 
    }
}