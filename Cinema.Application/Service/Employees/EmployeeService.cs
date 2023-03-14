using Cinema.Application.Contracts.InterfaceService.Employees;
using Cinema.Application.Contracts.Request.Employees;
using Cinema.Domain.IRepository.Employees;
using Cinema_API.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Domain.Repositories;

namespace Cinema.Application.Service.Employees
{
    [Route("api/app/Lead/[action]")]
    public class EmployeeService : CinemaAppService, IEmployeeService
    {
        private readonly IRepository<Employee, Guid> _todoItemRepository;
        private readonly IEmployeeRepository _employeeRepository;


        public EmployeeService(
            IRepository<Employee, Guid> todoItemRepository,
            IEmployeeRepository employeeRepository
            )
        {
            _todoItemRepository = todoItemRepository;
            _employeeRepository = employeeRepository;
        }
        // TODO: Implement the methods here...
        [HttpGet]
        public async Task<IActionResult> GetListEmployeeAsync()
        {
            //var items = await _todoItemRepository.GetListAsync();
            //return items
            //    .Select(item => new EmployeeDTO
            //    {
            //        Id = item.Id,
            //        Address = item.Address,
            //        DateOfBirth = item.DateOfBirth,
            //        FullName = item.FullName,
            //        PhoneNumber = item.PhoneNumber,
            //        Gender = item.Gender
            //    }).ToList();
            var result = await _employeeRepository.GetListAsync();
            return result;
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployeeAsync(CreateEmployeeRequest request)
        {
            //    var item = await _todoItemRepository.InsertAsync(
            //        new Employee { Address = text.Address, 
            //            FullName = text.FullName, 
            //            DateOfBirth = text.DateOfBirth,
            //            PhoneNumber = text.PhoneNumber,
            //            Gender = text.Gender}
            //    );

            //    return new EmployeeDTO
            //    {
            //        Id = item.Id,
            //        Address = item.Address,
            //        DateOfBirth = item.DateOfBirth,
            //        FullName = item.FullName,
            //        PhoneNumber = item.PhoneNumber,
            //        Gender = item.Gender
            //    };
            var result = await _employeeRepository.CreateAsync(request);
            return result;
        }
        [HttpDelete]
        public async Task DeleteEmployeeAsync(Guid id)
        {
            await _todoItemRepository.DeleteAsync(id);
        }

    }
}
