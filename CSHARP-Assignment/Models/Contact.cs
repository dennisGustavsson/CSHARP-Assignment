using CSHARP_Assignment.Interfaces;

namespace CSHARP_Assignment.Models;

internal class Contact : IContact
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
    public string City { get; set; } = null!;
}
