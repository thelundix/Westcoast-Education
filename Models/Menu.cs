namespace Westcoast_First.Models;

public class Menu
{
    /* Main method to run the menu */
    public static void RunMenu(
        Course webDev,
        Course jsCourse,
        Course dataScienceCourse,
        Teacher webDevelopmentTeacher,
        Teacher javaScriptTeacher,
        Teacher dataScienceTeacher,
        EducationalLeader leader,
        Administrator admin
    )
    {
        // Create a list of courses
        var courses = new List<Course> { webDev, jsCourse, dataScienceCourse };
        // Path to the JSON file storing course data
        var path = Path.Combine(Environment.CurrentDirectory, "data", "courses.json");

        // Flag to control the while loop
        bool continueRunning = true;
        while (continueRunning)
        {
            DisplayMenu();
            string choice = Console.ReadLine() ?? "";

            Console.Clear(); // Clear the console before displaying options

            // Handle the users choice
            switch (choice)
            {
                case "1":
                    PrintDetails(webDev, webDevelopmentTeacher, leader, admin);
                    break;
                case "2":
                    PrintDetails(jsCourse, javaScriptTeacher, leader, admin);
                    break;
                case "3":
                    PrintDetails(dataScienceCourse, dataScienceTeacher, leader, admin);
                    break;
                case "4":
                    ReadAndPrintCoursesFromJson(path);
                    break;
                case "5":
                    continueRunning = false; // Exit the loop
                    continue;
                default:
                    Console.WriteLine("Ogiltigt val! Välj ett giltigt alternativ.");
                    break;
            }

            // Save the current state of courses to JSON after any menu action
            Storage.WriteJson(path, courses);

            if (continueRunning)
            {
                // Wait for user to press a key before returning to the menu
                Console.WriteLine("\nTryck på valfri tagent för att retunera till menyn...");
                Console.ReadKey();
            }
        }
    }

    // Method to display the menu options
    private static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Välj ett alternativ:");
        Console.WriteLine("1. Visa webbutvecklings kurs");
        Console.WriteLine("2. Visa avancerad JavaScript kurs");
        Console.WriteLine("3. Visa DataVetenskap kurs");
        Console.WriteLine("4. Ladda och visa kurser från JSON");
        Console.WriteLine("5. Avsluta");
        Console.Write("Ange ditt valnummer: ");
    }

    // Method to print course and teacher details
    private static void PrintDetails(
        Course course,
        Teacher teacher,
        EducationalLeader leader,
        Administrator administrator
    )
    {
        Console.WriteLine("=== Kurs Information ===");
        Console.WriteLine(course);
        Console.WriteLine("=== Lärar Information ===");
        Console.WriteLine(teacher);
        Console.WriteLine("=== Utbildnings Ledare ===");
        Console.WriteLine(leader);
        Console.WriteLine("=== Administratör ===");
        Console.WriteLine(administrator);
        Console.WriteLine("=== Studenter ===");
        foreach (var student in course.Students)
        {
            Console.WriteLine(student);
        }
    }

    // Method to read and print courses from a JSON file
    private static void ReadAndPrintCoursesFromJson(string path)
    {
        try
        {
            var courses = Storage.ReadJson(path);

            if (courses == null)
            {
                Console.WriteLine("Det gick inte att läsa in kurser från JSON.");
                return;
            }

            Console.WriteLine("=== Kurser laddade från JSON ===");
            foreach (var course in courses)
            {
                if (course == null)
                {
                    Console.WriteLine("Stötte på en nollkurs.");
                    continue;
                }

                Console.WriteLine(course);
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }
    }
}
