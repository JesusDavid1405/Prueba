using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Estudiante : BaseModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public string TipoDocumento {  get; set; }
        public string NumeroDocumento { get; set; }

        public string Telefono {  get; set; }

        public List<Matricula> Matriculas = new List<Matricula>();
    }
}
