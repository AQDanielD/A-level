using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace Variables
{



    public class Program
    {


        public class Width
        {
            public string name = "Width";
            public double measurement = 0;
            public double max = 5;
            public double min = 0.5;
            public double defaultVal = 2.75;
        }

        public class Height
        {
            public string name = "Height";
            public double measurement = 1;
            public double max = 3;
            public double min = 0.75;
            public double defaultVal = 1.875;
        }

        public static double DataTypeCheck(string root)
        {
            Width Width = new Width();
            Height Height = new Height();

            int i = 0;
            bool flag = false;
            double value = 0;

            if (root.ToLower() == "height")
            {
                while (i < 3 && !flag)
                {
                    try
                    {
                        Console.Write($"Enter the height of the Window (max-3, min-0.75): ");
                        value = double.Parse(Console.ReadLine());
                        if (value <= 3 && value >= 0.75)
                        {
                            Height.measurement = value;
                            flag = true;
                        }
                    }
                    catch (Exception e)
                    {
                        flag = false;
                        Console.WriteLine("Please enter either a whole number or a decimal");
                    }
                    i++;
                }

                if (i == 3)
                {
                    Console.WriteLine($"You have failed to enter a suitable size, size has been set to default ({Height.defaultVal}).");
                    value = Height.defaultVal;
                    Thread.Sleep(3000);
                }
            }
            else
            {
                while (i < 3 && !flag)
                {
                    try
                    {
                        Console.Write($"Enter the Width of the Window (max-3, min-0.75): ");
                        value = double.Parse(Console.ReadLine());
                        if (value <= 3 && value >= 0.75)
                        {
                            Width.measurement = value;
                            flag = true;
                        }
                    }
                    catch (Exception e)
                    {
                        flag = false;
                        Console.WriteLine("Please enter either a whole number or a decimal");
                    }
                    i++;
                }

                if (i == 3)
                {
                    Console.WriteLine($"You have failed to enter a suitable size, size has been set to default ({Width.defaultVal}).");
                    value = Width.defaultVal;
                    Thread.Sleep(3000);
                }
            }

            return value;
        }



        public static void Main(string[] args)
        {

            double Height = DataTypeCheck("Height");
            double Width = DataTypeCheck("Width");

            Console.WriteLine($"length of the wood {2 * (Width * Height) * 3.25}-Feet");
            Console.WriteLine($"Area of glass {2 * (Width * Height)}-square meters");
            Console.ReadKey();


        }
    }
}
