using Volo.Abp.Settings;

namespace CodeFirst.Settings;

public class CodeFirstSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CodeFirstSettings.MySetting1));
    }
}
