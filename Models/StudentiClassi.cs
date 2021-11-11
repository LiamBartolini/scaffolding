using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace bartolini.liam._5h.scaffolding.Models
{
    public partial class StudentiClassi : DbContext
    {
        public StudentiClassi()
        {
        }

        public StudentiClassi(DbContextOptions<StudentiClassi> options)
            : base(options)
        {
        }

        public virtual DbSet<Aula> Aulas { get; set; } = null!;
        public virtual DbSet<Classe> Classes { get; set; } = null!;
        public virtual DbSet<Docente> Docentes { get; set; } = null!;
        public virtual DbSet<Materia> Materia { get; set; } = null!;
        public virtual DbSet<Studente> Studentes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=StudentiClassi.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aula>(entity =>
            {
                entity.HasKey(e => e.IdAula);

                entity.ToTable("Aula");

                entity.Property(e => e.IdAula).ValueGeneratedNever();

                entity.Property(e => e.FkIdClasse).HasColumnName("FK_IdClasse");

                entity.HasOne(d => d.FkIdClasseNavigation)
                    .WithMany(p => p.Aulas)
                    .HasForeignKey(d => d.FkIdClasse)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Classe>(entity =>
            {
                entity.HasKey(e => e.Idclasse);

                entity.ToTable("Classe");

                entity.HasIndex(e => e.Idclasse, "IX_Classe_IDClasse")
                    .IsUnique();

                entity.Property(e => e.Idclasse).HasColumnName("IDClasse");
            });

            modelBuilder.Entity<Docente>(entity =>
            {
                entity.HasKey(e => e.IdDocente);

                entity.ToTable("Docente");

                entity.Property(e => e.IdDocente).ValueGeneratedNever();

                entity.Property(e => e.FkIdMateria).HasColumnName("FK_IdMateria");

                entity.HasOne(d => d.FkIdMateriaNavigation)
                    .WithMany(p => p.Docentes)
                    .HasForeignKey(d => d.FkIdMateria);
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.HasKey(e => e.IdMateria);

                entity.Property(e => e.FkIdClasse).HasColumnName("FK_IdClasse");

                entity.HasOne(d => d.FkIdClasseNavigation)
                    .WithMany(p => p.Materia)
                    .HasForeignKey(d => d.FkIdClasse)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Studente>(entity =>
            {
                entity.HasKey(e => e.Idstudente);

                entity.ToTable("Studente");

                entity.HasIndex(e => e.CodiceFiscale, "IX_Studente_CodiceFiscale")
                    .IsUnique();

                entity.HasIndex(e => e.Idstudente, "IX_Studente_IDStudente")
                    .IsUnique();

                entity.Property(e => e.Idstudente).HasColumnName("IDStudente");

                entity.Property(e => e.FkIdClasse).HasColumnName("FK_IdClasse");

                entity.HasOne(d => d.FkIdClasseNavigation)
                    .WithMany(p => p.Studentes)
                    .HasForeignKey(d => d.FkIdClasse);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
