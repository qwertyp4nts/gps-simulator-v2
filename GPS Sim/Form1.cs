using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GPS_Sim
{
    public partial class Form1 : Form
    {
        Replay replay;
        SettingsProperty[] recentFiles = new SettingsProperty[10];

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
            BuildRecentFiles();
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

            replay.sendData(fileToReplayBox.Text, "1");

            //Store current path in recently replayed files
            //get current path name
            String currentPath = fileToReplayBox.Text;

            foreach (SettingsProperty setting in recentFiles)
            {
                if (setting.DefaultValue.Equals(""))
                {
                    setting.DefaultValue = currentPath;
                    fileToReplayBox.Items.Add(currentPath);
                    break;
                }
                else
                {

                }
            }
         //   Properties.Settings.Default.RecentlyReplayedFile0
            //add to settings list, if not already there. if there, move to top
            //RecentlyReplayedFile0
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            fileToReplayBox.Text = openFileDialog2.FileName;
        }

        private void BuildRecentFiles()
        {
            int i = 0;
            foreach (SettingsProperty setting in Properties.Settings.Default.Properties)
            {
                rtxtDataArea.AppendText(setting.Name + Environment.NewLine);
                if (setting.Name.StartsWith("RecentlyReplayedFile"))
                {
                    recentFiles[i] = setting;
                    i++;
                }
            }

            for (int j = 0; j < recentFiles.Length; j++)
            {
                if (!recentFiles[j].DefaultValue.Equals(""))
                {
                    fileToReplayBox.Items[j] = recentFiles[j].Name;
                }
            }
            //sort recentFiles array?
        }

        private void replayBrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void rtxtDataArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtDataArea.Clear();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            replay.stopClick();
        }
    }
}
