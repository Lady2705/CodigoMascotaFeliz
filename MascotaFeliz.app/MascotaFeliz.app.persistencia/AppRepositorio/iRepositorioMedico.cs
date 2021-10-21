using MascotaFeliz.app.dominio;
using System.Collections.Generic;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public interface iRepositorioMedico
    {
        Medicos IngresarMedico(Medicos medicos);
        bool BorrarMedico(int IdMedico);
        Medicos ActualizarMedico(Medicos medicos);
        IEnumerable<Medicos> ConsultarMedicos();
        Medicos ConsultarMedico(int IdMedico);
        Medicos BuscarMedicoPorId(int IdMedico); 
         
    }
}