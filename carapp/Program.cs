using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carapp
{
    class Program
    {
        static void Main(string[] args)
        {
            car Datsun = new car();
            Datsun.speed = 100;
            Console.WriteLine("datsun speed is: " + Datsun.speed);
            Datsun.speed = 500;
            Console.WriteLine("datsun speed is: " + Datsun.speed);
        }
    }
}
