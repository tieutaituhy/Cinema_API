using Cinema.Application.Contracts;
using Cinema.EntityFrameworkCore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Cinema.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CinemaEntityFrameworkCoreModule),
    typeof(CinemaApplicationContractsModule)
    )]
public class CinemaDbMigratorModule : AbpModule
{

}
