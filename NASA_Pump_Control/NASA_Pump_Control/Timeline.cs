using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NASA_Pump_Control
{
    class Timeline
    {
        private DateTime time_default;

        public class Main_Timeline : Timeline
        {
            int total_days;
            /// <summary>
            /// Constructor for Main Timeline
            /// The Main timeline will contain the timelines of the specific pumps.
            /// </summary>
            public Main_Timeline(Pump_Timeline Pump_1, int days)
            {
                total_days = days;
            }

            public void add_pump_timeline(Pump_Timeline Pump_to_add)
            {

            }

            /// <summary>
            /// This will begin the pumps
            /// </summary>
            public void main_start()
            {
                DateTime time_begin = DateTime.Now;
                DateTime time_end = time_begin.AddDays(total_days);

                do
                {
                    //Main timeline run through
                }
                while (DateTime.Compare(DateTime.Now,time_end) < 0); //Compares Now to the time that is desired to end
            }
        }

        public class Pump_Timeline
        {
            private DateTime time_start;
            private int total_runtime;
            LinkedList<Cycle> pump_list = new LinkedList<Cycle>();


            public Pump_Timeline(Cycle _cycle, int iterations)
            {
                for(int i = 1; i < iterations; i++)
                {
                    pump_list.AddFirst(_cycle);
                }
            }

            public int get_runtime_total()
            {
                int total = 0;
               for(LinkedListNode<Cycle> node = pump_list.First; node != null;)
                {
                    total = node.Value.get_time_total(); // gets total time for given cycle in the list;
                    node = node.Next;
                }
                total_runtime = total;

                return total;
            }

            


        }
    }



}
