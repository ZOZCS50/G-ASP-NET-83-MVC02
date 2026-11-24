using GymManagementSystemG02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementSystemG02.Configurations
{
    public class GymUserConfigurations<TUser> : IEntityTypeConfiguration<TUser> where TUser : GymUser
    {
        public void Configure(EntityTypeBuilder<TUser> builder)
        {
            builder.Property(U => U.Name).HasColumnType("varchar(50)");
            builder.Property(U => U.Email).HasColumnType("varchar(100)");
            builder.Property(U => U.Phone).HasColumnType("varchar(11)");

            builder.ComplexProperty(U => U.Address);
            builder.HasIndex(U => U.Email).IsUnique();
            builder.HasIndex(U => U.Phone).IsUnique();


            builder.ToTable(X =>
            {
                X.HasCheckConstraint("ck_EmailConstraint", "Email Like '_%@_%._%' ");
                X.HasCheckConstraint("ck_PhoneConstraint", "Len(Phone) = 11 And (Phone Like '010%' or Phone Like '011%' or Phone Like '012%' or Phone Like '015%') ");
            });


        }
    }
}
