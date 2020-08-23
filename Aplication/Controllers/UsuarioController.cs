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
        private IUsuarioIdentityManager UsuarioIdentityManager { get; set; }

        public UsuarioController(IUsuarioService usuarioService, IUsuarioIdentityManager usuarioIdentityManager)
        {
            this.UsuarioService = usuarioService;
            this.UsuarioIdentityManager = usuarioIdentityManager;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
