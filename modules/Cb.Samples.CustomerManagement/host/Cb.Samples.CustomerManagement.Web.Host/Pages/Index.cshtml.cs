using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Cb.Samples.CustomerManagement.Pages;

public class IndexModel : CustomerManagementPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
