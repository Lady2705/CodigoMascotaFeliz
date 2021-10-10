using MascotaFeliz.app.dominio;
using System.Collections.Generic;
using System.Linq;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public class RepositorioSolicitudAtencion : iRepositorioSolicitudAtencion
    {
       bool valorRetorno=false;
        //Ingresar informacion 

        public bool IngresarSolicitudAtencion(SolicitudAtencion solicitudAtencion)
        { 
          //Abriendo y Liebrando Recursos
          using(AppData.EfAppContext contexto = new AppData.EfAppContext())
         { 
            //Variable de tipo anonima con var
            var RegistroSolicitudAtencion=contexto.Add(solicitudAtencion);
            contexto.SaveChanges();
            if(contexto.SaveChanges()>=1)
            {
                valorRetorno=true;
             }
            return valorRetorno;
         }
        }
            //Borrar SolicitudAtencion

        public bool BorrarSolicitudAtencion(int IdSolicitudAtencion)
        {
         using(AppData.EfAppContext contexto = new AppData.EfAppContext()) 
          {    
            var BusquedaSolicitudAtencion=(from p in contexto.solicitudAtencion where p.IdSolicitudAtencion==IdSolicitudAtencion select p);
            if (!(BusquedaSolicitudAtencion==null))
            {
             contexto.Remove(BusquedaSolicitudAtencion);
             contexto.SaveChanges();
             valorRetorno=true;

            }
            return valorRetorno;
          }   
         
        }
        
        ///<summary> 
        ///Actualizar Medico para, actualizar informacion de medicos segun sus datos 
        /// </summary>
        /// </param name="SolicitudAtencion"></param>
        /// <returns>bool</returns>
        
        public bool ActualizarSolicitudAtencion(SolicitudAtencion solicitudAtencion)
        {
            
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
                var BusquedaSolicitudAtencion= contexto.solicitudAtencion.SingleOrDefault(o=>o.IdSolicitudAtencion==solicitudAtencion.IdSolicitudAtencion);
                if(!(BusquedaSolicitudAtencion==null))
                { 
                    BusquedaSolicitudAtencion.NombreSolicitud=solicitudAtencion.NombreSolicitud;
                    BusquedaSolicitudAtencion.FechaSolicitud=solicitudAtencion.FechaSolicitud;
                    BusquedaSolicitudAtencion.DetalleSolicitud=solicitudAtencion.DetalleSolicitud;
                    valorRetorno=true;
                 }
                return valorRetorno;
             }

        }

        //Consultar SolicitudAtencion (lista)

        public IEnumerable<SolicitudAtencion> ConsultarSolicitudAtencion()
        {
            //Var Listas Medicos
          
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
             {
               //return contexto.solicitudAtencion;
               //linq
               var ListaSolicitudAtencion=(from p in contexto.solicitudAtencion select p).ToList();
               return ListaSolicitudAtencion;


             }
         
        }
        //Consultar medico

        public SolicitudAtencion ConsultarSolicitudAtencion(int IdSolicitudAtencion)
        { 
        
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
              var ListaSolicitudAtencion=(from p in contexto.solicitudAtencion where p.IdSolicitudAtencion==IdSolicitudAtencion select p).First();
              return ListaSolicitudAtencion;
              
             }
         }
  
    }
}