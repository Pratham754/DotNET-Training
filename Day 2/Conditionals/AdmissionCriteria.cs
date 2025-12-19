using System;

namespace Github
{
    public class AdmissionCriteria
    {
        static void Main()
        {
            Console.Write("Enter marks for Mathematics, Physics and Chemistry separated by spaces: ");
            string? input = Console.ReadLine();
            string[] inputs = input?.Split(' ') ?? [];

            if (inputs.Length == 3 && int.TryParse(inputs[0], out int math) && int.TryParse(inputs[1], out int phys) && int.TryParse(inputs[2], out int chem))
            {
                int total = math + phys + chem;

                if (math >= 65 && phys >= 55 && chem >= 50 && (total >= 180 || (math + phys) >= 140))
                {
                    Console.WriteLine("Eligible for admission");
                }
                else
                {
                    Console.WriteLine("Not eligible for admission");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}