using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace NASA_Pump_Control
{
    /// <summary>
    /// Interaction logic for Initial.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Log _main_log = new Log();
      
        Timeline.Main_Timeline _main = new Timeline.Main_Timeline();
        LinkedList<Timeline.Pump_Timeline> col_pumps = new LinkedList<Timeline.Pump_Timeline>();

        int total_days = 1;

        DateTime time_begin;
        DateTime time_end;

        int cycle_time_total = 0;

        long timeline_start = 0;

        long timeline_end = 0;
        int cycle_time_on = 0;

        long elapsed;
        int cycle_count = 0;
        int cycle_internal_count = 0;

        public MainWindow()
        {
            InitializeComponent();

            
        }
        public void main_timeline_run()
        {

            col_pumps = _main.main_initialize();
            

            time_begin = DateTime.Now;
            time_end = time_begin.AddDays(total_days);
            for (LinkedListNode<Timeline.Pump_Timeline> node = col_pumps.First; node != null; node = node.Next)
            {
                node.Value.runtime_total_cal();
            }

            do
            {
                System.TimeSpan elapsed_ = DateTime.Now - time_begin;
                elapsed = _main.get_total_seconds(elapsed_);

                Console.WriteLine(elapsed + " cycle_time_total: " + cycle_time_total + " timeline_end: " + timeline_end + " timeline_start: " + timeline_start + " cycle_internal_count: " + cycle_internal_count + " cycle_time_on: " + cycle_time_on + " cycle_count: " + cycle_count);
                
                for (LinkedListNode<Timeline.Pump_Timeline> node = col_pumps.First; node != null; node = node.Next)
                {

                    cycle_time_total = node.Value.get_next_cycle().Value.get_time_total();

                    cycle_count = node.Value.iterations;
                    cycle_internal_count = node.Value.internal_;
                    timeline_start = node.Value.get_Start();

                    timeline_end = node.Value.get_total_runtime();
                    cycle_time_on = node.Value.get_next_cycle().Value.get_times()[0];
                    


                    Console.WriteLine("**********************STATE:" + node.Value.Running);



                    //All Pump on Scenarios
                    if (elapsed == timeline_start || elapsed == timeline_start + (cycle_time_total * cycle_count))
                    {
                        Console.WriteLine("Condition 1 - On");
                        if (node.Value.Running == false)
                        {
                            if (elapsed != timeline_end)
                            {
                                Console.WriteLine("Pump On");
                                node.Value.get_serial().pump_on();
                                node.Value.internal_cycle();
                                node.Value.Running = true;
                            }

                            node.Value.iteration();

                        }
                    }
                    //All Pump off Scenarios
                    else if (elapsed == timeline_end || elapsed == cycle_time_on * (cycle_internal_count) || elapsed == cycle_time_on)
                    {
                        Console.WriteLine("Condition 1 - off");
                        if (node.Value.Running)
                        {

                            Console.WriteLine("Pump Off");
                            node.Value.get_serial().pump_off();
                            node.Value.Running = false;
                            node.Value.internal_cycle();


                        }

                    }
                    Console.WriteLine(node.Value.get_cycle_list().Count);
                    if (node.Value.get_cycle_list().Count == 0)
                    {
                        col_pumps.Remove(node.Value);
                    }
                    node.Value.update();
                }
                interface_update();
                System.Threading.Thread.Sleep(50);
            }
            while (DateTime.Compare(time_begin, time_end) < 0);

        }

        private void interface_update()
        {
            for (LinkedListNode<Timeline.Pump_Timeline> node = col_pumps.First; node != null; node = node.Next)
            {
                

            }
        }

        private void btn_main_show_Click(object sender, RoutedEventArgs e)
        {
            Timeline.Main_Timeline _main_create = new Timeline.Main_Timeline();
            Button add_pump = new Button();
            add_pump.Content = "Add New Pump";
            add_pump.Click += new RoutedEventHandler(this.open_new_pump);
           
            Main_grid.Children.Add(add_pump);
            _main = _main_create;

            btn_update.Visibility = Visibility.Visible;
            
            btn_main_show.Visibility = Visibility.Hidden;
            

        }
        void open_new_pump(Object sender,EventArgs e)
        {
            var host = new Window();
            Pump_new OP = new Pump_new(_main,_main_log,host,this);

            host.Content = OP;
            host.Height = 350;
            host.Width = 400;
            host.Show();
        }
        

        internal void _update(object sender, RoutedEventArgs e)
        {
            btn_main_start.Visibility = Visibility.Visible;
          
        }
        internal void set_main_time(Timeline.Main_Timeline _toset_timeline)
        {
            _main = _toset_timeline;
            
        }

        private void btn_main_start_Click(object sender, RoutedEventArgs e)
        {
            
            btn_main_start.Visibility = Visibility.Hidden;
            main_timeline_run();

        }

        private void btn_issue_Click(object sender, RoutedEventArgs e)
        {
            var host = new Window();
            Issue_face OP = new Issue_face(host);

            host.Content = OP;
            host.Height = 350;
            host.Width = 400;
            host.Show();
        }
    }
}
