using NASA_Pump_Control._usercontrols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

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
            Add_pump_btn pump_btn = new Add_pump_btn(_main,_main_log,this);
            _main_create.PropertyChanged += prop_PropertyChanged;
            stk_1_2.Children.Add(pump_btn);
            _main = _main_create;

            btn_update.Visibility = Visibility.Visible;
            
            btn_main_show.Visibility = Visibility.Hidden;
            

        }

        private void prop_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            MessageBox.Show("Test1");
            lbl_elapsed.Text = _main.Elapsed.ToString();
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
                        Main_RUN pump = new Main_RUN(_main.get_node(i).Value, i);
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
            lbl_elapsed.Text = _main.Elapsed.ToString();
        }

        private void btn_issue_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
