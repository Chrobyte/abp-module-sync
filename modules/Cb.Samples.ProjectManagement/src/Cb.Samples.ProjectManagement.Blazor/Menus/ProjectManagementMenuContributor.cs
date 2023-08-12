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
        var menuItem = context.Menu.AddItem(new ApplicationMenuItem(ProjectManagementMenus.Prefix, displayName: "ProjectManagement", "/ProjectManagement", icon: "fa fa-globe"));

        menuItem.AddItem(new(
            name: ProjectManagementMenus.Projects,
            displayName: "Projects",
            url: "~/projects",
            order: 1));

        menuItem.AddItem(new(
            name: ProjectManagementMenus.Customers,
            displayName: "Customers",
            url: "~/customers",
            order: 2));

        return Task.CompletedTask;
    }
}
