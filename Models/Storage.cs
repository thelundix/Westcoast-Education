using System.Text.Encodings.Web;
using System.Text.Json;
namespace Westcoast_First.Models;

public class Storage
{
    // JSON serializer options for consistent formatting
    private static JsonSerializerOptions _options = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true,
    };

    // Method to write a list of courses to a JSON file
    public static void WriteJson(string path, List<Course> courses)
    {
        var json = JsonSerializer.Serialize(courses, _options);
        File.WriteAllText(path, json);
    }

    // Method to read a list of courses from a JSON file
    public static List<Course>? ReadJson(string path)
    {
        var json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<Course>>(json, _options);
    }
}
