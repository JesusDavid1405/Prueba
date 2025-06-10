using AutoMapper;
using Entity.DTO;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Map
{
    public class Map : Profile
    {
        public Map()
        {
            CreateMap<Estudiante, EstudianteDTO>().ReverseMap();

            CreateMap<Curso, CursoDTO>().ReverseMap();

            CreateMap<Matricula, MatriculaDTO>().ReverseMap();
        }
    }
}
