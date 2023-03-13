using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Cinema_API.Data.Entity
{
    public class Ticket : BasicAggregateRoot<Guid>
    {
        //[ForeignKey("ticket_code")]
        //public Guid TicketCode { get; set; }
        public Guid TicketTypeCode { get; set; }
        public Guid EmployeeCode { get; set; }
        public Guid CustomerCode { get; set; }
        public int? Chair { get; set; }
        public DateTime? TicketSaleDate { get; set; }



        [ForeignKey("EmployeeCode")]
        public Employee Employees { get; set; }
        [ForeignKey("CustomerCode")]
        public Customer Customer { get; set; }
        [ForeignKey("TicketTypeCode")]
        public TicketType TicketType { get; set; }
        //[ForeignKey("TicketTypeCode")]
        //public TicketType TicketType { get; set; }

    }
}
