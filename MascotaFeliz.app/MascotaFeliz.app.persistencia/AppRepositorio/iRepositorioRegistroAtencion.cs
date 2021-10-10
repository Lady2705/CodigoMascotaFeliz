using MascotaFeliz.app.dominio;
using System.Collections.Generic;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public interface iRepositorioRegistroAtencion
    {
        bool IngresarRegistroAtencion(RegistroAtencion registroAtencion);
        bool BorrarRegistroAtencion(int IdRegistroAtencion);
        bool ActualizarRegistroAtencion(RegistroAtencion registroAtencion);
        IEnumerable<RegistroAtencion> ConsultarRegistroAtencion();
        RegistroAtencion ConsultarRegistroAtencion(int IdRegistroAtencion);
         
    }
}