using Cinema.Domain.Shared.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Localization;

namespace Cinema.Application;

public abstract class CinemaAppService : ApplicationService
{
    protected CinemaAppService()
    {
        LocalizationResource = typeof(CinemaResource);
    }
}
