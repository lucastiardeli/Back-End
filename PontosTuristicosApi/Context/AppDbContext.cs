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
    }
}
