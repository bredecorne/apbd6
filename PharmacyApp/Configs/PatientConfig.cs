using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharmacyApp.Models;

namespace PharmacyApp.Configs;

public class PatientConfig : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        var patients = new List<Patient>();

        patients.Add(new Patient(1, "Adam", "Gessler", DateTime.Now));
        patients.Add(new Patient(2, "Natalia", "Gessler", DateTime.Now));
        patients.Add(new Patient(3, "Błażej", "Gessler", DateTime.Now));

        builder.HasData(patients);
    }
}