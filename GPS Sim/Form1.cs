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

            addRecentFile(currentPath);
        }

        private bool addRecentFile(String path)
        {
            //Check if path already in settings
            foreach (SettingsProperty s in recentFiles)
            {
                if (s.DefaultValue.Equals(path))
                {
                    //clear it
                    s.DefaultValue = "";
                    //move it to the top
                    sortRecentFiles(path);
                    return true;
                }
            }

            //Check if settings are full
            for (int i = 0; i < recentFiles.Length; i++)
            {
                //if (recentFiles[i].DefaultValue.Equals(""))
                 if (string.IsNullOrEmpty(recentFiles[i].DefaultValue.ToString()))
                    {
                    recentFiles[i].DefaultValue = path;
                    //Properties.Settings.Default.Properties.recentFiles[i].DefaultValue = path;
                    break;
                }
            }

            //Settings are full, sort
            sortRecentFiles(path, true);
            return true;
        }

        private void sortRecentFiles(String path, bool full = false)
        {
            if (full == true)
            {
                for (int i = 0; i < recentFiles.Length - 1; i++)
                {
                    //delete first entry of recentfiles and re-order rest
                    recentFiles[i].DefaultValue = recentFiles[i + 1].DefaultValue;
                }
                //add the new one at the end
                recentFiles[recentFiles.Length - 1].DefaultValue = path;
            }

            if (full == false)
            {
                for (int i = 0; i < recentFiles.Length; i++)
                {
                    //if (recentFiles[i].DefaultValue.Equals(""))
                    if (string.IsNullOrEmpty(recentFiles[i].DefaultValue.ToString()))
                    {
                        for (int j = i; j < recentFiles.Length; j++)
                        {
                            //re-order rest
                            //if (recentFiles[j].DefaultValue.Equals(""))
                            if (string.IsNullOrEmpty(recentFiles[j].DefaultValue.ToString()))
                                {
                                break;
                            }
                            recentFiles[j].DefaultValue = recentFiles[i + 1].DefaultValue;
                        }
                        //add the new one at the end
                        recentFiles[recentFiles.Length - 1].DefaultValue = path;
                    }
                }
            }
            populateRecentFilesDropdown();

        }

        private void populateRecentFilesDropdown()
        {
            //remove all items from combobox
            int itemsInComboBox = fileToReplayBox.Items.Count;
            for (int i = 0; i < itemsInComboBox; i++)
            {
                fileToReplayBox.Items.RemoveAt(0);
            }

            for (int i = recentFiles.Length - 1; i >= 0; i--)
            {
                //if (!recentFiles[i].DefaultValue.Equals(""))
                if (!string.IsNullOrEmpty(recentFiles[i].DefaultValue.ToString()))
                {
                    fileToReplayBox.Items.Add(recentFiles[i].DefaultValue);
                }
            }
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
            foreach (SettingsProperty array in recentFiles)
            {
                foreach (SettingsProperty setting in Properties.Settings.Default.Properties)
                {
                    //rtxtDataArea.AppendText(setting.Name + Environment.NewLine);
                    if (setting.Name.StartsWith("RecentlyReplayedFile" + i))
                    {
                        recentFiles[i] = setting;
                        i++;
                        break;
                    }
                }
            }
            /*
            //Sort settings array
            for (int j = 0; j < recentFiles.Length; j++)
            {
                if (!string.IsNullOrEmpty(recentFiles[j].DefaultValue.ToString()))
                {
                    //fileToReplayBox.Items[j] = recentFiles[j].Name;
                    fileToReplayBox.Items[j] = recentFiles[j].Name;
                }
            }*/
            //Populate dropdown box
            populateRecentFilesDropdown();
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
