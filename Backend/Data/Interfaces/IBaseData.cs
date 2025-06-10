using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IBaseData<T> where T : BaseModel
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetById(int id);
        Task<T> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> DeleteLogical(int id);
        Task<bool> DeletePermant(int id);
        Task<bool> Reactivate(int id);
    }
}
