namespace Westcoast_First.Models;
public class Teacher : Person
{
    /* Properties */
    public string ExpertiseArea { get; private set; }

    // Aggregation
    public List<Course> ResponsibleCourses { get; private set; }

    /* constructor */
    public Teacher(
        string firstName,
        string lastName,
        string phoneNumber,
        string socialSecurityNumber,
        string address,
        string postalCode,
        string city,
        string expertiseArea
    )
        : base(firstName, lastName, phoneNumber, socialSecurityNumber, address, postalCode, city)
    {
        ExpertiseArea = expertiseArea;
        ResponsibleCourses = new List<Course>();
    }

    /* Method */
    public void AddResponsibleCourse(Course course)
    {
        ResponsibleCourses.Add(course);
    }

    /* Static methods */
    public static Teacher WebDevelopment()
    {
        return new Teacher(
            "Micke",
            "Svensson",
            "0704567890",
            "890101-5634",
            "glen gatan 7",
            "43345",
            "Göteborg",
            "Web utveckling"
        );
    }

    public static Teacher DataScience()
    {
        return new Teacher(
            "Alice",
            "Karlsson",
            "070543210",
            "760202-7678",
            "högatan 9",
            "28321",
            "Malmö",
            "Datavetenskap"
        );
    }

    public static Teacher JavaScript()
    {
        return new Teacher(
            "Harald",
            "Johnsson",
            "070543210",
            "700202-3455",
            "Elm St 2",
            "54321",
            "Malmö",
            "JavaScript"
        );
    }

    /* Tostring method */
    public override string ToString()
    {
        return $"{base.ToString()}, Expertis: {ExpertiseArea}";
    }
}
