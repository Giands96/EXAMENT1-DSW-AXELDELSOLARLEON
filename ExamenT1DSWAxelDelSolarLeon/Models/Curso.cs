namespace ExamenT1DSWAxelDelSolarLeon.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int NivelAcademicoId { get; set; }
        public NivelAcademico NivelAcademico { get; set; }
    }
}
