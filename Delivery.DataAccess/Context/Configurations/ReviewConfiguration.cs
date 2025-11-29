using Delivery.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.DataAccess.Context.Configurations;

public static class ReviewConfiguration
{
    public static void ConfigureReview(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ReviewEntity>().HasKey(x => x.Id);

        modelBuilder.Entity<ReviewEntity>().HasIndex(x => x.ExternalId).IsUnique();

        modelBuilder.Entity<ReviewEntity>().Property(x => x.Comment).IsRequired();
        modelBuilder.Entity<ReviewEntity>().Property(x => x.Rating).IsRequired();
        modelBuilder.Entity<ReviewEntity>().
            ToTable(tb => tb.HasCheckConstraint("CK_Restaurant_Rating", "\"Rating\" >= 0 AND \"Rating\" <= 5"));

        modelBuilder.Entity<ReviewEntity>().HasOne(r => r.User).WithMany(u => u.Reviews).HasForeignKey(r => r.UserId);

        modelBuilder.Entity<ReviewEntity>().HasOne(r => r.Restaurant).WithMany(x => x.Reviews)
            .HasForeignKey(r => r.RestaurnatId);
    }
}