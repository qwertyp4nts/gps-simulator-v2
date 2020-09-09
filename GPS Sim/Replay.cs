using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace GPS_Sim
{
    public class Replay
    {
        private SerialPort _serialPort = new SerialPort();
        private Form1 form;

        public Replay(Form1 form) //The constructor. must have same name as class. no return type
        {
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

        private CancellationTokenSource _canceller;

        public async void sendData(string outputPath, string speed)
        {
            var dataToSend = outputPath;

            _canceller = new CancellationTokenSource();

            int rate;
            switch (speed)
            {
                case "1":
                    rate = 100;
                    break;

                case "10":
                    rate = 10;
                    break;
                default:
                    rate = 100;
                    break;
            }


            List<string> list = new List<string>();
            await Task.Run(() =>
            {
                do
                {
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(outputPath))
                    {

                        DateTime curr = DateTime.Now;

                        string line;
                        while (((line = reader.ReadLine()) != null) && (!(_canceller.Token.IsCancellationRequested)))
                        {
                            list.Add(line);

                            //write line to text box
                            if (line.StartsWith("$GNGGA"))
                            {
                                _serialPort.Write(line + "\r\n");
                                SetText(DateTime.Now.ToString("HH:mm:ss.fff") + " " + line + "\n");
                            }
                            else if (line.StartsWith("$GNRMC"))
                            {
                                _serialPort.Write(line + "\r\n");
                                SetText(DateTime.Now.ToString("HH:mm:ss.fff") + " " + line + "\n");

                                var period = (DateTime.Now - curr).Milliseconds;
                                if (period < rate)
                                {
                                    Thread.Sleep(rate - period);
                                }
                                curr = DateTime.Now;
                            }

                            if (_canceller.Token.IsCancellationRequested)
                            {
                                break;
                            }
                        }
                    }
                }
                while (form.txtSpeed.Text.Equals("0") && (!(_canceller.Token.IsCancellationRequested)));

            });
            _canceller.Dispose();
            form.btnStop.Enabled = false;
            form.btnSend.Enabled = true;
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (form.rtxtDataArea.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.rtxtDataArea.Invoke(d, new object[] { text });
            }
            else
            {
                form.rtxtDataArea.AppendText(text);
            }
        }

        public void stopClick()
        {
            _canceller.Cancel();
            form.btnSend.Enabled = true;
        }

    }
}
