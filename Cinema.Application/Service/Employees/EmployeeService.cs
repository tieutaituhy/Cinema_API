using Cinema.Application.Contracts.DTO.Employees;
using Cinema_API.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Cinema.Application.Service.Employees
{
    public class EmployeeService : ApplicationService, IEmployeeService
    {
        private readonly IRepository<Employee, Guid> _todoItemRepository;

        public EmployeeService(IRepository<Employee, Guid> todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }
        // TODO: Implement the methods here...
        public async Task<List<EmployeeDTO>> GetListAsync()
        {
            var items = await _todoItemRepository.GetListAsync();
            return items
                .Select(item => new EmployeeDTO
                {
                    Id = item.Id,
                    Address = item.Address,
                    DateOfBirth = item.DateOfBirth,
                    FullName = item.FullName,
                    PhoneNumber = item.PhoneNumber,
                    Gender = item.Gender
                }).ToList();
        }
        public async Task<EmployeeDTO> CreateAsync(EmployeeDTO text)
        {
            var item = await _todoItemRepository.InsertAsync(
                new Employee { Address = text.Address, 
                    FullName = text.FullName, 
                    DateOfBirth = text.DateOfBirth,
                    PhoneNumber = text.PhoneNumber,
                    Gender = text.Gender}
            );

            return new EmployeeDTO
            {
                Id = item.Id,
                Address = item.Address,
                DateOfBirth = item.DateOfBirth,
                FullName = item.FullName,
                PhoneNumber = item.PhoneNumber,
                Gender = item.Gender
            };
        }
        public async Task DeleteAsync(Guid id)
        {
            await _todoItemRepository.DeleteAsync(id);
        }

    }
}
