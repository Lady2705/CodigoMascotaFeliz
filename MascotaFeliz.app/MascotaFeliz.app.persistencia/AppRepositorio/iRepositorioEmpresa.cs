using MascotaFeliz.app.dominio;
using System.Collections.Generic;

namespace MascotaFeliz.app.persistencia.AppRepositorio
{
    public interface iRepositorioEmpresa
    {
        bool IngresarEmpresa(Empresa empresa);
        bool BorrarEmpresa(int Nit);
        bool ActualizarEmpresa(Empresa empresa);
        IEnumerable<Empresa> ConsultarEmpresa();
        Medicos ConsultarEmpresa(int Nit);  
    }
}