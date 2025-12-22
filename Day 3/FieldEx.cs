namespace MyConsoleApp.FieldEx
{
    public class Employee
    {
        private int id;

        public int Id
        {
            set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    id = 0;
                    throw new System.ArgumentException("Employee Id must be greater than zero.");
                }
            }
        }

        public string DisplayEmpDetails()
        {
            return $"Employee Id: {id}";
        }
    }
}