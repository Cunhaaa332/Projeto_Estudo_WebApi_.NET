using Dominio.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Perfil
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public UsuarioModel usuario { get; set; }
    }
}
