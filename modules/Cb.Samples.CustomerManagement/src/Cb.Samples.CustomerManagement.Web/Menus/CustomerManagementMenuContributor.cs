using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Cb.Samples.CustomerManagement.Web.Menus;

public class CustomerManagementMenuContributor : IMenuContributor
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
        context.Menu.AddItem(new ApplicationMenuItem(CustomerManagementMenus.Prefix, displayName: "CustomerManagement", "~/CustomerManagement", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
