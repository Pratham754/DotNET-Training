using System;

class Controller
{
    static void Main()
    {
        try
        {
            // Call Service method
            Service.Process();
        }
        catch (Exception ex)
        {
            // Handle exception here
            Console.WriteLine($"Controller handled error: {ex.Message}");
        }
    }
}

class Service
{
    public static void Process()
    {
        try
        {
            // Call Repository method
            Repository.GetData();
        }
        catch (Exception ex)
        {
            // Catch, log and rethrow exception
            Console.WriteLine($"Service log: {ex.Message}");
            throw; // rethrow preserves original stack trace
        }
    }
}

class Repository
{
    public static void GetData()
    {
        // Throw an exception here
        throw new Exception("Database connection failed.");
    }
}