using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Cb.Samples.ProjectManagement.Blazor.Menus;

public class ProjectManagementMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(ProjectManagementMenus.Prefix, displayName: "ProjectManagement", "/ProjectManagement", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
