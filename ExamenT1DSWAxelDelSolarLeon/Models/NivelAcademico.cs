using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenT1DSWAxelDelSolarLeon.Models
{

    [Table("nivel_academico")]
    public class NivelAcademico
    {

        [Column("id")]
        public int NivelAcademicoId { get; set; }

        [Column("descripcion")]
        public string Descripcion { get; set; }

        [Column("orden")]
        public int Orden { get; set; }

        public ICollection<Curso> Cursos { get; set; }
    }
}
