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
            int numberOfSalaries = ReadInt("Ange antal löner att mata in: ", 0);

            ProcessSalaries(numberOfSalaries);

        }

        static int ReadInt(string prompt, int var)
        {
            Console.Write(prompt, var);
            int value = int.Parse(Console.ReadLine());
            return value;
        }

        static void ProcessSalaries(int count)
        {
            int[] salaries = new int[count];

            for (int i = 0; i < salaries.Length; i++)
            {
                salaries[i] = ReadInt("Ange lön nummer {0}: ", i + 1);
            }
        }

    }
}
