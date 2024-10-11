using System.Text.Json.Serialization;
namespace Westcoast_First.Models;

    public class Course
    {
        /* Properties */
        public int CourseNumber { get; private set; }
        public string Title { get; private set; }
        public int LengthInWeeks { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public bool IsClassroomCourse { get; private set; }

        // Ignore student property during serialization
        [JsonIgnore]
        // aggregation.
        public List<Student> Students { get; private set; }

        // Ignore Teacher property during serialization
        [JsonIgnore]
        //composition
        public Teacher Teacher { get; private set; }

        /* Constructor */
        public Course(
            int courseNumber,
            string title,
            int lengthInWeeks,
            DateTime startDate,
            bool isClassroomCourse,
            Teacher teacher
        )
        {
            CourseNumber = courseNumber;
            Title = title;
            LengthInWeeks = lengthInWeeks;
            StartDate = startDate;
            EndDate = startDate.AddDays(lengthInWeeks * 7); // Calculate the end date based on length
            IsClassroomCourse = isClassroomCourse;
            Teacher = teacher;
            Students = new List<Student>();
        }

        /* Methods */
        public void AddStudent(Student student)
        {
            // Avoid adding duplicates
            if (!Students.Contains(student))
            {
                Students.Add(student);
            }
        }

        // Static methods to create predefined courses
        public static Course CreateWebDevelopmentCourse(Teacher teacher)
        {
            return new Course(232, "Introduktion webutveckling", 4, DateTime.Now, false, teacher);
        }

        /* Static Factory Methods */
        public static Course CreateAdvancedJavaScriptCourse(Teacher teacher)
        {
            return new Course(
                134,
                "Avancerad Javascript",
                10,
                DateTime.Now.AddDays(30),
                true, // class room or not
                teacher
            );
        }

        public static Course CreateDataScienceCourse(Teacher teacher)
        {
            return new Course(
                103,
                "Datavetenskap grund",
                20, // Length in Weeks
                DateTime.Now.AddDays(65),
                true,
                teacher
            );
        }

        /* Tostring method */
        public override string ToString()
        {
            return $"{Title} (Kurs Nummer: {CourseNumber}, Längd: {LengthInWeeks} Veckor, Start: {StartDate.ToShortDateString()}, Slut: {EndDate.ToShortDateString()}, Typ: {(IsClassroomCourse ? "Klassrum" : "Distans")})";
        }
    }
