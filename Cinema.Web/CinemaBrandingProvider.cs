using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Cinema.Web;

[Dependency(ReplaceServices = true)]
public class CinemaBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Cinema";
}
