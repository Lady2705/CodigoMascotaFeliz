using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MascotaFelizPresentacion.app.pagina.Pages
{
    public class ClienteModel : PageModel
    {
        private readonly ILogger<ClienteModel> _logger;

        public ClienteModel(ILogger<ClienteModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}