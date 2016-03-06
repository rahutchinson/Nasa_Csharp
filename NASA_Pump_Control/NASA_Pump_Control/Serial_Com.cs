using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA_Pump_Control
{
    class Serial_Com
    {
        public class test
        {
            string comport = "COM4";
            int baud = 4800;
            int flow = 20;
            string error = "None";

            public test()
            {
                try
                {
                    SerialPort port = new SerialPort(comport, baud, Parity.Odd, 7, StopBits.One);
                    port.Open();
                    //config
                    string message = ((char)5).ToString();
                    string message1 = ((char)2).ToString();
                    string cr = ((char)'\r').ToString();
                   
                    port.Write(message + cr);
                    System.Threading.Thread.Sleep(130);
                    port.DiscardInBuffer();
                    port.DiscardOutBuffer();
                    port.Write(string.Format(message1));
                    port.Write("P01"+cr);
                    System.Threading.Thread.Sleep(130);
                    port.Write(string.Format(message1));
                    port.Write("P01R"+cr);
                    //end_config
                    System.Threading.Thread.Sleep(20);
                    port.Write(string.Format(message1));
                    port.Write("P01G0"+cr);
                    port.Write(string.Format(message1));
                    port.WriteLine("P01S+" + flow+ cr);

                    port.Close();
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

                    string message = ((char)5).ToString();
                    string message1 = ((char)2).ToString();
                    string cr = ((char)'\r').ToString();

                    SerialPort port = new SerialPort(comport, baud, Parity.Odd, 7, StopBits.One);

                    port.Open();
                    port.Write(string.Format(message1));
                    port.WriteLine("P01H" + cr);
                 
                    port.Close();
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
                    port.Close();
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
                    port.Close();
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
                    port.Close();
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

            public void halt()
            {
                SerialPort port = new SerialPort(comport, baud, Parity.Odd, 7, StopBits.One);
                port.WriteLine("\02P01H");
                
                port.Close();
            }


        }
    
        

        internal void testing(string comport, int baud,int speed)
        {
            
        }
    }
}
