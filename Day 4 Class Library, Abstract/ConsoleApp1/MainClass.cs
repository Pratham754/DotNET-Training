using Mathslib;
using MathsLib;
using Sciencelib;
namespace ConsoleApp1
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            //NormalMaths maths = new();
            //AeroDynamics aero = new();

            //MathLogin mathLogin = new();
            //ScienceLogin scienceLogin = new();

            Payment payment = new UPIPayment(300,"pratham@ptsbi");
            payment.Pay();
            payment.PrintReceipt();
            Document doc = new();
            doc.Print();
        }
    }
}
