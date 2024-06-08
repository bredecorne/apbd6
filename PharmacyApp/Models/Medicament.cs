using System.ComponentModel.DataAnnotations;

namespace PharmacyApp.Models;

public class Medicament
{
    [Key]
    public int IdMedicament { get; set; }
    public int IdPrescription { get; set; }
    public int Dose { get; set; }
    public string Details { get; set; }

    public Medicament(int idMedicament, int idPrescription, int dose, string details)
    {
        IdMedicament = idMedicament;
        IdPrescription = idPrescription;
        Dose = dose;
        Details = details;
    }
}