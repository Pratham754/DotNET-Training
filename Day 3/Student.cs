using System;
namespace MyConsoleApp
{
    public class Student
    {
        #region Constructors
        public Student()
        {
            Id = 0;
            Name = string.Empty;
            Age = 18;
        }

        #endregion
        
        #region Fields
        public int Id;
        public string Name;
        public int Age;
        #endregion

        #region Methods
        /// <summary>
        /// Display student details
        /// </summary>
        /// <returns>Details of the student</returns>
        public void DisplayDetails()
        {
            Console.WriteLine($" Id: {Id}\n Name: {Name}\n Age: {Age}");
        }
        #endregion
    
    }
}