﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Cb.Samples.ProjectManagement.Pages;

public class IndexModel : ProjectManagementPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
