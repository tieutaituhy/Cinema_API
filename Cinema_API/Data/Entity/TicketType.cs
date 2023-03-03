using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Cinema_API.Data.Entity
{
    public class TicketType : AuditedAggregateRoot<Guid>
    {
        [ForeignKey("ticket_type_code")]
        public Guid TicketTypeCode { get; set; }
        public string TicketTypes { get; set; }
        public double Price { get; set; }



        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
