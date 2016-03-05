using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NASA_Pump_Control
{
    class Timeline
    {
        

        public class Main_Timeline : Timeline
        {
            int total_days;
            LinkedList<Pump_Timeline> pump_col = new LinkedList<Pump_Timeline>();
            DateTime time_begin = DateTime.Now;
            DateTime time_end;
            static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

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
                pump_col.AddLast(Pump_to_add);
            }

            /// <summary>
            /// This will begin the pumps
            /// </summary>
            public void main_initialize()
            {
                time_begin = DateTime.Now;
                time_end = time_begin.AddDays(total_days);

                LinkedList<Pump_Timeline> temp = new LinkedList<Pump_Timeline>();

                temp = sort_start_time(pump_col);

                pump_col = temp;

                do
                {

                    //Main timeline run through
                }
                while (DateTime.Compare(DateTime.Now,time_end) < 0); //Compares Now to the time that is desired to end
            }
      

            // This is the method to run when the timer is raised.
            private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
            {
                myTimer.Enabled = false;
                DateTime now_time = DateTime.Now;
                long elapsed = now_time.Ticks - time_begin.Ticks;

                for(LinkedListNode<Pump_Timeline> node = pump_col.First; node != null;)
                {
                    int cycle_time_total = node.Value.get_next_cycle().Value.get_time_total();
                    int cycle_multiplier = node.Value.get_remove_count();
                    long timeline_start = node.Value.get_Start();

                    long timeline_end = node.Value.get_runtime_total();
                    int cycle_time_on = node.Value.get_next_cycle().Value.get_times()[0];


                    //All Pump on Scenarios
                    if (elapsed ==  timeline_start || elapsed == timeline_start + cycle_time_total*cycle_multiplier)
                    {
                        node.Value.get_serial().pump_on();
                    }
                    //All Pump off Scenarios
                    if (elapsed == timeline_end || elapsed == cycle_time_on * cycle_multiplier)
                    {
                        node.Value.get_serial().pump_off();
                        node.Value.remove_cycle();

                    }
                }

                if (DateTime.Compare(DateTime.Now, time_end) < 0)
                { // Restarts the timer and increments the counter.
                   
                    myTimer.Enabled = true;
                }
            }


            public LinkedList<Pump_Timeline> sort_start_time(LinkedList<Pump_Timeline> given_list)
            {
                LinkedList<Pump_Timeline> sorted = new LinkedList<Pump_Timeline>();

                LinkedListNode<Pump_Timeline> temp = given_list.First;


                while (given_list.First != null)
                {
                    for (LinkedListNode<Pump_Timeline> node = given_list.First; node != null;)
                    {
                        if (node.Value.get_Start().CompareTo(temp.Value.get_Start()) > 0)
                        {
                            temp = node;
                        }
                        node = node.Next;
                        sorted.AddLast(temp);
                        given_list.Remove(node);
                    }
                }

                return sorted;                

            }

          
        }

        public class Pump_Timeline
        {
            Serial_Com.Serial serial_con = new Serial_Com.Serial("COM4");
            private long time_start;
            private int total_runtime;
            LinkedList<Cycle> pump_list = new LinkedList<Cycle>();
            int remove_counter = 1;
        


            public Pump_Timeline(Cycle _cycle, int iterations, long time_start, Main_Timeline add_to_Main, string comport) //TODO: Redo time_start has to work with tick from begining
            {
       
                serial_con.set_comport(comport); //set com for pump

                for(int i = 1; i < iterations; i++)
                {
                    pump_list.AddFirst(_cycle);
                }

                add_to_Main.add_pump_timeline(this);
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

            public long get_Start()
            {
                return time_start;
            }

            public Serial_Com.Serial get_serial()
            {
                return serial_con;
            }

            public LinkedListNode<Cycle> get_next_cycle()
            {
                return pump_list.First;
            }

            public void remove_cycle()
            {
                pump_list.RemoveFirst();
                remove_counter = 1 + remove_counter; //Count the removed for the multiplier
            }

            public int get_remove_count()
            {
                return remove_counter;
            }
          

            


        }
    }



}
