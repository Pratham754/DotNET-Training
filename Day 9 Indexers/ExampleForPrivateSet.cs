// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace LearningCSharp
// {
//     public class YoungProfessional
//     {
//         public YoungProfessional()
//         {
            
//         }
//         public YoungProfessional(string dob)
//         {
//             DateOfBirth = dob;
//         }

//         public int PersonalId { get; private set; }
//         public int RNo { get; set; }
//         public string DateOfBirth { get; private set; }

//         public string Name { get; set; }
        

//         public void SetDateOfBirth(string dateOfBirth)
//         {
//             DateOfBirth = dateOfBirth;
//         }

//     }

//     public class ExampleForPrivateSet
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello, World!");
//             YoungProfessional yp = new();
//         }
//     }
// }

// // can we use sealed class in abstract class
// // how can we hide the method from parent class to child class