using MascotaFeliz.app.dominio;
using System.Collections.Generic;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public interface iRepositorioTipoAnimal
    {
        bool IngresarTipoAnimal(TipoAnimal tipoAnimal);
        bool BorrarTipoAnimal(int IdTipoAnimal);
        bool ActualizarTipoAnimal(TipoAnimal tipoAnimal);
        IEnumerable<TipoAnimal> ConsultarTipoAnimal();
        TipoAnimal ConsultarTipoAnimal(int IdTipoAnimal);
         
    }
}