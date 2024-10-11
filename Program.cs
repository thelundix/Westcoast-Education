namespace Westcoast_First.Models;
class Program
{
    static void Main()
    {
        // Create administrator and educational leader
        var admin = Administrator.CreateAdministrator();
        var leader = EducationalLeader.CreateEducationalLeader();

        // Create teachers
        var webDevelopmentTeacher = Teacher.WebDevelopment();
        var dataScienceTeacher = Teacher.DataScience();
        var javaScriptTeacher = Teacher.JavaScript();

        // Create a list of courses
        var courses = new List<Course>
        {
            Course.CreateWebDevelopmentCourse(webDevelopmentTeacher),
            Course.CreateAdvancedJavaScriptCourse(javaScriptTeacher),
            Course.CreateDataScienceCourse(dataScienceTeacher),
        };

        // Assign courses to teachers
        webDevelopmentTeacher.AddResponsibleCourse(courses[0]);
        javaScriptTeacher.AddResponsibleCourse(courses[1]);
        dataScienceTeacher.AddResponsibleCourse(courses[2]);

        // Create list of students
        var students = new List<Student> { Student.CreateJane(), Student.CreatePelle() };

        // Assign students to courses
        courses[0].AddStudent(students[0]);
        courses[1].AddStudent(students[1]);
        courses[1].AddStudent(students[0]);
        courses[2].AddStudent(students[0]);

        // Write courses to JSON file
        var path = Path.Combine(Environment.CurrentDirectory, "data", "courses.json");
        Storage.WriteJson(path, courses);

        // Run the menu from Menu.cs
        Menu.RunMenu(
            courses[0],
            courses[1],
            courses[2],
            webDevelopmentTeacher,
            javaScriptTeacher,
            dataScienceTeacher,
            leader,
            admin
        );
    }
}
