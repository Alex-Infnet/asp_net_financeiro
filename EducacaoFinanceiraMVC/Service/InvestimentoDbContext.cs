using System;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Service
{
	public class InvestimentoDbContext : IdentityDbContext
    {
        public InvestimentoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<TipoInvestimento> tipoInvestimento { get; set; }
        public DbSet<Contact> contact { get; set; }
        public DbSet<InscricaoCurso> inscricaoCurso { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<Curso> curso { get; set; }
        public DbSet<Professor> professor { get; set; }
        public DbSet<IdentityUser> identity { get; set; }
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
                .HasMany(c => c.Professores)
                .WithMany(p => p.Cursos);

            modelBuilder.Entity<Professor>()
                .HasMany(p => p.Cursos)
                .WithMany(c => c.Professores);
        }
        */
    }
}

