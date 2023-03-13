using Volo.Abp.Domain.Entities;

namespace Cinema_API.Data.Entity
{
    public class FilmForm : BasicAggregateRoot<Guid>
    {
        //[ForeignKey("film_form_code")]
        //public Guid FilmFormCode { get; set; }
        public string FilmForms { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
