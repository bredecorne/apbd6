using System.ComponentModel.DataAnnotations;

namespace PharmacyApp.Models;

public class Patient
{
    [Key]
    public int IdPatient { get; set; }
    
    [MaxLength(200)]
    public string FirstName { get; set; }
    
    [MaxLength(200)]
    public string LastName { get; set; }
    
    public DateTime Birthdate { get; set; }

    public Patient(int idPatient, string firstName, string lastName, DateTime birthdate)
    {
        IdPatient = idPatient;
        FirstName = firstName;
        LastName = lastName;
        Birthdate = birthdate;
    }
}