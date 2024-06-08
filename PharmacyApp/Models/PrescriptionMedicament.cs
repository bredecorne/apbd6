using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PharmacyApp.Models;

[PrimaryKey("IdMedicament", "IdPrescription")]
public class PrescriptionMedicament
{
    
    [ForeignKey("IdPrescription")]
    public int IdMedicament { get; set; }

    [ForeignKey("IdMedicament")]
    public int IdPrescription { get; set; }

    public int Dose { get; set; }

    [MaxLength(100)]
    public string details { get; set; }

    public PrescriptionMedicament(int idMedicament, int idPrescription, int dose, string details)
    {
        IdMedicament = idMedicament;
        IdPrescription = idPrescription;
        Dose = dose;
        this.details = details;
    }
}