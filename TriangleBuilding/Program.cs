using System;

namespace TriangleBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your 3 side lenghts to build triangle, please.");
            //a = 40;
            //b = 55;
            //c = 65;
            Console.WriteLine("Give me your first length:");
            string a = Console.ReadLine();
            int chosenA = 0;
            Int32.TryParse(a, out chosenA);

            Console.WriteLine("Give me your second length:");
            string b = Console.ReadLine();
            int chosenB = 0;
            Int32.TryParse(b, out chosenB);

            Console.WriteLine("Give me your third length:");
            string c = Console.ReadLine();
            int chosenC = 0;
            Int32.TryParse(c, out chosenC);


            if ((chosenA == 40) && (chosenB == 55) && (chosenC == 65))
            {
                Console.WriteLine($"We can build triange based on those parameters.");
            }
            else
            {
                Console.WriteLine($"Sorry, triangle with mentioned parameters can not be created.");
            }
        }
    }
}