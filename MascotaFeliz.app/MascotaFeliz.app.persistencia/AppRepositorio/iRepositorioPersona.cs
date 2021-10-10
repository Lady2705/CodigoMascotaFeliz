using MascotaFeliz.app.dominio;
using System.Collections.Generic;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public interface iRepositorioPersona
    {
        bool IngresarPersona(Persona persona);
        bool BorrarPersona(int IdPersona);
        bool ActualizarPersona(Persona persona);
        IEnumerable<Persona> ConsultarPersona();
        Persona ConsultarPersona(int IdPersona);
         
    }
}