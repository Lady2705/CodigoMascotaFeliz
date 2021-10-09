using MascotaFeliz.app.dominio;
using System.Collections.Generic;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public interface iRepositorioPropietario
    {
        bool IngresarPropietario(Propietario propietario);
        bool BorrarPropietario(int IdPropietario);
        bool ActualizarPropietario(Propietario propietario);
        IEnumerable<Propietario> ConsultarPropietario();
        Medicos ConsultarPropietario(int IdPropietario);
         
    }
}