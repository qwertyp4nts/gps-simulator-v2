using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPS_Sim
{
    public partial class Form1 : Form
    {
        Replay replay;

        public Form1()
        {
            InitializeComponent();
            panelLeft.Height = generateButton.Height;
            panelLeft.Top = generateButton.Top;

            mainTab.Appearance = TabAppearance.FlatButtons;
            mainTab.ItemSize = new Size(0, 1);
            mainTab.SizeMode = TabSizeMode.Fixed;

            fileToConvertPathBox.Text = Properties.Settings.Default.FilePathOfGeneratedFile;

            replay = new Replay(this);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            panelLeft.Height = generateButton.Height;
            panelLeft.Top = generateButton.Top;

            mainTab.SelectTab(0);
        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            panelLeft.Height = replayButton.Height;
            panelLeft.Top = replayButton.Top;

            mainTab.SelectTab(1);
        }

        private void i2ApiButton_Click(object sender, EventArgs e)
        {
            panelLeft.Height = i2ApiButton.Height;
            panelLeft.Top = i2ApiButton.Top;

            mainTab.SelectTab(2);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            panelLeft.Height = HelpMeButton.Height;
            panelLeft.Top = HelpMeButton.Top;

            mainTab.SelectTab(3);
        }


        // GENERATE PAGE CONTENT
        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileToConvertPathBox.Text = openFileDialog1.FileName;
        }

        private void generateFileButton_Click(object sender, EventArgs e)
        {
            
        }

        // REPLAY PAGE CONTENT
        private void btnConnect_Click(object sender, EventArgs e)
        {
            replay.ConnectButtonClick();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            btnStop.Enabled = true;

           // sendData(FileOutputTextBox.Text, "1"); not implemented yet
        }
    }
}
