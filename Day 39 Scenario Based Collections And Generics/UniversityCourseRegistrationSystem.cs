using System;
using System.Collections.Generic;
using System.Linq;

// Base constraints
public interface IStudent
{
    int StudentId { get; }
    string Name { get; }
    int Semester { get; }
}

public interface ICourse
{
    string CourseCode { get; }
    string Title { get; }
    int MaxCapacity { get; }
    int Credits { get; }
}

// 1. Generic enrollment system
public class EnrollmentSystem<TStudent, TCourse>
    where TStudent : IStudent
    where TCourse : ICourse
{
    private Dictionary<TCourse, List<TStudent>> _enrollments = new();
    
    // TODO: Enroll student with constraints
    public bool EnrollStudent(TStudent student, TCourse course)
    {
        // Rules:
        // - Course not at capacity
        if (!_enrollments.ContainsKey(course)) _enrollments[course] = new List<TStudent>();
        var enrolledList = _enrollments[course];
        if (enrolledList.Count >= course.MaxCapacity) return false;

        // - Student not already enrolled
        if (enrolledList.Any(s => s.StudentId == student.StudentId)) return false;

        // - Student semester >= course prerequisite (if any)
        if (course is LabCourse lab && student.Semester < lab.RequiredSemester) return false;

        // - Return success/failure with reason
        enrolledList.Add(student);
        return true;
    }
    
    // TODO: Get students for course
    public IReadOnlyList<TStudent> GetEnrolledStudents(TCourse course)
    {
        // Return immutable list
        if (!_enrollments.TryGetValue(course, out var list)) return new List<TStudent>().AsReadOnly();
        return list.AsReadOnly();
    }
    
    // TODO: Get courses for student
    public IEnumerable<TCourse> GetStudentCourses(TStudent student)
    {
        // Return courses student is enrolled in
        return _enrollments.Where(kvp => kvp.Value.Any(s => s.StudentId == student.StudentId))
                          .Select(kvp => kvp.Key);
    }
    
    // TODO: Calculate student workload
    public int CalculateStudentWorkload(TStudent student)
    {
        // Sum credits of all enrolled courses
        return GetStudentCourses(student).Sum(c => c.Credits);
    }
}

// 2. Specialized implementations
public class EngineeringStudent : IStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Semester { get; set; }
    public string Specialization { get; set; }
}

public class LabCourse : ICourse
{
    public string CourseCode { get; set; }
    public string Title { get; set; }
    public int MaxCapacity { get; set; }
    public int Credits { get; set; }
    public string LabEquipment { get; set; }
    public int RequiredSemester { get; set; } // Prerequisite
}

// 3. Generic gradebook
public class GradeBook<TStudent, TCourse>
{
    private Dictionary<(TStudent, TCourse), double> _grades = new();
    
    // TODO: Add grade with validation
    public void AddGrade(TStudent student, TCourse course, double grade)
    {
        // Grade must be between 0 and 100
        if (grade < 0 || grade > 100) return;
        // Student must be enrolled in course 
        // Note: Since this class lacks the EnrollmentSystem reference, 
        // we store the grade; validation logic would typically happen via the caller.
        _grades[(student, course)] = grade;
    }   
    
    // TODO: Calculate GPA for student
    public double? CalculateGPA(TStudent student)
    {
        // Weighted by course credits
        var studentGrades = _grades.Where(g => g.Key.Item1.Equals(student)).ToList();
        if (studentGrades.Count == 0) return null;

        double totalWeightedPoints = 0;
        int totalCredits = 0;

        foreach (var entry in studentGrades)
        {
            if (entry.Key.Item2 is ICourse c)
            {
                totalWeightedPoints += entry.Value * c.Credits;
                totalCredits += c.Credits;
            }
        }
        // Return null if no grades
        return totalCredits == 0 ? null : totalWeightedPoints / totalCredits;
    }
    
    // TODO: Find top student in course
    public (TStudent student, double grade)? GetTopStudent(TCourse course)
    {
        // Return student with highest grade
        var courseGrades = _grades.Where(g => g.Key.Item2.Equals(course)).ToList();
        if (!courseGrades.Any()) return null;

        var top = courseGrades.OrderByDescending(g => g.Value).First();
        return (top.Key.Item1, top.Value);
    }
}

// 4. TEST SCENARIO
public class Program
{
    public static void Main()
    {
        var system = new EnrollmentSystem<EngineeringStudent, LabCourse>();
        var gradeBook = new GradeBook<EngineeringStudent, LabCourse>();

        // a) Create 3 EngineeringStudent instances
        var s1 = new EngineeringStudent { StudentId = 101, Name = "Alice", Semester = 1 };
        var s2 = new EngineeringStudent { StudentId = 102, Name = "Bob", Semester = 3 };
        var s3 = new EngineeringStudent { StudentId = 103, Name = "Charlie", Semester = 5 };

        // b) Create 2 LabCourse instances with prerequisites
        var intro = new LabCourse { CourseCode = "L1", Title = "Intro", MaxCapacity = 2, Credits = 2, RequiredSemester = 1 };
        var adv = new LabCourse { CourseCode = "L2", Title = "Advanced", MaxCapacity = 5, Credits = 4, RequiredSemester = 4 };

        // c) Demonstrate:
        Console.WriteLine("--- Enrollment ---");
        Console.WriteLine($"Alice -> Intro: {system.EnrollStudent(s1, intro)}"); 
        Console.WriteLine($"Bob -> Intro: {system.EnrollStudent(s2, intro)}");
        Console.WriteLine($"Charlie -> Intro (Full): {system.EnrollStudent(s3, intro)}"); // Fail: Capacity
        Console.WriteLine($"Bob -> Advanced (Prereq): {system.EnrollStudent(s2, adv)}"); // Fail: Semester

        Console.WriteLine("\n--- Grades & Stats ---");
        gradeBook.AddGrade(s1, intro, 90);
        gradeBook.AddGrade(s2, intro, 80);

        Console.WriteLine($"Alice GPA: {gradeBook.CalculateGPA(s1):F2}");
        var top = gradeBook.GetTopStudent(intro);
        if (top.HasValue) Console.WriteLine($"Top Student: {top.Value.student.Name} ({top.Value.grade})");
    }
}