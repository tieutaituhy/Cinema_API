using Cinema.Application.Contracts.DTO.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Cinema.Application.Service.Employees
{
    public interface IEmployeeService : IApplicationService
    {
        Task<List<EmployeeDTO>> GetListAsync();
        Task<EmployeeDTO> CreateAsync(EmployeeDTO text);
        Task DeleteAsync(Guid id);

    }
}
