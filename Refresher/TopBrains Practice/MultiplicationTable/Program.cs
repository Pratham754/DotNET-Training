using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    public class Program
    {
        public int[] MultiplyTable(int n,int upto)
        {
            int[] result = new int[n];
            for(int i = 0; i < n; i++)
            {
                result[i] = n * (i + 1);
            }
            return result;
        }
        static void Main(string[] args)
        {
            Program pObj = new Program();
            int[] table = pObj.MultiplyTable(3,5);
            foreach(int i in table)
            {
                Console.WriteLine(i);
            }
        }
    }
}
