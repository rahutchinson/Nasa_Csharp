using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA_Pump_Control
{
    class Serial_Com : Pump_Form
    {
        public class test
        {
            string comport = "COM1";
            int baud = 4800;
            int flow = 5;
            string error = "None";

            public test()
            {
                try
                {
                    SerialPort port = new SerialPort(comport, baud, Parity.Odd, 7, StopBits.One);
                    
                    port.WriteLine("\02P01G0");
                    port.WriteLine("\02P01S+" + flow);
                }
                catch (Exception e)
                {
                    error = e.ToString();
                }

            }
            public test(int flow)
            {
                try
                {
                    SerialPort port = new SerialPort(comport, baud, Parity.Odd, 7, StopBits.One);
                    port.WriteLine("\02P01G0");
                    port.WriteLine("\02P01S+" + "");
                }
                catch (Exception e)
                {
                    error = e.ToString();
                }
            }
            public test(string comport, int baud, int flow)
            {
                try
                {
                    SerialPort port = new SerialPort(comport, baud, Parity.Odd, 7, StopBits.One);
                    port.WriteLine("\02P01G0");
                    port.WriteLine("\02P01S+" + "");
                }
                catch (Exception e)
                {
                    error = e.ToString();
                }
            }
            public test(string comport_g, int baud_g, int flow_g, string config)
            {
                try
                {
                    SerialPort port = new SerialPort(comport_g, baud_g, Parity.Odd, 7, StopBits.One);
                    port.WriteLine("\02P01G0");
                    port.WriteLine("\02P01S+" + flow_g);
                }
                catch (Exception e)
                {
                    error = e.ToString();
                }
            }
            /// <summary>
            /// Get flow and uses a configuartion sequence defined in Labview.
            /// 
            /// This is the Main test.
            /// </summary>
            /// <param name="flow"></param>
            /// mL/min
            /// <param name="config"></param>
            /// disregard
            public test(int flow, string config)
            {
                try
                {
                    SerialPort port = new SerialPort(comport, baud, Parity.Odd, 7, StopBits.One);
                    //config
                    port.Write("\05");
                    System.Threading.Thread.Sleep(130);
                    port.DiscardInBuffer();
                    port.DiscardOutBuffer();
                    port.WriteLine("\02P01");
                    port.WriteLine("\02P01R");
                    //end_config
                    port.WriteLine("\02P01G0");
                    port.WriteLine("\02P01S+" + flow);
                }
                catch (Exception e)
                {
                    error = e.ToString();
                }
            }
            public string get_error()
            {
                return error;
            }


        }
    
        

        internal void testing(string comport, int baud,int speed)
        {
            
        }
    }
}
