using Microsoft.EntityFrameworkCore;
using PharmacyApp.Configs;
using PharmacyApp.Models;

namespace PharmacyApp;

public class PharmacyDbContext : DbContext
{
    protected PharmacyDbContext() {}
    public PharmacyDbContext(DbContextOptions options) : base(options) {}

    public virtual DbSet<Doctor> Doctors { get; set; }
    public virtual DbSet<Medicament> Medicaments { get; set; }
    public virtual DbSet<Patient> Patients { get; set; }
    public virtual DbSet<Prescription> Prescriptions { get; set; }
    public virtual PrescriptionMedicament PrescriptionMedicaments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new DoctorConfig());
    }
}