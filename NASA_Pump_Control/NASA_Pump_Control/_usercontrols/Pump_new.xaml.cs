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

namespace NASA_Pump_Control
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class Pump_new : UserControl
    {
        private Timeline.Main_Timeline _main_line = new Timeline.Main_Timeline();
        internal Log __log = new Log();
        Window current = new Window();
        MainWindow need_toset = new MainWindow();
        internal Pump_new(Timeline.Main_Timeline _sent_line, Log _log,Window current_window, MainWindow to_set)
        {
            need_toset = to_set;
            current = current_window;
            __log = _log;
            _main_line = _sent_line;
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Cycle _cycle_ = new Cycle(get_cycle_txt());
            Timeline.Pump_Timeline _pump = new Timeline.Pump_Timeline(_cycle_, get_iterations(), get_start(), _main_line, get_comport(),get_flowrate());
            need_toset.set_main_time(_main_line);
            current.Close();
        }

        private int[] get_cycle_txt()
        {
            int on = 0;
            int off = 0;
            try
            {
                on = Int32.Parse(txt_time_on.Text.ToString());
                off = Int32.Parse(txt_time_off.Text.ToString());
            }
            catch (FormatException e)
            {
                __log.record(e.Message.ToString());
            }
            int[] ar_return = { on, off };
            return ar_return;
        }

        private int get_iterations()
        {
            int it = 0;
            try
            {
                it = Int32.Parse(txt_iterations.Text.ToString());
            }
            catch (FormatException e)
            {
                __log.record(e.Message.ToString());
            }
            return it;
        }
        private int get_start()
        {
            int hr = 0;
            int min = 0;
            int sec = 0;
            try
            {
                hr = Int32.Parse(txt_start_hours.Text.ToString());
                min = Int32.Parse(txt_start_minutes.Text.ToString());
                sec = Int32.Parse(txt_start_seconds.Text.ToString());
            }
            catch (FormatException e)
            {
                __log.record(e.Message.ToString());
            }
            min = min + hr * 60;
            sec = sec + min * 60;
            return sec;
        }
        private string get_comport()
        {
            return cmb_com_port.SelectedValue.ToString();
        }
        private int get_flowrate()
        {
            int flow = 0;
            try
            {
                flow = Int32.Parse(txt_flow_rate.Text.ToString());
                
            }
            catch (FormatException e)
            {
                __log.record(e.Message.ToString());
            }
            return flow;
        }
    }
}
