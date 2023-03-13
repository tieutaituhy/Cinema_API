using Cinema.Domain.Shared.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Cinema.HttpApi.Controller;

public abstract class CinemaController : AbpControllerBase
{
    protected CinemaController()
    {
        LocalizationResource = typeof(CinemaResource);
    }
}
