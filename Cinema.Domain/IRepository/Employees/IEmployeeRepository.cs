using Cinema.Application.Contracts.Request.Employees;
using Cinema.Domain.Shared.Helper;

namespace Cinema.Domain.IRepository.Employees
{
    public interface IEmployeeRepository
    {
        Task<GenericActionResult> GetListAsync();
        Task<GenericActionResult> CreateAsync(CreateEmployeeRequest request);
        
    }
}
