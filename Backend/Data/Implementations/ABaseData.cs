using Data.Interfaces;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public abstract class ABaseData<T> : IBaseData<T> where T : BaseModel
    {
        public abstract Task<IEnumerable<T>> GetAll();
        public abstract Task<T?> GetById(int id);
        public abstract Task<T> Add(T entity);
        public abstract Task<bool> Update(T entity);
        public abstract Task<bool> DeleteLogical(int id);
        public abstract Task<bool> DeletePermant(int id);
        public abstract Task<bool> Reactivate(int id);
    }
}
