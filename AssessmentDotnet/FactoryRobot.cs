using System;

#region Custom Exception
/// <summary>
/// Represents robot safety validation errors.
/// </summary>
public class RobotSafetyException(string message) : Exception(message)
{
}
#endregion

#region RobotHazardAuditor
/// <summary>
/// Evaluates hazard risk for factory robots.
/// </summary>
public class RobotHazardAuditor
{
    #region CalculateHazardRisk
    /// <summary>
    /// Calculates the robot hazard risk score.
    /// </summary>
    public static double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
    {
        // Validate arm precision
        if (armPrecision < 0.0 || armPrecision > 1.0)
            throw new RobotSafetyException("Error:  Arm precision must be 0.0-1.0");

        // Validate worker density
        if (workerDensity < 1 || workerDensity > 20)
            throw new RobotSafetyException("Error: Worker density must be 1-20");

        // Determine machine risk factor
        var machineRiskFactor = machineryState switch
        {
            "Worn" => 1.3,
            "Faulty" => 2.0,
            "Critical" => 3.0,
            _ => throw new RobotSafetyException("Error: Unsupported machinery state"),
        };

        // Calculate and return hazard risk
        double hazardRisk = ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);
        return hazardRisk;
    }
    #endregion
}
#endregion

#region Program
/// <summary>
/// Program entry point.
/// </summary>
class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
            double armPrecision = double.TryParse(Console.ReadLine());

            Console.WriteLine("Enter Worker Density (1 - 20):");
            int workerDensity = int.TryParse(Console.ReadLine());

            Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
            string machineryState = Console.ReadLine();

            RobotHazardAuditor auditor = new();
            double risk = RobotHazardAuditor.CalculateHazardRisk(armPrecision, workerDensity, machineryState);

            Console.WriteLine("Robot Hazard Risk Score: " + risk);
        }
        catch (RobotSafetyException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
#endregion