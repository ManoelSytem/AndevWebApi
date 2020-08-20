using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace InfraEstrutura
{
    public class AplicationDbContext : DbContext
    {
        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user id=root;Password=Si@010101;database=Andev; Allow User Variables=True";
            optionsBuilder.UseMySql(connectionString);
        }
        public DbSet<Projeto> Projeto { get; set; }
        public DbSet<Tipo> Tipo { get; set; }
        public DbSet<Modulo> Modulo { get; set; }
        public DbSet<Requisito> Requisito { get; set; }
    }
}
