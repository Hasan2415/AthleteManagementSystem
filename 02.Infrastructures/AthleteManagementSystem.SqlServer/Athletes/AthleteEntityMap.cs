using AthleteManagementSystem.Domain.Athletes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AthleteManagementSystem.SqlServer.Athletes
{
    internal class AthleteEntityMap : IEntityTypeConfiguration<Athlete>
    {
        public void Configure(EntityTypeBuilder<Athlete> _)
        {
            _.ToTable("Athletes");
            _.HasKey(x => x.Id);
            _.Property(x => x.FirstName).IsRequired().HasMaxLength(250);
            _.Property(x => x.LastName).IsRequired().HasMaxLength(250);
            _.Property(x=>x.MobileNumber).IsRequired().HasMaxLength(11);
            _.Property(x=>x.NationalCode).IsRequired().HasMaxLength(10);
        }
    }
}
