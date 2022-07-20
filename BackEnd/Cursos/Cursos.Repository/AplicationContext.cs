using Cursos.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Cursos.Repository
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Estudante> Estudantes {get; set;}
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
    }
}
