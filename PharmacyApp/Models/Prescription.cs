using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyApp.Models;

public class Prescription
{
    [Key]
    public int IdPrescription { get; set; }
    
    public DateTime Date { get; set; }
    
    public DateTime DueDate { get; set; }
    
    [ForeignKey("IdPatient")]
    public int IdPatient { get; set; }
    
    [ForeignKey("IdDoctor")]
    public int IdDoctor { get; set; }

    public Prescription(int idPrescription, DateTime date, DateTime dueDate, int idPatient, int idDoctor)
    {
        IdPrescription = idPrescription;
        Date = date;
        DueDate = dueDate;
        IdPatient = idPatient;
        IdDoctor = idDoctor;
    }
}