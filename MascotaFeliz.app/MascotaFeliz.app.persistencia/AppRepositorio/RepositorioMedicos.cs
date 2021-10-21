using MascotaFeliz.app.dominio;
using System.Collections.Generic;
using System.Linq;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public class RepositorioMedicos: iRepositorioMedico
    {
        bool valorRetorno=false;
        //Ingresar informacion 

        public Medicos IngresarMedico(Medicos medicos)
        { 
          //Abriendo y Liebrando Recursos
          using(AppData.EfAppContext contexto = new AppData.EfAppContext())
         { 
            //Variable de tipo anonima con var
            contexto.medicos.Add(medicos);
            contexto.SaveChanges();
             return medicos;
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
        
        
        
        public Medicos ActualizarMedico(Medicos medicos)
        {
            
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
                var BusquedaMedico= contexto.medicos.SingleOrDefault(o=>o.IdMedico==medicos.IdMedico);
                if(BusquedaMedico!=null)
                { 
                    BusquedaMedico.Nombre=medicos.Nombre;
                    BusquedaMedico.Apellido=medicos.Apellido;
                    BusquedaMedico.Direccion=medicos.Direccion;
                    BusquedaMedico.Telefono=medicos.Telefono;
                    BusquedaMedico.Especialidad=medicos.Especialidad;
                    BusquedaMedico.TarjetaProfecional=medicos.TarjetaProfecional;
                    contexto.SaveChanges();
                    
                 }
                return BusquedaMedico;
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

         public Medicos BuscarMedicoPorId(int IdMedico){
           using (AppData.EfAppContext contexto = new AppData.EfAppContext())
           return contexto.medicos.SingleOrDefault(s=>s.IdMedico==IdMedico);
         }

    }   
}