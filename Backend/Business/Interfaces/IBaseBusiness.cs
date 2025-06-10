using Entity.DTO;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IBaseBusiness<T,D> where T : BaseModel where D : BaseDTO
    {
        Task<IEnumerable<D>> GetAll();
        Task<D?> getById(int id);
        Task<D> Create(D dto);
        Task<bool> Update(D dto);
        Task<bool> Reactivate(int id);
    }
}
