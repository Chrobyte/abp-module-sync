using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Cb.Samples.CustomerManagement.Blazor.Menus;

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
        var menuItem = context.Menu.AddItem(new ApplicationMenuItem(CustomerManagementMenus.Prefix, displayName: "CustomerManagement", "/CustomerManagement", icon: "fa fa-globe"));

        menuItem.AddItem(new(
            name: CustomerManagementMenus.Customers,
            displayName: "Customers",
            url: "~/customers",
            order: 1));

        menuItem.AddItem(new(
            name: CustomerManagementMenus.Countries,
            displayName: "Countries",
            url: "~/countries",
            order: 2));

        return Task.CompletedTask;
    }
}
