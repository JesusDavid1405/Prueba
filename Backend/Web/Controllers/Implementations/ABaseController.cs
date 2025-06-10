using Entity.DTO;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Interfaces;

namespace Web.Controllers.Implementations
{
    public abstract class ABaseController<T,D> : IBaseController<T, D> where D : BaseDTO where T : BaseModel
    {
        public abstract Task<ActionResult<IEnumerable<D>>> GetAll();
        public abstract Task<ActionResult<D>> GetById(int id);
        public abstract Task<ActionResult<D>> Add(D dto);
        public abstract Task<ActionResult<D>> Update(D dto);
        public abstract Task<ActionResult<D>> DeletePermant(int id);
        public abstract Task<ActionResult<D>> DeleteLogical(int id);
        public abstract Task<ActionResult<D>> Reactive(int id);
    }
}
