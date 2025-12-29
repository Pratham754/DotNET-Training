using System;
using System.Collections.Generic;
using System.Text;
using ExamSchedule.Model;

namespace ExamSchedule.Data
{
    public static class DataBank
    {
        private static List<Student> Students = [];

        static DataBank()
        {
            Students.Add(new Student { Id = 1, Name = "Alice1" });
            Students.Add(new Student { Id = 2, Name = "Alice2" });
            Students.Add(new Student { Id = 3, Name = "Alice3" });
            Students.Add(new Student { Id = 4, Name = "Alice4" });
        }

        public static List<Student> GetStudents()
        {
            return Students;
        }
    }
}