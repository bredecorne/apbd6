using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharmacyApp.Models;

namespace PharmacyApp.Configs;

public class DoctorConfig : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.HasKey(e => e.IdDoctor).HasName("Doctor_PK");
        builder.Property(e => e.IdDoctor).UseIdentityColumn();

        builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
        builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();

        builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
        builder.HasIndex(e => e.Email).IsUnique();

        var doctors = new List<Doctor>();
        
        doctors.Add(new Doctor(
            1, "Jagoda", "Graniczna-Chutterjee", "j.granicznachuttergee@misiaczek.pl"));
        doctors.Add(new Doctor(
            2, "Brigitte", "Morou", "b.morou@prokuratura.gov.pl"));

        builder.HasData(doctors);
    }
}