namespace Cb.Samples.CustomerManagement;

public static class CustomerManagementDbProperties
{
    public static string DbTablePrefix { get; set; } = "CustomerManagement";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "CustomerManagement";
}
