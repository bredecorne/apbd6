using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PharmacyApp.Models;

namespace PharmacyApp.Configs;

public class MedicamentConfig : IEntityTypeConfiguration<Medicament>
{
    public void Configure(EntityTypeBuilder<Medicament> builder)
    {
        var medicaments = new List<Medicament>();
        
        medicaments.Add(new Medicament(1, "Kucharzolin", "Lek na urazy w kuchni", "Przeciwbólowy"));

        builder.HasData(medicaments);
    }
}