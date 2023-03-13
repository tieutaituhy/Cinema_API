using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.Data;

public interface ICinemaDbSchemaMigrator
{
    Task MigrateAsync();
}
