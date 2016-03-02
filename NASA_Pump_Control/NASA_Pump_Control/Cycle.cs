using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA_Pump_Control
{
    class Cycle
    {

        int[] cycle_array = new int[2];


        public Cycle(int on, int off)
        {
            cycle_array[0] = on;
            cycle_array[1] = off;
        }
        public int[] get_times()
        {
            return cycle_array;
        }

        public int get_time_total()
        {
            return cycle_array[0] + cycle_array[1];
        }
       
        
    }
}
