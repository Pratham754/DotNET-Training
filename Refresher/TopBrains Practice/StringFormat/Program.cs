using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public record Student(string Name, int Score);

public class Program
{
    public static string GetStudentsJson(string[] items, int minScore)
    {
        List<Student> students = new List<Student>();

        foreach (string item in items)
        {
            string[] parts = item.Split(':');

            Student student = new Student(
                parts[0],
                int.Parse(parts[1])
            );

            if (student.Score >= minScore)
            {
                students.Add(student);
            }
        }

        students = students
            .OrderByDescending(s => s.Score)
            .ThenBy(s => s.Name)
            .ToList();

        return JsonSerializer.Serialize(students);
    }

    public static void Main()
    {
        string[] items =
        {
            "Alice:90",
            "Bob:75",
            "Charlie:90",
            "David:60"
        };

        int minScore = 80;

        string json = GetStudentsJson(items, minScore);

        Console.WriteLine(json);
    }
}