using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace NASA_Pump_Control
{
    public partial class Pump_Form : Form
    {
        public Pump_Form()
        {
            InitializeComponent();
            
        }

        private void btn_run_Click(object sender, EventArgs e)
        {

        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            if (chk_config.Checked && chk_setspeed.Checked)
            {
                Serial_Com.test test1 = new Serial_Com.test(int.Parse(txt_speed.Text), "Test");
                MessageBox.Show(test1.get_error());
            }
        }

        private void btn_halt_Click(object sender, EventArgs e)
        {

        }

   
    }
}
