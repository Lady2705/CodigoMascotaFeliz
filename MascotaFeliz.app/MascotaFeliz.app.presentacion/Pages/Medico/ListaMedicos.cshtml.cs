using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.app.persistencia.AppRepositorio;
using MascotaFeliz.app.dominio;

namespace MascotaFeliz.app.presentacion.page
{
    public class ListaMedicosModel : PageModel
    {
        private readonly iRepositorioMedico repositorio;
        public IEnumerable<Medicos> Medicos= new List<Medicos>();

        //Inicializacion de la Pagina
        public void OnGet()
        {
            Medicos=repositorio.ConsultarMedicos();

        }
        public ListaMedicosModel(iRepositorioMedico repositorio)
        { 
            this.repositorio=repositorio;
        }
    }
}
