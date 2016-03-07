using Octokit;
using System.Windows;
using System.Windows.Controls;


namespace NASA_Pump_Control
{
    /// <summary>
    /// Interaction logic for Main_RUN.xaml
    /// </summary>
    public partial class Main_RUN : UserControl
    {
        int _pump_num = 0;
        
        internal Main_RUN(Timeline.Pump_Timeline _pump_line, int pump_num)
        {
            _pump_num = pump_num;
            InitializeComponent();

            pump_num = pump_num + 1;
            
            lbl_pump_num.Text = pump_num.ToString();
            lbl_iterations.Text = _pump_line.get_remove_count().ToString();
            lbl_flow_rate.Text = _pump_line.get_flowrate().ToString();
            lbl_Time_on.Text = _pump_line.get_next_cycle().Value.get_times()[0].ToString();
            lbl_Time_off.Text = _pump_line.get_next_cycle().Value.get_times()[1].ToString();
            if (_pump_line.get_state())
            {
                status_greem.Visibility = Visibility.Visible;
                status_red.Visibility = Visibility.Hidden;
            }
            else
            {
                status_greem.Visibility = Visibility.Hidden;
                status_red.Visibility =  Visibility.Visible;
            }
        }

        internal void update()
        {
            //TODO: use get node command to do pump status update
            
        }

        
    }
}
