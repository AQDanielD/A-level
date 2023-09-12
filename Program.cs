using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Width = 0;
            double Height = 0;

            const double max_width = 5.0;

            Console.Write("Enter Width of the Window: ");
            Width = double.Parse(Console.ReadLine());
            if (Width > max_width)
            {
                Console.WriteLine("Too Wide");
                Width = max_width;
            }
        }
    }
}
