#define DEBUG
//#define timer
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            int total_days = 1;
            LinkedList<Pump_Timeline> pump_col = new LinkedList<Pump_Timeline>();
            
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
            /// 
          

            public LinkedList<Pump_Timeline> main_initialize()
            {

                return pump_col;
#if timer
                myTimer.Enabled = true;

                myTimer.Start();
                myTimer.Interval = 1;


                myTimer.Tick += new EventHandler(TimerEventProcessor); 
#endif
                //Main Loop

            }

            

            // This is the method to run when the timer is raised.


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

        public class Pump_Timeline : Timeline, INotifyPropertyChanged //****************************************************************************************************************************************************
        {
            Serial_Com.Serial serial_con = new Serial_Com.Serial();
            private long time_start;
            private int total_runtime;
            
            public LinkedList<Cycle> cycle_list = new LinkedList<Cycle>();

            int flow_rate = 0;
            private Boolean running = false;
            public int internal_{get;set;}

            public LinkedList<Cycle> get_cycle_list()
            {
                return cycle_list;
            }

            public Boolean Running
            {
                get
                {
                    return running;
                }
                set
                {
                    running = value;
                    
                }
            }
            private int Iterations =0;
            public int iterations
            {
                get
                {
                    return Iterations;
                }
                 set
                {
                    Iterations = value;
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged(string v)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(v));
                }
            }

            
        

            

            public Pump_Timeline()
            {
                
            }

            public Pump_Timeline(Cycle _cycle, int iterations, long time_start, Main_Timeline add_to_Main, string comport, int flow) //TODO: Redo time_start has to work with tick from begining
            {
                this.time_start = time_start;
                flow_rate = flow;
                serial_con.set_comport(comport,flow); //set com for pump
                

                for(int i = 1; i < iterations+2; i++)
                {
                    cycle_list.AddFirst(_cycle);
                }

                add_to_Main.add_pump_timeline(this);
            }

            public void runtime_total_cal()
            {

                int total = 0;
                LinkedListNode<Cycle> node = cycle_list.First;
                for (node = cycle_list.First; node != null;)
                {
                    total = total + node.Value.get_time_total(); // gets total time for given cycle in the list;
                    node = node.Next;
                    
                }
                total_runtime = total - cycle_list.First.Value.get_time_total();
            }
            public int get_total_runtime()
            {
                return total_runtime;
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
                return cycle_list.First;
            }

            public void iteration()
            {
                cycle_list.RemoveFirst();
                iterations = 1 + iterations; //Count the removed for the multiplier
            }
            public void internal_cycle()
            {
                internal_ = 1 + internal_; 
            }
                
           

            public int get_flowrate()
            {
                return flow_rate;
            }

            internal void update()
            {
                OnPropertyChanged("UPDATE");
            }
        }
    }



}
