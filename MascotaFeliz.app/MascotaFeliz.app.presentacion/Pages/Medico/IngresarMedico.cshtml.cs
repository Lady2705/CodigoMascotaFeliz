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
    public class IngresarMedicoModel : PageModel
    {
         [BindProperty]
        public MascotaFeliz.app.dominio.Medicos medicos{get; set;}
        private readonly iRepositorioMedico repositorio;
        public void OnGet()
        {
        }
        public IngresarMedicoModel(iRepositorioMedico repositorio){
            this.repositorio=repositorio;
        }
        public void OnPost(){

           // Medicos medicos= new Medicos();   
           // medicos.Nombre=medico.Nombre;
           // medicos.Apellido=medico.Apellido;
           // medicos.Direccion=medico.Direccion;
           // medicos.Telefono=medico.Telefono;
           // medicos.TarjetaProfecional=medico.TarjetaProfecional;
           // medicos.Especialidad=medico.Especialidad;
            medicos=repositorio.IngresarMedico(medicos);
        }
    }
}
