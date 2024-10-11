namespace Westcoast_First.Models;
public class Person
{
    /* Properties */
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string SocialSecurityNumber { get; private set; }
    public string Address { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }

    /* Constructor */
    public Person(
        string firstName,
        string lastName,
        string phoneNumber,
        string socialSecurityNumber,
        string address,
        string postalCode,
        string city
    )
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        SocialSecurityNumber = socialSecurityNumber;
        Address = address;
        PostalCode = postalCode;
        City = city;
    }

    /* Tostring method */
    public override string ToString()
    {
        return $"{FirstName} {LastName}, Telefon: {PhoneNumber}, Personnummer: {SocialSecurityNumber}, Address: {Address}, {PostalCode} {City}";
    }
}