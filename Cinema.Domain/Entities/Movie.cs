using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Cinema_API.Data.Entity
{
    public class Movie : BasicAggregateRoot<Guid>
    {
        //[ForeignKey("movie_code")]
        //public Guid MoivieCode { get; set; }
        public Guid TypeOfFilmCode { get; set; }
        public Guid FilmFormCode { get; set; }
        //public Guid CinemaRoomCode { get; set; }
        public string MovieName { get; set; }
        public DateTime DateOfManufacture { get; set; }


        //[ForeignKey("CinemaRoomCode")]
        //public CinemaRoom CinemaRooms { get; set; }
        [ForeignKey("FilmFormCode")]
        public FilmForm FilmForm { get; set; }
        [ForeignKey("TypeOfFilmCode")]
        public TypeOfFilm TypeOfFilm { get; set; }

        public virtual ICollection<MovieScreeningDetail> MovieScreeningDetails { get; set; }


    }
}
