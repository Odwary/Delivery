using Delivery.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.DataAccess.Context.Configurations;

public static class UserConfiguration
{
    public static void ConfigureUser(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<UserEntity>().HasIndex(x => x.ExternalId).IsUnique();
        modelBuilder.Entity<UserEntity>().HasIndex(x => x.Email).IsUnique();
        modelBuilder.Entity<UserEntity>().Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(100);
        modelBuilder.Entity<UserEntity>().Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(100);
        modelBuilder.Entity<UserEntity>().Property(x => x.Patronymic)
            .HasMaxLength(100);
        modelBuilder.Entity<UserEntity>().Property(x => x.UserRole)
            .HasConversion<string>()
            .IsRequired();
    }
}