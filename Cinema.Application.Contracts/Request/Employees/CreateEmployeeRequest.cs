using Cinema.Domain.Shared.Enum;
using Volo.Abp.Domain.Entities;

namespace Cinema.Application.Contracts.Request.Employees
{
    public class CreateEmployeeRequest 
    {
        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
    }
}
