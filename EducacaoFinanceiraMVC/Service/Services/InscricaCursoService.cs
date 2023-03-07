﻿using System;
using Domain.Entities;
using Domain.Interfaces;
using Domain.ViewModels;

namespace Service.Services
{
    public class InscricaCursoService : IInscricaCursoService
    {
        private readonly InvestimentoDbContext _dbContext;
        public InscricaCursoService(InvestimentoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(InscricaoCursoViewModel inscricaoCursoViewModel)
        {
            var inscricaoCurso = new InscricaoCurso()
            {
                Bio = inscricaoCursoViewModel.Bio,
                CodigoAcesso = inscricaoCursoViewModel.CodigoAcesso,
                Curso = inscricaoCursoViewModel.Curso,
                Email = inscricaoCursoViewModel.Email,
                Nome = inscricaoCursoViewModel.Nome,
                Telefone = inscricaoCursoViewModel.Telefone
            };
            _dbContext.inscricaoCurso.Add(inscricaoCurso);
            _dbContext.SaveChanges();
        }
    }
}

