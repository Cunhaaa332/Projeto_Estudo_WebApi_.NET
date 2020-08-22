using Dominio.UsuarioModel.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Usuario
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository UsuarioRepository { get; set; }

        public UsuarioService (IUsuarioRepository usuarioRepository)
        {
            this.UsuarioRepository = usuarioRepository;
        }
    }
}
