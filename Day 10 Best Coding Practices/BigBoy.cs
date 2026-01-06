using System.Collections;

namespace MyconsoleApp
{
    interface IDisposable
    {
        public void Dispose();
    }
    public class BigBoy : IDisposable
    {
        public BigBoy()
        {

        }

        public ArrayList? Names { get; set; }

        public void Dispose()
        {
            Names = null;
        }

        ~BigBoy()
        {
            Names = null;
        }
    }

    public class Program
    {
        public static void Main()
        {
            BigBoy bigBoy = new();
            try
            {
                bigBoy.Names = [];
                for (int i = 0; i < 10; i++)
                {
                    bigBoy.Names.Add(i.ToString());
                }
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                bigBoy.Dispose();
            }
        }
    }
}
