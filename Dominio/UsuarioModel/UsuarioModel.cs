using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Usuario
{
    public class UsuarioModel 
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DtBirthday { get; set; }
        public string Senha { get; set; }

        public List<Perfil> Perfis { get; set; }
            


    }
}
