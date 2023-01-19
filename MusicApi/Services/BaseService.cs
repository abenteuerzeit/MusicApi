using Domain.Interfaces;

namespace Api.Services
{
    public class BaseService
    {
        protected internal IUnitOfWork UnitOfWork { get; set; }

        public BaseService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}
