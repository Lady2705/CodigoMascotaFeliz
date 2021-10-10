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
            var IngresarRegistroAtencion=contexto.Add(registroAtencion);
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
            if (!(BusquedaRegistroAtencion==null))
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
        
        public bool ActualizarRegistroAtencion(RegistroAtencion registroAtencion)
        {
            
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
                var BusquedaRegistroAtencion= contexto.registroAtencion.SingleOrDefault(o=>o.IdRegistroAtencion==registroAtencion.IdRegistroAtencion);
                if(!(BusquedaRegistroAtencion==null))
                { 
                    BusquedaRegistroAtencion.NombreRegistro=registroAtencion.NombreRegistro;
                    BusquedaRegistroAtencion.FechaRegistro=registroAtencion.FechaRegistro;
                    BusquedaRegistroAtencion.DescripcionRegistro=registroAtencion.DescripcionRegistro;

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

        public RegistroAtencion ConsultarRegistroAtencion(int IdRegistroAtencion)
        { 
        
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
              var ListaRegistroAtencion=(from p in contexto.registroAtencion where p.IdRegistroAtencion==IdRegistroAtencion select p).First();
              return ListaRegistroAtencion;
              
             }
        }
 
    }
}