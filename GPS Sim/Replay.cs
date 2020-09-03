using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace GPS_Sim
{
    public class Replay
    {
        private SerialPort _serialPort;
        private Form1 form;

        public Replay(Form1 form) //The constructor. must have same name as class. no return type
        {
            SerialPort _serialPort = new SerialPort();
            this.form = form;

            this.form.backgroundWorker1.WorkerSupportsCancellation = true;
            UpdatePorts();
            this.form.cmbCOMPort.SelectedIndex = 0;
        }

        private void UpdatePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                form.cmbCOMPort.Items.Add(port);
            }
        }

        private void Connect(string portNum)
        {
            _serialPort.PortName = form.cmbCOMPort.SelectedItem.ToString();
            _serialPort.BaudRate = int.Parse(form.cmbBaud.SelectedItem.ToString());

            if (_serialPort.IsOpen)
            {
                System.Windows.Forms.MessageBox.Show("COM Port is already open");
            }
            else

            {
                try
                {
                    _serialPort.Open();
                    form.btnSend.Enabled = true;
                    form.btnStop.Enabled = true;
                    form.btnConnect.Text = "Disconnect";
                    form.lblConnected.Visible = true;
                    form.lblConnected.Text = "Successfully connected to " + portNum;
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Error: COM1 in use by another application");
                }
                finally
                {
                    if (!(_serialPort.IsOpen))
                    {
                        form.lblConnected.Visible = true;
                        form.lblConnected.Text = "Error: " + portNum + " in use by another application";
                    }

                }
            }
        }

        private void Disconnect(string portNum)
        {
            _serialPort.Close();

            if (_serialPort.IsOpen)
            {
                form.lblConnected.Text = $"Failed to disconnect from COM Port {form.cmbCOMPort.SelectedItem.ToString()}";
            }
            else
            {
                form.btnConnect.Text = "Connect";
                form.lblConnected.Text = $"Disconnected from COM Port {form.cmbCOMPort.SelectedItem.ToString()}";
            }
            
        }

        public void ConnectButtonClick()
        {
            string portNum = form.cmbCOMPort.SelectedItem.ToString();

            if (form.btnConnect.Text == "Connect")
            {
                Connect(portNum);
            }
            else if (form.btnConnect.Text == "Disconnect")
            {
                Disconnect(portNum);
            }
        }

    }
}
