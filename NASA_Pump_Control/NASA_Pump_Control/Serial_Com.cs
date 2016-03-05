using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NASA_Pump_Control
{
    class Serial_Com : Pump_Form
    {
        public class Serial
        {
            string comport = "COM4";
            int baud = 4800;
            int flow = 20;
    

            /// <summary>
            /// Constructor for class Serial.. 
            /// Initilizes checks pumps and then setups up for start.
            /// </summary>
            public Serial(string port) // Change from test
            {
                MessageBox.Show("Click ok to Test Pump");
                string message = "Did Pump get contacted?";
                string caption = "Choose Yes or no";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = System.Windows.Forms.DialogResult.No;
                

                

                while (result == System.Windows.Forms.DialogResult.No)
                {
                    result = MessageBox.Show(message, caption, buttons);
                    MessageBox.Show("Check connections and Test again"); //TODO: this will have another test to run after the serial coms branch is imported
                }

                MessageBox.Show("Pump Good to Go");
            }

            public void pump_on()
            {
                MessageBox.Show("PUMP ON");
            }
            public void set_comport(string port)
            {
                comport = port;
            }

            internal void pump_off()
            {
                throw new NotImplementedException();
            }
        }
     
    
              }
    
        

}

