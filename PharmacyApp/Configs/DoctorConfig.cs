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

        // adding data
        var doctors = new List<Doctor>();
        
        doctors.Add(new Doctor(
            1,
            "Sergio",
            "Psychiatrist",
            "SergioPsychiatrist@gmail.com"
        ));

        doctors.Add(new Doctor(
            2,
            "Pablo",
            "Anesthesiologist",
            "PabloAnesthesiologist@gmail.com"
        ));

        doctors.Add(new Doctor(
            3,
            "Azucar",
            "Diabetes",
            "AzucarDiabetes@gmail.com"
        ));

        builder.HasData(doctors);
    }
}