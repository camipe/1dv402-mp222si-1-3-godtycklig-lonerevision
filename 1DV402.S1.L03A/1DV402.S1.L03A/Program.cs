using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1.L03A
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadInt("Ange antal löner att mata in: ");

        }

        static int ReadInt(string prompt)
        {
            Console.Write(prompt);
            int value = int.Parse(Console.ReadLine());
            return value;
        }



    }
}
