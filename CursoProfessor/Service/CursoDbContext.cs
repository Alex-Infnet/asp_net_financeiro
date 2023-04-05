using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Service
{
    public class CursoDbContext : IdentityDbContext
    {
        public DbSet<Curso> cursos { get; set; }
        public DbSet<Professor> professores { get; set; }

        public CursoDbContext(DbContextOptions options) : base(options) { }
    }
}

