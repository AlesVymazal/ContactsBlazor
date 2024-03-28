using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class Contact
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
	[EmailAddress]
	public string Email { get; set; } = string.Empty;
    [Phone]
    public string PhoneNumber { get; set; } = string.Empty;
}

