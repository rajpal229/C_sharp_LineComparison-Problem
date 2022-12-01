using System.Data.SqlTypes;
using System.Transactions;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem");
            Console.WriteLine("\n");
            Console.WriteLine("Enter End points of First Line");
            Console.WriteLine("Enter x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of Line is: " + length1);
            Console.WriteLine("\n");
            Console.WriteLine("Enter End points of Second Line");
            Console.WriteLine("Enter x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x4: ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y4: ");
            int y4 = Convert.ToInt32(Console.ReadLine());
            double length2 = Math.Sqrt(Math.Pow((x3 - x4), 2) + Math.Pow((y3 - y4), 2));
            Console.WriteLine("Length of Line is: " + length2);
            if (length1 == length2)
            {
                Console.WriteLine("Both Line are equal in Length");
            }
            else if (length1 > length2)
            {
                Console.WriteLine("Line1 is Longer");
            }
            else
            {
                Console.WriteLine("Line2 is Longer");
            }
        }
    }
}