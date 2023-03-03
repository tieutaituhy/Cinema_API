using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Cinema_API.Data.Entity
{
    public class Customer : AuditedAggregateRoot<Guid>
    {
        [ForeignKey("customer_code")]
        public Guid CustomerCode { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }


        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
