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
            DateTime time_begin;
            DateTime time_end;
            static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
            

            /// <summary>
            /// Constructor for Main Timeline
            /// The Main timeline will contain the timelines of the specific pumps.
            /// </summary>
            internal Main_Timeline()
            {

            }
            public Main_Timeline(int days)
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
               
                myTimer.Enabled = true;
                
                myTimer.Start();
                do
                {
                    myTimer.Tick += new EventHandler(TimerEventProcessor);
                } while (DateTime.Compare(time_begin, time_end) < 0);
            }
            

            // This is the method to run when the timer is raised.
            private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
            {
                myTimer.Stop();
                
                
                System.TimeSpan elapsed_ = DateTime.Now - time_begin;
                long elapsed = get_total_seconds(elapsed_);
                

                for(LinkedListNode<Pump_Timeline> node = pump_col.First; node != null;)
                {
                    int cycle_time_total = node.Value.get_next_cycle().Value.get_time_total();
                    int cycle_multiplier = node.Value.get_remove_count();
                    long timeline_start = node.Value.get_Start();

                    long timeline_end = node.Value.get_runtime_total();
                    int cycle_time_on = node.Value.get_next_cycle().Value.get_times()[0];

                    
                    //All Pump on Scenarios
                    if (elapsed == timeline_start || elapsed == timeline_start + (cycle_time_total * (cycle_multiplier - 1)))
                        if (node.Value.get_state() == false)
                        {
                            {
                                node.Value.get_serial().pump_on();
                                node.Value.set_state(true);
                                MessageBox.Show(node.Value.ToString());
                            }
                        }
                    //All Pump off Scenarios
                    if (elapsed == timeline_end || elapsed == cycle_time_on * cycle_multiplier)
                        if (node.Value.get_state())
                        {
                            {


                                node.Value.get_serial().pump_off();
                                node.Value.set_state(false);
                                node.Value.remove_cycle();

                            }
                        }
                   
                    
                    node = node.Next;
                }

                if (DateTime.Compare(DateTime.Now, time_end) > 0)
                { // Restarts the timer and increments the counter.

                    myTimer.Start();
                }
            }

            public int get_total_seconds(TimeSpan _given)
            {
                int total = _given.Days * 24 * 60 * 60;
                total += _given.Hours * 60 * 60;
                total += _given.Minutes * 60;
                total += _given.Seconds;

                return total;
            }
            
         
            public int get_pump_amt()
            {
                int amt = 0;
                for(LinkedListNode<Pump_Timeline> node = pump_col.First;node != null;)
                {
                    amt += 1;
                    node = node.Next;
                }
                return amt;
            }

            public LinkedListNode<Pump_Timeline> get_node(int location)
            {
                LinkedListNode<Pump_Timeline> node = pump_col.First;
                for(int i = 1; i < location; i++)
                {
                    node = node.Next;
                }
                return node; 
            }

          
        }

        public class Pump_Timeline
        {
            Serial_Com.Serial serial_con = new Serial_Com.Serial();
            private long time_start;
            private int total_runtime;
            LinkedList<Cycle> pump_list = new LinkedList<Cycle>();
            int remove_counter = 1;
            int flow_rate = 0;
            Boolean running = false;
        
            public Pump_Timeline()
            {

            }

            public Pump_Timeline(Cycle _cycle, int iterations, long time_start, Main_Timeline add_to_Main, string comport, int flow) //TODO: Redo time_start has to work with tick from begining
            {
                this.time_start = time_start;
                flow_rate = flow;
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
                    total = total + node.Value.get_time_total(); // gets total time for given cycle in the list;
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

            public int get_flowrate()
            {
                return flow_rate;
            }
            public bool get_state()
            {
                return running;
            }
            public void set_state(bool change_to)
            {
                running = change_to;
            }
          

            


        }
    }



}
