using Volo.Abp.Domain.Entities;

namespace Cinema_API.Data.Entity
{
    public class Employee : BasicAggregateRoot<Guid>
    {
        //[ForeignKey("employee_code")]
        //public Guid EmployeeCode { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
    public enum Gender { Male = 0, female = 1, other = 2 }
}
