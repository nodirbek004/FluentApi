using FluentApi.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentApi.Configuration;

public class UserTypeConfiguration : IEntityTypeConfiguration<User>
{

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x=>x.Name)
            .IsRequired();

        builder.HasMany(x => x.Category)
            .WithMany(x => x.Users)
            .UsingEntity(nameof(UserCategory));


        builder.HasOne(x => x.Address).WithMany(x => x.Users)
            .HasForeignKey(x=>x.AddressId);
    }
}
