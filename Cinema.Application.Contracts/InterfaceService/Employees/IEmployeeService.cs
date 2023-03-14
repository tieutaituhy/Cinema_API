using Cinema.Application.Contracts.Request.Employees;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Services;

namespace Cinema.Application.Contracts.InterfaceService.Employees
{
    public interface IEmployeeService : IApplicationService
    {
        Task<IActionResult> GetListEmployeeAsync();
        Task<IActionResult> CreateEmployeeAsync(CreateEmployeeRequest request);
        Task DeleteEmployeeAsync(Guid id);

    }
}
