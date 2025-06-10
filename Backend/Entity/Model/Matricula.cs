using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Matricula : BaseModel
    {
        //Relacion entre matricula y estudiante
        public Estudiante Estudiante { get; set; }
        public int EstudianteId { get; set; }

        //Relacion entre matrucla y curso
        public Curso Curso { get; set; }
        public int CursoId { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin {  get; set; }
        public double NotaFinal { get; set; }

    }
}
