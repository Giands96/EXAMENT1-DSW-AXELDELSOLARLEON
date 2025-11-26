using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenT1DSWAxelDelSolarLeon.Migrations
{
    /// <inheritdoc />
    public partial class AjusteTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_NivelesAcademicos_NivelAcademicoId",
                table: "Cursos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NivelesAcademicos",
                table: "NivelesAcademicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos");

            migrationBuilder.RenameTable(
                name: "NivelesAcademicos",
                newName: "nivel_academico");

            migrationBuilder.RenameTable(
                name: "Cursos",
                newName: "libros");

            migrationBuilder.RenameColumn(
                name: "Orden",
                table: "nivel_academico",
                newName: "orden");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "nivel_academico",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "NivelAcademicoId",
                table: "nivel_academico",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Creditos",
                table: "libros",
                newName: "creditos");

            migrationBuilder.RenameColumn(
                name: "HorasSemanales",
                table: "libros",
                newName: "horas_semanales");

            migrationBuilder.RenameColumn(
                name: "CodigoCurso",
                table: "libros",
                newName: "codigo_curso");

            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "libros",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Cursos_NivelAcademicoId",
                table: "libros",
                newName: "IX_libros_NivelAcademicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nivel_academico",
                table: "nivel_academico",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_libros",
                table: "libros",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_libros_nivel_academico_NivelAcademicoId",
                table: "libros",
                column: "NivelAcademicoId",
                principalTable: "nivel_academico",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_libros_nivel_academico_NivelAcademicoId",
                table: "libros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_nivel_academico",
                table: "nivel_academico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_libros",
                table: "libros");

            migrationBuilder.RenameTable(
                name: "nivel_academico",
                newName: "NivelesAcademicos");

            migrationBuilder.RenameTable(
                name: "libros",
                newName: "Cursos");

            migrationBuilder.RenameColumn(
                name: "orden",
                table: "NivelesAcademicos",
                newName: "Orden");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "NivelesAcademicos",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "NivelesAcademicos",
                newName: "NivelAcademicoId");

            migrationBuilder.RenameColumn(
                name: "creditos",
                table: "Cursos",
                newName: "Creditos");

            migrationBuilder.RenameColumn(
                name: "horas_semanales",
                table: "Cursos",
                newName: "HorasSemanales");

            migrationBuilder.RenameColumn(
                name: "codigo_curso",
                table: "Cursos",
                newName: "CodigoCurso");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cursos",
                newName: "CursoId");

            migrationBuilder.RenameIndex(
                name: "IX_libros_NivelAcademicoId",
                table: "Cursos",
                newName: "IX_Cursos_NivelAcademicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NivelesAcademicos",
                table: "NivelesAcademicos",
                column: "NivelAcademicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cursos",
                table: "Cursos",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_NivelesAcademicos_NivelAcademicoId",
                table: "Cursos",
                column: "NivelAcademicoId",
                principalTable: "NivelesAcademicos",
                principalColumn: "NivelAcademicoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
