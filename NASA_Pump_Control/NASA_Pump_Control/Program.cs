using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace NASA_Pump_Control
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Initial OP = new Initial();
            var host = new Window();
            host.Content = OP;
            host.Show();

            MessageBox.Show("test");

        }
    }
}
