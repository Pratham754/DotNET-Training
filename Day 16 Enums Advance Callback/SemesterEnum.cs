namespace MyConsoleApp
{
    public enum Semesters
    {
        Semester1 = 1,
        Semester2 = 2
    }

    public enum Subjects
    {
        English = 1,
        Maths = 2,
        Physics = 3,
        Python = 4,
        SoftSkills = 5
    }

    public class SemesterEnum
    {
        public static void Main()
        {
            int[,] semsub = new int[2, 6];
            semsub[0, 0] = (int)Semesters.Semester1;
            semsub[0, 1] = (int)Subjects.Maths;
            semsub[0, 2] = (int)Subjects.Python;
            semsub[0, 3] = (int)Subjects.Physics;
            semsub[0, 4] = (int)Subjects.SoftSkills;
            semsub[0, 5] = (int)Subjects.English;
            semsub[1, 0] = (int)Semesters.Semester2;
            semsub[1, 1] = (int)Subjects.Maths;
            semsub[1, 2] = (int)Subjects.Python;
            semsub[1, 3] = (int)Subjects.Physics;
            semsub[1, 4] = (int)Subjects.SoftSkills;
            semsub[1, 5] = (int)Subjects.English;

            for (int i = 0; i < semsub.GetLength(0); i++)
            {
                Console.WriteLine($"Semester: {(Semesters)semsub[i, 0]}");
                Console.Write("Subjects: ");

                for (int j = 1; j < semsub.GetLength(1); j++)
                {
                    Console.Write($"{(Subjects)semsub[i, j]} ");
                }

                Console.WriteLine("\n");
            }
        }
    }
}