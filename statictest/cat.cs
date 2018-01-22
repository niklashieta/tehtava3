using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statictest
{
    class cat
    {
        private static int instances = 0;

        public cat()
        {
            instances++;
        }
        ~cat()
        {
            instances--;
        }
        public static int CatCount()
        {
            return instances;
        }
    }
}
