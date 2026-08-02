using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestInteger
{
    public class Program
    {
        public int LargestInteger(int a,int b,int c)
        {
            return a > (b > c ? b : c) ? a:(b>c?b:c);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.LargestInteger(10, 5, 20));
        }
    }
}
