using Volo.Abp.Settings;

namespace Cb.Samples.ModulesEntitySync.Settings;

public class ModulesEntitySyncSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ModulesEntitySyncSettings.MySetting1));
    }
}
