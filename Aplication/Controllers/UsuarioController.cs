using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Servico.Usuario;

namespace Aplication.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioService UsuarioService { get; set; }

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.UsuarioService = usuarioService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
