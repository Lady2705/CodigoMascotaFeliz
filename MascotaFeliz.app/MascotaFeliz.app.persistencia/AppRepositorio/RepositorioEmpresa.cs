using MascotaFeliz.app.dominio;
using System.Collections.Generic;
using System.Linq;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public class RepositorioEmpresa : iRepositorioEmpresa
    {
       bool valorRetorno=false;
        //Ingresar informacion 

        public bool IngresarEmpresa(Empresa empresa)
        { 
          //Abriendo y Liebrando Recursos
          using(AppData.EfAppContext contexto = new AppData.EfAppContext())
         { 
            //Variable de tipo anonima con var
            var RegistroEmpresa=contexto.Add(empresa);
            contexto.SaveChanges();
            if(contexto.SaveChanges()>=1)
            {
                valorRetorno=true;
             }
            return valorRetorno;
         }
        }
            //Borrar Medico

        public bool BorrarEmpresa(int Nit)
        {
         using(AppData.EfAppContext contexto = new AppData.EfAppContext()) 
          {    
            var BusquedaEmpresa=(from p in contexto.empresa where p.Nit==Nit select p);
            if (!(BusquedaEmpresa==null))
            {
             contexto.Remove(BusquedaEmpresa);
             contexto.SaveChanges();
             valorRetorno=true;

            }
            return valorRetorno;
          }   
         
        }
        
        ///<summary> 
        ///Actualizar Empresa para, actualizar informacion de Empresa segun sus datos 
        /// </summary>
        /// </param name="Empresa"></param>
        /// <returns>bool</returns>
        
        public bool ActualizarEmpresa(Empresa empresa))
        {
            
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
                var BusquedaEmpresa= contexto.empresa.SingleOrDefault(o=>o.Nit==empresa.Nit);
                if(!(BusquedaEmpresa==null))
                { 
                    BusquedaEmpresa.Nombre=empresa.Nombre;
                    BusquedaEmpresa.Direccion=empresa.Direccion;
                    valorRetorno=true;
                 }
                return valorRetorno;
             }

        }

        //Consultar Empresa (lista)

        public IEnumerable<Empresa> ConsultarEmpresa()
        {
            //Var Listas Empresa
          
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
             {
               //return contexto.medico;
               //linq
               var ListaEmpresa=(from p in contexto.empresa select p).ToList();
               return ListaEmpresa;


             }
         
        }
        //Consultar Empresa

        public Empresa ConsultarEmpresa(int Nit)
        { 
        
            using(AppData.EfAppContext contexto = new AppData.EfAppContext())
            {
              var ListaEmpresa=(from p in contexto.medico where p.Nit==Nit select p).First();
              return ListaEmpresa;
              
             }
         }
  
    }
}