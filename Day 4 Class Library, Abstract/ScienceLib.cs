namespace ScienceLib;

public class Science
{
    public void CalculateSpeed(double distance, double time)
    {
        if (time <= 0)
            throw new ArgumentException("Time must be greater than zero");
        
        Console.WriteLine(distance / time);
    }
}
