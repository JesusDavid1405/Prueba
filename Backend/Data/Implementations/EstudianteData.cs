using Data.Interfaces;
using Entity.Context;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class EstudianteData : BaseData<Estudiante>, IEstudiante
    {
        public EstudianteData(ApplicationDbContext context)
            :base(context) { }

    }
}
