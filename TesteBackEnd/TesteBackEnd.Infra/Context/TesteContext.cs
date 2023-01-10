using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Core.Entities;

namespace TesteBackEnd.Infra.Context
{
    public class TesteContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            dbContextOptions.UseSqlServer("Server=DESKTOP-Q31UENU;Database=TesteDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False;");
        }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Conteiner> conteiners { get; set; }
        public DbSet<Movimentacao> movimentacoes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(c =>
            {
                c.HasKey(c => c.Id);
                c.HasMany(c => c.conteiners)
                .WithOne()
                .HasForeignKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Conteiner>(c =>
            {
                c.HasKey(c => c.Codigo);
                c.HasMany(c => c.movimentacoes)
                .WithOne()
                .HasForeignKey(c => c.CodigoConteiner)
                .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Movimentacao>(c =>
            {
                c.HasKey(c => c.Id);

            });
        }
    }
}
