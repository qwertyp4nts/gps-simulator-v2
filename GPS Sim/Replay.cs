using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace GPS_Sim
{
    public class Replay : Form1
    {
        SerialPort _serialPort;

        public void Start()
        {
            SerialPort _serialPort = new SerialPort();

            backgroundWorker1.WorkerSupportsCancellation = true;
            UpdatePorts();
            cmbCOMPort.SelectedIndex = 0;
        }

        private void UpdatePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbCOMPort.Items.Add(port);
            }
        }

        private void Connect(string portNum)
        {
            _serialPort.PortName = cmbCOMPort.SelectedItem.ToString();
            _serialPort.BaudRate = int.Parse(cmbBaud.SelectedItem.ToString());

            if (_serialPort.IsOpen)
            {
                System.Windows.Forms.MessageBox.Show("COM Port is already open");
            }
            else

            {
                try
                {
                    _serialPort.Open();
                    btnSend.Enabled = true;
                    btnStop.Enabled = true;
                    btnConnect.Text = "Disconnect";
                    lblConnected.Visible = true;
                    lblConnected.Text = "Successfully connected to " + portNum;
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Error: COM1 in use by another application");
                }
                finally
                {
                    if (!(_serialPort.IsOpen))
                    {
                        lblConnected.Visible = true;
                        lblConnected.Text = "Error: " + portNum + " in use by another application";
                    }

                }
            }
        }

        private void Disconnect(string portNum)
        {
            _serialPort.Close();

            if (_serialPort.IsOpen)
            {
                lblConnected.Text = $"Failed to disconnect from COM Port {cmbCOMPort.SelectedItem.ToString()}";
            }
            else
            {
                btnConnect.Text = "Connect";
                lblConnected.Text = $"Disconnected from COM Port {cmbCOMPort.SelectedItem.ToString()}";
            }
            
        }

        private void ConnectButtonClick()
        {
            string portNum = cmbCOMPort.SelectedItem.ToString();

            if (btnConnect.Text == "Connect")
            {
                Connect(portNum);
            }
            else if (btnConnect.Text == "Disconnect")
            {
                Disconnect(portNum);
            }
        }
        //I'm stuck here cos i need this to execute when a button is clicked. the event handler is on form1
        //to call this from there, this needs to be static method, then i cant access the buttons
        //i could try implement new one of this, but i dont think thats the right thing to do. sleep time
    }
}
