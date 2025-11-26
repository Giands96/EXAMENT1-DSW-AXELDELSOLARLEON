using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamenT1DSWAxelDelSolarLeon.Migrations
{
    /// <inheritdoc />
    public partial class DatosPredefinidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NivelesAcademicos",
                columns: new[] { "NivelAcademicoId", "Descripcion", "Orden" },
                values: new object[,]
                {
                    { 1, "Básico", 1 },
                    { 2, "Intermedio", 2 },
                    { 3, "Avanzado", 3 }
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "CodigoCurso", "Creditos", "HorasSemanales", "NivelAcademicoId" },
                values: new object[,]
                {
                    { 1, "MAT01", 4, 5, 1 },
                    { 2, "PROG01", 3, 4, 2 },
                    { 3, "BD01", 3, 3, 2 },
                    { 4, "IA01", 5, 5, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NivelesAcademicos",
                keyColumn: "NivelAcademicoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NivelesAcademicos",
                keyColumn: "NivelAcademicoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NivelesAcademicos",
                keyColumn: "NivelAcademicoId",
                keyValue: 3);
        }
    }
}
