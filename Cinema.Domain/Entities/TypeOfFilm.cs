using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Cinema_API.Data.Entity
{
    public class TypeOfFilm : BasicAggregateRoot<Guid>
    {
        //[ForeignKey("type_of_film_code")]
        //public Guid TypeOfFilmCode { get; set; }
        public string TypeOfFilms { get; set; }


        public virtual ICollection<Movie> Movies { get; set; }
    }
}
