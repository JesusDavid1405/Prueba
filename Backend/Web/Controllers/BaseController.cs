using Business;
using Entity.DTO;
using Entity.Model;
using Web.Controllers.Implementations;

namespace Web.Controllers
{
    public class BaseController<T,D> : ABaseController<T,D> where D : BaseDTO where T : BaseModel
    {
        private readonly ILogger<BaseController<T,D>> _logger;
        private readonly BaseBusiness<T,D> _business;

        public BaseController(ILogger<BaseController<T, D>> logger, BaseBusiness<T, D> business)
        {
            _logger = logger;
            _business = business;
        }


    }
}
