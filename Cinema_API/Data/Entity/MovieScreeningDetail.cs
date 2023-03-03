using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Cinema_API.Data.Entity
{
    public class MovieScreeningDetail : AuditedAggregateRoot<Guid>
    {
        [ForeignKey("movieScreeningDetail_code")]
        //public Guid MovieScreeningDetailCode { get; set; }
        public Guid TicketCode { get; set; }
        public DateTime? Premiere { get; set; }
        public Guid MovieCode { get; set; }
        public Guid CinemaRoomCode { get; set; }




        [ForeignKey("MovieCode")]
        public Movie Movie { get; set; }

        [ForeignKey("CinemaRoomCode")]
        public CinemaRoom CinemaRoom { get; set; }

    }
}
