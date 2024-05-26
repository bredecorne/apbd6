using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PharmacyApp.Models;

{
    public class PatientConfig : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(e => e.IdPatient).HasName("IdPatient_PK");
            builder.Property(e => e.IdPatient).UseIdentityColumn();

            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Birthdate).IsRequired();

            // adding data

            var patients = new List<Patient>();

            patients.Add(new Patient
            {
                IdPatient = 1,
                FirstName = "Jakub",
                LastName = "Nowak",
                Birthdate = DateTime.Now.AddYears(-25)
            });

            patients.Add(new Patient
            {
                IdPatient = 2,
                FirstName = "Michal",
                LastName = "Kowalski",
                Birthdate = DateTime.Now.AddYears(-21)
            });

            patients.Add(new Patient
            {
                IdPatient = 3,
                FirstName = "Patient",
                LastName = "Patientowich",
                Birthdate = DateTime.Now.AddYears(-27)
            });

            patients.Add(new Patient
            {
                IdPatient = 4,
                FirstName = "Sergio",
                LastName = "Kotowich",
                Birthdate = DateTime.Now.AddYears(-22)
            });

            patients.Add(new Patient
            {
                IdPatient = 5,
                FirstName = "Ala",
                LastName = "Peronska",
                Birthdate = DateTime.Now.AddYears(-50)
            });

            patients.Add(new Patient
            {
                IdPatient = 6,
                FirstName = "Kot",
                LastName = "Zygmund",
                Birthdate = DateTime.Now.AddYears(-29)
            });

            patients.Add(new Patient
            {
                IdPatient = 7,
                FirstName = "Natiel",
                LastName = "Patient",
                Birthdate = DateTime.Now.AddYears(-54)
            });

            patients.Add(new Patient
            {
                IdPatient = 8,
                FirstName = "Jas",
                LastName = "Profase",
                Birthdate = DateTime.Now.AddYears(-67)
            });

            builder.HasData(patients);
        }
    }
}
