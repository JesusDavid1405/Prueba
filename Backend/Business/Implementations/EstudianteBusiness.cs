using AutoMapper;
using Business.Interfaces;
using Data;
using Entity.DTO;
using Entity.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class EstudianteBusiness : BaseBusiness<Estudiante, EstudianteDTO>, IEstudiante
    {
        public EstudianteBusiness(BaseData<Estudiante> data, ILogger<EstudianteBusiness> logger, IMapper mapper)
            : base(data, logger, mapper){}


    }
}
