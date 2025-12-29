namespace Sciencelib
{
    public class AeroDynamics
    {
        public AeroDynamics()
        {
            double velocity = 250.0;
            double density = 1.225;
            double area = 30.0;
            double dragCoefficient = 0.32;
            double dragForce = 0.5 * density * velocity * velocity * area * dragCoefficient;
            Console.WriteLine($"Drag Force is {dragForce} N");
        }

    }
}
