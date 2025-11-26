using ExamenT1DSWAxelDelSolarLeon.Data;
using ExamenT1DSWAxelDelSolarLeon.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamenT1DSWAxelDelSolarLeon
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly DbContextExamen _context;

        public CursosController(DbContextExamen context)
        {
            _context = context;
        }


        [HttpGet("nivel/{nivelAcademicoId}")]
        public ActionResult<IEnumerable<Curso>> ListarCursosPorNivel(int nivelAcademicoId)
        {
            var cursos = _context.Cursos
                .Where(c => c.NivelAcademicoId == nivelAcademicoId)
                .ToList();

            if (!cursos.Any())
                return NotFound("No se encontraron cursos para ese nivel académico.");

            return Ok(cursos);
        }

    }
}
