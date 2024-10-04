using Microsoft.EntityFrameworkCore;
using ProjetoOnion.Applications.DTOs.Map;
using ProjetoOnion.Applications.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ProjetoOnion.Infraestructure.DataContext
{
    public class SistemaPlantacoesDBContext : DbContext
    {
        public SistemaPlantacoesDBContext(DbContextOptions<SistemaPlantacoesDBContext> options)
            : base(options)
        {
        }

        public DbSet<ClimaModel> Climas { get; set; }
        public DbSet<PlantacaoModel> Plantacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClimaMap());
            modelBuilder.ApplyConfiguration(new PlantacaoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}