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
    public class ActualizarMedicoModel : PageModel
    {
        private readonly iRepositorioMedico repositorio;
        [BindProperty]
        public MascotaFeliz.app.dominio.Medicos medico{get; set;}
        public ActualizarMedicoModel(iRepositorioMedico repositorio){
            this.repositorio=repositorio;
        }
       public IActionResult OnGet(int IdMedico)
        {
           medico=repositorio.BuscarMedicoPorId(IdMedico);
           if(medico==null){
               return RedirectToPage("/PaginaNoEncontrada");
           }
           else{
               return Page();
           }
           
        }
        public IActionResult OnPost(){
            medico=repositorio.ActualizarMedico(medicos);
            if(medico==null){
               return RedirectToPage("/PaginaNoEncontrada");
           }
           else{
               return Page();
           }

        }
    }
}
