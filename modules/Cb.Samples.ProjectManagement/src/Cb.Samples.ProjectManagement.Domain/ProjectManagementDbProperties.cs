namespace Cb.Samples.ProjectManagement;

public static class ProjectManagementDbProperties
{
    public static string DbTablePrefix { get; set; } = "ProjectManagement";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "ProjectManagement";
}
