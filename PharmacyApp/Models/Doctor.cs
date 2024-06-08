using System.ComponentModel.DataAnnotations;

namespace PharmacyApp.Models;

public class Doctor
{
    [Key]
    public int IdDoctor { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public Doctor(int idDoctor, string firstName, string lastName, string email)
    {
        IdDoctor = idDoctor;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}