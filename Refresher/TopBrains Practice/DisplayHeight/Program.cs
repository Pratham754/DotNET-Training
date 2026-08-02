using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayHeight
{
    public class Program
    {
        public string Height(int height)
        {
            if (height < 150) return "Short";
            else if (height >= 150 && height < 180) return "Average";
            else return "Tall";
        }
        static void Main(string[] args)
        {
            Program pObj = new Program();
            Console.WriteLine(pObj.Height(170));
        }
    }
}
