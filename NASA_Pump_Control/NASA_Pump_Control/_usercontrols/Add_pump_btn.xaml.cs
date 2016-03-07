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

namespace NASA_Pump_Control._usercontrols
{
    /// <summary>
    /// Interaction logic for Add_pump_btn.xaml
    /// </summary>
    public partial class Add_pump_btn : UserControl
    {
        Timeline.Main_Timeline _main = new Timeline.Main_Timeline();
        Log _log = new Log();
        MainWindow _given_win = new MainWindow();

        internal Add_pump_btn(Timeline.Main_Timeline _pass_timeline, Log _log, MainWindow window_timeline)
        {
            _given_win = window_timeline;
            this._log = _log;
            _main = _pass_timeline;
            InitializeComponent();
        }

        internal void btn_add_new_Click(object sender, RoutedEventArgs e)
        {
            var host = new Window();
            Pump_new OP = new Pump_new(_main,_log,host,_given_win);
           
            host.Content = OP;
            host.Height = 350;
            host.Width = 400;
            host.Show();
        }
    }
}
