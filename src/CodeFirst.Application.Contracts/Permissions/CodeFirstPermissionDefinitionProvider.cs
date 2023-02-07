using CodeFirst.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CodeFirst.Permissions;

public class CodeFirstPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CodeFirstPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CodeFirstPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CodeFirstResource>(name);
    }
}
