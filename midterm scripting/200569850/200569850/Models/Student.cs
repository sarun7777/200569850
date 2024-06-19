using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key]
    public int StudentId { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    public string EmailAddress { get; set; }
}
