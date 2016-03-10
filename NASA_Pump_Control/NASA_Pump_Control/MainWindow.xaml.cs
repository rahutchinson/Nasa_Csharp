using System;
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
        int pump_amt = 0;
        public MainWindow()
        {
            InitializeComponent();
            
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
            if(_main.get_pump_amt() > pump_amt)
            {
                for(int i = 0; i < _main.get_pump_amt(); i++)
                {
                    if(i >= (stk_1_3.Children.Count))
                    {
                        Main_RUN pump = new Main_RUN(_main.get_node(i).Value, i,pump);
                        stk_1_3.Children.Add(pump);
                    }
                }
            }
        }
        internal void set_main_time(Timeline.Main_Timeline _toset_timeline)
        {
            _main = _toset_timeline;
            
        }

        private void btn_main_start_Click(object sender, RoutedEventArgs e)
        {
            _main.main_initialize();
            btn_main_start.Visibility = Visibility.Hidden;
            
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
