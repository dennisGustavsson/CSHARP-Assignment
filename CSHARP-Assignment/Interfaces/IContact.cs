namespace CSHARP_Assignment.Interfaces;

internal interface IContact
{
    Guid Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }      
    string Phone { get; set; }
    string Address { get; set; }
    string ZipCode { get; set; }
    string City { get; set; }

}
