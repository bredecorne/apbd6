using System.ComponentModel.DataAnnotations;

namespace PharmacyApp.Models;

public class Medicament
{
    [Key]
    public int IdMedicament { get; set; }

    [MaxLength(100)]
    public string Name { get; set; }
    
    [MaxLength(100)]
    public string Description { get; set; }
    
    [MaxLength(100)]
    public string Type { get; set; }

    public Medicament(int idMedicament, string name, string description, string type)
    {
        IdMedicament = idMedicament;
        Name = name;
        Description = description;
        Type = type;
    }
}