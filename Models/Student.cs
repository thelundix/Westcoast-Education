namespace Westcoast_First.Models;

    public class Student : Person
    {
        /* Constructor */
        public Student(
            string firstName,
            string lastName,
            string phoneNumber,
            string socialSecurityNumber,
            string address,
            string postalCode,
            string city
        )
            : base(
                firstName,
                lastName,
                phoneNumber,
                socialSecurityNumber,
                address,
                postalCode,
                city
            ) { }

        /* Static methods */
        public static Student CreateJane()
        {
            return new Student(
                "Lisa",
                "Bengtsson",
                "0703654321",
                "980101-5678",
                "vatten gatan 97",
                "23287",
                "Kalmar"
            );
        }

        public static Student CreatePelle()
        {
            return new Student(
                "Pelle",
                "Larsson",
                "0706554321",
                "950101-4578",
                "Apelsin gatan 3",
                "26575",
                "Malmö"
            );
        }

        /* Tostring method */
        public override string ToString()
        {
            return base.ToString();
        }
    }

