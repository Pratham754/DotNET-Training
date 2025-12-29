using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ConsoleApp1
{
    public interface IPrint
    {
        public void Print()
        {
            Console.WriteLine("Printing from interface");
        }
    }

    public class Document : IPrint
    {
        public int numberOfPages = 10;
        public void Print()
        {
            Console.WriteLine($"Printing document with {numberOfPages} pages.");
        }
    }
}
                    