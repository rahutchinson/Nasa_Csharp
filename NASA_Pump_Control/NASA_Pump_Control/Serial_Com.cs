using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NASA_Pump_Control
{
    class Serial_Com
    {
        public class Serial
        {
            string comport = "COM4";
            int baud = 4800;
            int flow = 0;

            Timeline.Main_Timeline _main_timeline = new Timeline.Main_Timeline();

            string message = ((char)5).ToString();  //ENQ
            string message1 = ((char)2).ToString(); //STK
            string cr = ((char)'\r').ToString();
            
            public Serial()
            {
                
            }

            /// <summary>
            /// Constructor for class Serial.. 
            /// Initilizes checks pumps and then setups up for start.
            /// </summary>
            public Serial(string port) // Change from test
            {
                
            }

            public void pump_on()
            {
#if false
                SerialPort port_ = new SerialPort(comport, baud, Parity.Odd, 7, StopBits.One);
                System.Threading.Thread.Sleep(20);
                port_.Open();
                port_.Write(string.Format(message1));
                port_.Write("P01G0" + cr);
                port_.Write(string.Format(message1));
                port_.WriteLine("P01S+" + flow + cr);
                
                port_.Close(); 
#endif
                
            }
            public void set_comport(string port,int flow)
            {
                this.flow = flow;
#if false
                try
                {
                    SerialPort port_ = new SerialPort(comport, baud, Parity.Odd, 7, StopBits.One);
                    port_.Open();
                   

                    port_.Write(message + cr);
                    System.Threading.Thread.Sleep(130);
                    port_.DiscardInBuffer();
                    port_.DiscardOutBuffer();
                    port_.Write(string.Format(message1));
                    port_.Write("P01" + cr);
                    System.Threading.Thread.Sleep(130);
                    port_.Write(string.Format(message1));
                    port_.Write("P01R" + cr);
                    //end_config
                    

                    port_.Close();
                }
                catch (Exception e)
                {
                    
                }
                  comport = port;
#endif
            }

            internal void pump_off()
            {
                SerialPort port = new SerialPort(comport, baud, Parity.Odd, 7, StopBits.One);
#if false
                port.Open();
                port.Write(string.Format(message1));
                port.WriteLine("P01H" + cr);

                port.Close();
#endif
                
            }
            internal void set_timeline(Timeline.Main_Timeline _given)
            {
                _main_timeline = _given;
            }
        }
     
    
              }
    
        

}

