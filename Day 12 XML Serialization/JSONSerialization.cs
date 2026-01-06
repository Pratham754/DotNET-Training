using System;
using System.Collections.Generic;
using System.Text.Json;

public class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<int>? Marks { get; set; }
}
class Program
{
    static void Main()
    {        
        // OBJECT → JSON (Serialization)
        Student student = new()
        {
            Id = 1,
            Name = "Pratham",
            Marks = [ 85, 90, 88 ]
        };

        string jsonData = JsonSerializer.Serialize(student);
        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(jsonData);

        // JSON → OBJECT (Deserialization)
        Student deserializedStudent = JsonSerializer.Deserialize<Student>(jsonData);

        Console.WriteLine("\nDeserialized Object:");
        Console.WriteLine($"Id: {deserializedStudent.Id}");
        Console.WriteLine($"Name: {deserializedStudent.Name}");
        Console.WriteLine("Marks:");
        foreach (var mark in deserializedStudent.Marks)
        {
            Console.WriteLine(mark);
        }
    }
}