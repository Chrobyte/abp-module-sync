using Cb.Samples.CustomerManagement.Countries;
using Cb.Samples.CustomerManagement.Customers;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Cb.Samples.CustomerManagement.EntityFrameworkCore;

public static class CustomerManagementDbContextModelCreatingExtensions
{
    public static void ConfigureCustomerManagement(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Country>(b =>
        {
            b.ToTable(CustomerManagementDbProperties.DbTablePrefix + "Countries", CustomerManagementDbProperties.DbSchema);

            b.ConfigureByConvention();
        });

        builder.Entity<Customer>(b =>
        {
            b.ToTable(CustomerManagementDbProperties.DbTablePrefix + "Customers", CustomerManagementDbProperties.DbSchema);

            b.ConfigureByConvention();

            b.HasOne<Country>()
                .WithMany()
                .HasForeignKey(p => p.CountryId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}
