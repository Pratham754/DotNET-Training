//
//associate id name rank, validate not empty , check input, give list of invalid inserts, like no name or no rank or no id and combine them into one message

namespace MyConsoleApp.CallAssociate
{
    public class Associate
    {
        public static void Main(string[] args)
        {
            try
            {
                CallAssociate associate = new(0, "", "CEO");
                CallAssociate associate2 = new(11,"Pratham","Trainee");

                // Console.WriteLine(associate.DisplayDetails());
                Console.WriteLine(associate2.DisplayDetails());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Invalid Inputs: " + ex.Message);
            }
        }
    }
}