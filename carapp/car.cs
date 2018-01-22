using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carapp
{
    class car
    {
        private int MaxSpeed = 300;
        public int speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value <= MaxSpeed) speed = value;
                else speed = MaxSpeed;
            }
        }
        public string merkki
        {
           
        }
    }
}
