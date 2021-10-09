using MascotaFeliz.app.dominio;
using System.Collections.Generic;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public interface IRepositorioMascota
    {
        bool IngresarMascota(Mascota mascota);
        bool BorrarMascota(int IdMascota);
        bool ActualizarMascota(Mascota mascota);
        IEnumerable<Mascota> ConsultarMascota();
        Medicos ConsultarMascota(int IdMascota);
         
    }
}