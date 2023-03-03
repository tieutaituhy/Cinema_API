using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace Cinema_API.Data
{
    public class CinemaEFCoreDbSchemaMigrator : ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public CinemaEFCoreDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the BookStoreDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CinemaDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
