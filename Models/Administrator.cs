namespace Westcoast_First.Models;
public class Administrator : EducationalLeader
{
    /* constructor */
    public Administrator(
        string firstName,
        string lastName,
        string phoneNumber,
        string socialSecurityNumber,
        string address,
        string postalCode,
        string city,
        string expertiseArea,
        DateTime employmentDate
    )
        : base(
            firstName,
            lastName,
            phoneNumber,
            socialSecurityNumber,
            address,
            postalCode,
            city,
            expertiseArea,
            employmentDate
        ) { }
        
    /* Static Factory Method */
    public static Administrator CreateAdministrator()
    {
        return new Administrator(
            "Kalle",
            "Nilsson",
            "0704654321",
            "870101-5678",
            "valmogatan 2",
            "23251",
            "Stockholm",
            "IT-Säkerhet",
            new DateTime(2020, 5, 2)
        );
    }
    public override string ToString()
    {
        return $"{base.ToString()}";
    }
}