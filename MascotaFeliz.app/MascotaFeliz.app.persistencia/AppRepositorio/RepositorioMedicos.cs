using MascotaFeliz.app.dominio;
using System.Collections.Generic;
using System.Linq;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public class RepositorioMedicos: iRepositorioMedico
    {
        bool valorRetorno=false;
        //Ingresar informacion 

        public bool IngresarMedico(Medicos medicos)
        { 
          //Abriendo y Liebrando Recursos
          using(AppData.EfAppContext contexto = new AppData.EfAppContext())
         { 
            //Variable de tipo anonima con var
            var RegistroMedico=contexto.Add(medicos);
            contexto.SaveChanges();
            if(contexto.SaveChanges()>=1)
            {
                valorRetorno=true;
             }
            return valorRetorno;
         }
        }
            //Borrar Medico

        public bool BorrarMedico(int IdMedico)
        {
         using(AppData.EfAppContext contexto = new AppData.EfAppContext()) 
          {    
            var BusquedaMedico=(from p in contexto.medicos where p.IdMedico==IdMedico select p);
            if (!(BusquedaMedico==null))
            {
             contexto.Remove(BusquedaMedico);
             contexto.SaveChanges();
             valorRetorno=true;

            }
            return valorRetorno;
          }   
         
        }
        
        ///<summary> 
        ///Actualizar Medico para, actualizar informacion de medicos segun sus datos 
        /// </summary>
        /// </param name="Medico"></param>
        /// <returns>bool</returns>
        
        public bool ActualizarMedico(Medicos medicos)
        {
            
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
                var BusquedaMedico= contexto.medicos.SingleOrDefault(o=>o.IdMedico==medicos.IdMedico);
                if(!(BusquedaMedico==null))
                { 
                    BusquedaMedico.Nombre=medicos.Nombre;
                    BusquedaMedico.TarjetaProfecional=medicos.TarjetaProfecional;
                    valorRetorno=true;
                 }
                return valorRetorno;
             }

        }

        //Consultar Medico (lista)

        public IEnumerable<Medicos> ConsultarMedicos()
        {
            //Var Listas Medicos
          
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
             {
               //return contexto.medico;
               //linq
               var ListaMedicos=(from p in contexto.medicos select p).ToList();
               return ListaMedicos;


             }
         
        }
        //Consultar medico

        public Medicos ConsultarMedico(int IdMedico)
        { 
        
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
              var ListaMedicos=(from p in contexto.medicos where p.IdMedico==IdMedico select p).First();
              return ListaMedicos;
              
             }
         }

    }   
}