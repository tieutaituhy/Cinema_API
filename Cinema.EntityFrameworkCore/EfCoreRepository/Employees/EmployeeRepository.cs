using Cinema.Application.Contracts.Request.Employees;
using Cinema.Domain.IRepository.Employees;
using Cinema.Domain.Shared.Helper;
using Cinema.EntityFrameworkCore.EntityFrameworkCore;
using Cinema_API.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Cinema.EntityFrameworkCore.EfCoreRepository.Employees
{
    public class EmployeeRepository : EfCoreRepository<CinemaDbContext, Employee, Guid>, IEmployeeRepository
    {
        private readonly CinemaDbContext _dbContext;
        public EmployeeRepository(IDbContextProvider<CinemaDbContext> dbContextProvider, CinemaDbContext dbContext) : base(dbContextProvider)
        {
            _dbContext = dbContext;
        }

        public async Task<GenericActionResult> CreateAsync(CreateEmployeeRequest request)
        {
            var create = new Employee()
            {
                Address = request.Address,
                DateOfBirth = request.DateOfBirth,
                FullName = request.FullName,
                PhoneNumber = request.PhoneNumber,
                Gender = request.Gender
            };
            await _dbContext.AddAsync(create);
            await _dbContext.SaveChangesAsync();
            return new GenericActionResult(200, true, "Thêm thành công", create);
        }

        public async Task<GenericActionResult> GetListAsync()
        {
            var list = _dbContext.Employees.Select(item => new EmployeeRequest
            {
                Id = item.Id,
                Address = item.Address,
                DateOfBirth = item.DateOfBirth,
                FullName = item.FullName,
                PhoneNumber = item.PhoneNumber,
                Gender = item.Gender
            }).ToList();

            return new GenericActionResult(200, true, "Danh sách Employee", list);
        }
    }
}
