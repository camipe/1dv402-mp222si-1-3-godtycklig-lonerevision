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
            int numberOfSalaries = ReadInt("Ange antal löner att mata in: ");

            ProcessSalaries(numberOfSalaries);

        }

        static int ReadInt(string prompt)
        {
            Console.Write(prompt,);
            int value = int.Parse(Console.ReadLine());
            return value;
        }

        static void ProcessSalaries(int count)
        {
            // Declaring variables
            int[] salaries = new int[count];
            int[] sortedSalaries = new int[count];
            double averageSalary;            
            int spreadSalary;
            double medianSalary;


            // Asking for the salaries and inserts them in the array salaries
            for (int i = 0; i < salaries.Length; i++)
            {
                salaries[i] = ReadInt(string.Format("Ange lön nummer {0}: ", i + 1));
            }

            // Adding all integers in salaries together
            averageSalary = salaries.Sum();

            // Calculating the spread between the largest and smallest salary
            spreadSalary = salaries.Max() - salaries.Min();

            // Creates a copy of salaries and sorts it in a min -> max order
            sortedSalaries = (int[])salaries.Clone();
            Array.Sort(sortedSalaries);



        }

    }
}
