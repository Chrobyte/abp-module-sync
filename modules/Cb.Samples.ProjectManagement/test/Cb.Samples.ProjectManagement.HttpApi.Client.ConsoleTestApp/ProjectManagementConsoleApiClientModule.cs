using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Cb.Samples.ProjectManagement;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProjectManagementHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ProjectManagementConsoleApiClientModule : AbpModule
{

}
