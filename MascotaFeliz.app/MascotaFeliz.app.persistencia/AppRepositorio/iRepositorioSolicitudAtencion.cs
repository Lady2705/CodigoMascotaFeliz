using MascotaFeliz.app.dominio;
using System.Collections.Generic;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public interface iRepositorioSolicitudAtencion
    {
        bool IngresarSolicitudAtencion(SolicitudAtencion solicitudAtencion);
        bool BorrarSolicitudAtencion(int IdSolicitudAtencion);
        bool ActualizarSolicitudAtencion(SolicitudAtencion solicitudAtencion);
        IEnumerable<SolicitudAtencion> ConsultarSolicitudAtencion();
        SolicitudAtencion ConsultarSolicitudAtencion(int IdSolicitudAtencion);
         
    }
}