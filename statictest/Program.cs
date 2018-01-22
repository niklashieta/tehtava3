using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statictest
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 0;
            string line = Console.ReadLine();
            bool result = Int64.TryParse(line, out number);
            if (result)
            {
                Console.WriteLine("success: " + number);
            }
            else
            {
                Console.WriteLine("NAN!");
            }
            
            
            
            
            
            /*int i = int.MaxValue;
            double d = double.MaxValue;
            float a = float.MaxValue;
            Console.WriteLine("i: " + i);
            Console.WriteLine(d);
            Console.WriteLine(a);*/
            
            
            /*int i = 54321;
            long n = i;
            byte c = (byte)n;
            double d = 654321.6987;
            int i = Convert.ToInt32(d);
            Console.WriteLine("i: " + i);*/
        }
    }
}
