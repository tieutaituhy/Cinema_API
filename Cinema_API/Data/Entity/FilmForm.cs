using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Cinema_API.Data.Entity
{
    public class FilmForm : AuditedAggregateRoot<Guid>
    {
        [ForeignKey("film_form_code")]
        public Guid FilmFormCode { get; set; }
        public string FilmForms { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
