using Dados.Mapping;
using Dominio;
using Dominio.Usuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dados.Context
{
    public class RedeSocialContext : DbContext
    {

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<Perfil> Perfis { get; set; }

        public static readonly ILoggerFactory _loggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public RedeSocialContext(DbContextOptions<RedeSocialContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(_loggerFactory);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PerfilMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
