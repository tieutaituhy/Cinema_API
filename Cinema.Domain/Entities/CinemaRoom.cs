using Volo.Abp.Domain.Entities;

namespace Cinema_API.Data.Entity
{
    public class CinemaRoom : BasicAggregateRoot<Guid>
    {
        //[ForeignKey("cinema_room_code")]
        //public Guid CinemaRoomCode { get; set; }
        public string NameRoom { get; set; }


        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<MovieScreeningDetail> MovieScreeningDetails { get; set; }
    }
}
