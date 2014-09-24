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
            // Code to be ran over and over until the user presses esc
            do
            {
                int numberOfSalaries = ReadInt("Ange antal löner att mata in: ");
                if (numberOfSalaries < 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDu måste mata in minst två löner för att kunna göra en beräkning\n");
                    Console.ResetColor();
                }
                else
                {
                    ProcessSalaries(numberOfSalaries);
                }
                // Display message at end of program
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nTryck på valfri tangent för att göra en ny uträkning. ESC avslutar.\n");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }

        // Method to recieve input from the user in the form of an integer
        static int ReadInt(string prompt)
        {
            int value;
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    value = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! Felaktigt belopp. Ange ett heltal!\n");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nTalet är för stort, välj ett mindre tal.\n");
                    Console.ResetColor();
                }
            }
            return value;
        }

        // Method that process the salaries
        static void ProcessSalaries(int count)
        {
            // Declaring variables
            int[] salaries = new int[count];
            int[] sortedSalaries = new int[count];
            double averageSalary;
            int spreadSalary;
            double medianSalary;
            int middle;

            // Asking for the salaries and inserts them in the array salaries
            for (int i = 0; i < salaries.Length; i++)
            {
                salaries[i] = ReadInt(string.Format("Ange lön nummer {0}: ", i + 1));
            }

            // Adding all integers in salaries together and dividing by number of salaries
            averageSalary = Convert.ToDouble(salaries.Sum()) / salaries.Length;

            // Calculating the spread between the largest and smallest salary
            spreadSalary = salaries.Max() - salaries.Min();

            // Creates a copy of salaries and sorts it in a min -> max order
            sortedSalaries = (int[])salaries.Clone();
            Array.Sort(sortedSalaries);

            // Calculating the median value
            middle = sortedSalaries.Length / 2;
            if ((sortedSalaries.Length % 2) != 0)
            {
                medianSalary = sortedSalaries[sortedSalaries.Length / 2];
            }
            else
            {
                medianSalary = (sortedSalaries[middle] + sortedSalaries[middle - 1]) / 2d;
            }

            // Print data in console            
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Medianlön: {0, 19:c0}", medianSalary);
            Console.WriteLine("Medellön: {0, 20:c0}", averageSalary);
            Console.WriteLine("Lönespridning: {0, 15:c0}", spreadSalary);
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < salaries.Length; i++)
            {
                Console.Write("{0, 8}", salaries[i]);
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
                if (i == salaries.Length - 1)
                {
                    Console.WriteLine();
                }
            }
            


        }

    }
}
