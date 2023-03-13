using Cinema.Domain.Shared.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Cinema.Application.Contracts.Permissions;

public class CinemaPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CinemaPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CinemaPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CinemaResource>(name);
    }
}
