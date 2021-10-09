using MascotaFeliz.app.dominio;
using System.Collections.Generic;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public interface iRepositorioMedico
    {
        bool IngresarMedico(Medicos medicos);
        bool BorrarMedico(int IdMedico);
        bool ActualizarMedico(Medicos medicos);
        IEnumerable<Medicos> ConsultarMedicos();
        Medicos ConsultarMedico(int IdMedico); 
         
    }
}