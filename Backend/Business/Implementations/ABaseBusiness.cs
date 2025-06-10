using Business.Interfaces;
using Entity.DTO;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public abstract class ABaseBusiness<T,D> : IBaseBusiness<T,D> where T : BaseModel where D : BaseDTO
    {
        public abstract Task<IEnumerable<D>> GetAll();
        public abstract Task<D?> getById(int id);
        public abstract Task<D> Create(D dto);
        public abstract Task<bool> Update(D dto);
        public abstract Task<bool> Reactivate(int id);
    }
}
