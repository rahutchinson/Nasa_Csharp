using Octokit;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System;

namespace NASA_Pump_Control
{
    /// <summary>
    /// Interaction logic for Main_RUN.xaml
    /// </summary>
    public partial class Main_RUN : UserControl
    {
        int _pump_num = 0;
        Timeline.Pump_Timeline _pump_ref = new Timeline.Pump_Timeline();
        internal Main_RUN(Timeline.Pump_Timeline _pump_line, int pump_num,)
        {
            _pump_ref = _pump_line;
            _pump_num = pump_num;
            _pump_line.PropertyChanged += prop_PropertyChanged;
            InitializeComponent();

            pump_num = pump_num + 1;

            lbl_pump_num.Text = pump_num.ToString();
            lbl_iterations.Text = _pump_line.iterations.ToString();
            lbl_flow_rate.Text = _pump_line.get_flowrate().ToString();
            lbl_Time_on.Text = _pump_line.get_next_cycle().Value.get_times()[0].ToString();
            lbl_Time_off.Text = _pump_line.get_next_cycle().Value.get_times()[1].ToString();

            status_green.Visibility = Visibility.Hidden;
            status_red.Visibility = Visibility.Hidden;


        }

        public void prop_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            lbl_iterations.Text = _pump_ref.iterations.ToString();

            if (_pump_ref.Running)
            {
                status_green.Visibility = Visibility.Visible;
                status_red.Visibility = Visibility.Hidden;
            }
            else
            {
                status_green.Visibility = Visibility.Hidden;
                status_red.Visibility = Visibility.Visible;
            }
        }

      
        public void update()
        {
            
            
        }
    }

        
    }

