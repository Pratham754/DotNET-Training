using System;

public class DatabaseConnection
{
    public static void Main()
    {
        bool connectionOpen = false;
        try
        {
            // 1. Open connection
            connectionOpen = true;
            Console.WriteLine("Database connection opened.");

            // 2. Simulate operation failure
            throw new Exception("Database operation failed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            // 3. Ensure connection is closed properly
            if (connectionOpen)
            {
                connectionOpen = false;
                Console.WriteLine("Database connection closed.");
            }
        }
    }
}