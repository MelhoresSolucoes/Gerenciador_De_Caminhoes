using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GcApp.Models;

namespace GcApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GcApp.Models.Caminhao> Caminhao { get; set; }
       public DbSet<GcApp.Models.ModeloVeiculo> ModeloVeiculo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Caminhao>()
                .ToTable("Caminhao");

            modelBuilder.Entity<Caminhao>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<ModeloVeiculo>()
                .ToTable("ModeloVeiculo");

            modelBuilder.Entity<ModeloVeiculo>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Caminhao>()
                .HasOne(p => p.ModeloVeiculo)
                .WithMany()
                .HasForeignKey(b => b.IdModeloVeiculo);

        }
    }
}
