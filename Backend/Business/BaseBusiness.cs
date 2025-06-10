using AutoMapper;
using Business.Implementations;
using Data;
using Entity.DTO;
using Entity.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BaseBusiness<T, D> : ABaseBusiness<T, D> where T : BaseModel where D : BaseDTO
    {
        private readonly BaseData<T> _data;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public BaseBusiness(BaseData<T> data, ILogger logger, IMapper mapper)
        {
            _data = data;
            _logger = logger;
            _mapper = mapper;
        }


        public override async Task<IEnumerable<D>> GetAll()
        {
            try
            {
                var entities = await _data.GetAll();
                return _mapper.Map<IEnumerable<D>>(entities);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener todos los registros de {Entity}", typeof(T).Name);
                throw;
            }
        }


        public override async Task<D?> getById(int id)
        {
            try
            {
                var entities = await _data.GetById(id);
                return _mapper.Map<D>(entities);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el registro con ID {Id} de {Entity}", id, typeof(T).Name);
                throw;
            }
        }


        public override async Task<D> Create(D dto)
        {
            try
            {
                var entity = _mapper.Map<T>(dto);
                var entities = await _data.Add(entity);
                return _mapper.Map<D>(entities);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear entidad {Entity}", typeof(T).Name);
                throw;
            }
        }


        public override async Task<bool> Update(D dto)
        {
            try
            {
                var entity = _mapper.Map<T>(dto);
                var entities = await _data.Update(entity);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al actualizar entidad {Entity}", typeof(T).Name);
                throw;
            }
        }


        public override async Task<bool> Reactivate(int id)
        {
            try
            {
                return await _data.Reactivate(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al Des-Elimnar el registro con ID {Id} de {Entity}", id, typeof(T).Name);
                throw;
            }
        }
    }
}
