using Entity.DTO;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Interfaces
{
    public interface IBaseController<T,D> where D : BaseDTO where T : BaseModel
    {
        Task<ActionResult<IEnumerable<D>>> GetAll();
        Task<ActionResult<D>> GetById(int id);
        Task<ActionResult<D>> Add(D dto);
        Task<ActionResult<D>> Update(D dto);
        Task<ActionResult<D>> DeletePermant(int id);
        Task<ActionResult<D>> DeleteLogical(int id);
        Task<ActionResult<D>> Reactive(int id);
    }
}
