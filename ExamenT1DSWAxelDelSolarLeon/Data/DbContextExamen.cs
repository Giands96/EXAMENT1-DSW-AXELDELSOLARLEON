using Microsoft.EntityFrameworkCore;
using ExamenT1DSWAxelDelSolarLeon.Models;

namespace ExamenT1DSWAxelDelSolarLeon.Data

{
    public class DbContextExamen : DbContext
    {

        public DbContextExamen(DbContextOptions<DbContextExamen> options) : base(options)
        {
        }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<NivelAcademico> NivelesAcademicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NivelAcademico>()
                .HasMany(n => n.Cursos)
                .WithOne(c => c.NivelAcademico)
                .HasForeignKey(c => c.NivelAcademicoId);

            modelBuilder.Entity<NivelAcademico>().HasData(
                new NivelAcademico { NivelAcademicoId = 1, Descripcion = "Básico", Orden = 1 },
                new NivelAcademico { NivelAcademicoId = 2, Descripcion = "Intermedio", Orden = 2 },
                new NivelAcademico { NivelAcademicoId = 3, Descripcion = "Avanzado", Orden = 3 }
            );

            modelBuilder.Entity<Curso>().HasData(
                new Curso { CursoId = 1, CodigoCurso = "MAT01", Creditos = 4, HorasSemanales = 5, NivelAcademicoId = 1 },
                new Curso { CursoId = 2, CodigoCurso = "PROG01", Creditos = 3, HorasSemanales = 4, NivelAcademicoId = 2 },
                new Curso { CursoId = 3, CodigoCurso = "BD01", Creditos = 3, HorasSemanales = 3, NivelAcademicoId = 2 },
                new Curso { CursoId = 4, CodigoCurso = "IA01", Creditos = 5, HorasSemanales = 5, NivelAcademicoId = 3 }
             );

        }

        

    }
}
