using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharmacyApp.Models;

namespace PharmacyApp.Configs;

public class DoctorConfig : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
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