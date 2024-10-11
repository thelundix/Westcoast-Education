namespace Westcoast_First.Models;

    public class EducationalLeader : Teacher
    {
        /* Properties */
        public DateTime EmploymentDate { get; set; }

        /* constructor */
        public EducationalLeader(
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
                expertiseArea
            )
        {
            EmploymentDate = employmentDate;
        }

        /* Static Factory Methods */
        public static EducationalLeader CreateEducationalLeader(
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
        {
            return new EducationalLeader(
                firstName,
                lastName,
                phoneNumber,
                socialSecurityNumber,
                address,
                postalCode,
                city,
                expertiseArea,
                employmentDate
            );
        }

        public static EducationalLeader CreateEducationalLeader()
        {
            return new EducationalLeader(
                "Sven",
                "eriksson",
                "0702654321",
                "900101-5678",
                "Apelsin gatan 2",
                "21776",
                "Stockholm",
                "Kommunikation",
                new DateTime(1996, 5, 2)
            );
        }

        /* Tostring method */
        public override string ToString()
        {
            return $"{base.ToString()}, Anställnings datum: {EmploymentDate.ToShortDateString()}";
        }
    }
