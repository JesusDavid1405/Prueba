using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class MatriculaDTO : BaseDTO
    {
        public int EstudianteId { get; set; }
        public string EstudianteNombre { get; set; } = null!;

        public int CursoId { get; set; }
        public string CursoNombre { get; set; } = null!;

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public double NotaFinal { get; set; }
    }
}
