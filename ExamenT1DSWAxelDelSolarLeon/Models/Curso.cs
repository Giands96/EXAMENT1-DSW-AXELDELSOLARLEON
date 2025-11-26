using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ExamenT1DSWAxelDelSolarLeon.Models
{
    [Table("libros")]
    public class Curso
    {

        [Key]
        [Column("id")]
        public int CursoId { get; set; }
        [Column("codigo_curso")]
        public string CodigoCurso { get; set; } = string.Empty;
        [Column("creditos")]
        public int Creditos { get; set; }

        [Column("horas_semanales")]
        public int HorasSemanales { get; set; }

        [ForeignKey("NivelAcademicoId")]
        public int NivelAcademicoId { get; set; }

        [JsonIgnore]
        public NivelAcademico NivelAcademico { get; set; }
    }
}
