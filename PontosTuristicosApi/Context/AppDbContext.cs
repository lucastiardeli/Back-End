using Microsoft.EntityFrameworkCore;
using PontosTuristicosApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontosTuristicosApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Ponto> Pontos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ponto>().HasData(
                new Ponto
                {
                    Id = 1,
                    Nome = "Jardim Botânico",
                    Cidade = "Curitiba",
                    Estado = "PR",
                    RuaReferencia = "Ostoja Ruguski",
                    Descricao = "Cartão postal de Curitiba, flores típicas da Mata-Atlântica"
                },
                new Ponto
                {
                    Id = 2,
                    Nome = "Avenida Paulista",
                    Cidade = "São Paulo",
                    Estado = "SP",
                    RuaReferencia = "Avenida Paulista",
                    Descricao = "Uma das principais avenidas de São Paulo, com um trecho de 3KM"

                },

                new Ponto
                {
                    Id = 3,
                    Nome = "Praia de Copacabana",
                    Cidade = "Rio de Janeiro",
                    Estado = "RJ",
                    RuaReferencia = "Copacabana Praia",
                    Descricao = "Destino litorâneo mais epeciais do mundo"
                }
                );
        }
    }
}
