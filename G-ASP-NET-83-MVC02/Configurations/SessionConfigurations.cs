using GymManagementSystemG02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementSystemG02.Configurations
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(S => S.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.ToTable(X =>
            {
                X.HasCheckConstraint("ck_CapacityConstraint", "Capacity Between 1 And 25");
                X.HasCheckConstraint("ck_StartEndDateConstraint", "EndDate > StartDate");
            });

            builder.HasOne(S => S.Trainer)
                .WithMany(T => T.Sessions)
                .HasForeignKey(S => S.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
