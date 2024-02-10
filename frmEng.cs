using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EngTool
{
    public partial class frmEng : MetroForm
    {
        private DataTable dt;
        private bool isFlashing = false;
        private bool isDeviceAvailable = false;
        private bool isWipeEnabled = true;
        private bool isLockEnabled = false;
        private string flashAllPath = "";
        private string flashAllExceptStoragePath = "";
        private string flashAllLockPath = "";
        public frmEng()
        {
            InitializeComponent();
            InitializeDB();
            RefreshDevices();
        }

        private void InitializeDB()
        {
            dt = new DataTable();
            dt.Columns.Add("Device ID");
            dt.Columns.Add("Boot");
            dt.Columns.Add("Status");
            dbDevices.DataSource = dt;
            dbDevices.Columns["Device ID"].Width = 200;
            dbDevices.Columns["Boot"].Width = 200;
            dbDevices.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void RefreshDevices()
        {
            dt.Rows.Clear();
            Process process = new Process();
            process.StartInfo.FileName = "adb";
            process.StartInfo.Arguments = "devices -l";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            string[] lines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                if (!line.Contains("List of devices attached"))
                {
                    string[] parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 2)
                    {
                        string DeviceID = parts[0];
                        string Boot = parts[parts.Length - 2];
                        string Status = "Device online";
                        dt.Rows.Add(DeviceID, Boot, Status);
                        isDeviceAvailable = true;
                    }
                }
            }
            dt.Rows.Add("xxxxxxxxxxxx", "device:beloved_xiaomi", "Device online");
        }

        private void frmEng_Load(object sender, EventArgs e)
        {

        }

        private void txtDownload_Click(object sender, EventArgs e)
        {
            Form frmDownloads = new frmDownloads();
            frmDownloads.Show();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = romBrowse.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(romBrowse.SelectedPath))
            {
                txtPath.Text = romBrowse.SelectedPath;
                flashAllPath = Path.Combine(romBrowse.SelectedPath, "flash_all.bat");
                flashAllExceptStoragePath = Path.Combine(romBrowse.SelectedPath, "flash_all_except_storage.bat");
                flashAllLockPath = Path.Combine(romBrowse.SelectedPath, "flash_all_lock.bat");
                if (!File.Exists(flashAllPath) && File.Exists(flashAllExceptStoragePath) && File.Exists(flashAllLockPath))
                {
                    MessageBox.Show("This directory doesn't contain a valid Fastboot ROM.", "Incorrect Firmware", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flashAllPath = "";
                    flashAllExceptStoragePath = "";
                    flashAllLockPath = "";
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        private void chkWipe_CheckedChanged(object sender, EventArgs e)
        {
            isWipeEnabled = chkWipe.Checked;
        }

        private void chkLock_CheckedChanged(object sender, EventArgs e)
        {
            isLockEnabled = chkLock.Checked;
        }

        private void btnFlash_Click(object sender, EventArgs e)
        {
            FlashImage(txtPath.Text, "xxxxxxxxxxxx");
        }

        private void CancelFlash()
        {
            isFlashing = false;
            this.ControlBox = true;
            btnRefresh.Enabled = true;
            btnBrowse.Enabled = true;
            txtPath.Enabled = true;
            txtDownload.Enabled = true;
            dbDevices.Enabled = true;
            chkWipe.Enabled = true;
            chkLock.Enabled = true;
            btnFlash.Enabled = true;
        }

        private void FlashProcedure(string path, string deviceId)
        {
            if (File.Exists(flashAllPath) && File.Exists(flashAllExceptStoragePath) && File.Exists(flashAllLockPath))
            {
                if (isWipeEnabled)
                {
                    Console.WriteLine(flashAllPath);
                }
                else if (isLockEnabled)
                {
                    Console.WriteLine(flashAllLockPath);
                }
                else
                {
                    Console.WriteLine(flashAllExceptStoragePath);
                }
            }
            else
            {
                MessageBox.Show("The selected directory doesn't contain a valid Fastboot ROM.", "Incorrect Firmware", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CancelFlash();
            }
        }

        private void FlashImage(string path, string deviceId)
        {
            isFlashing = true;
            this.ControlBox = false;
            btnRefresh.Enabled = false;
            btnBrowse.Enabled = false;
            txtPath.Enabled = false;
            txtDownload.Enabled = false;
            dbDevices.Enabled = false;
            chkWipe.Enabled = false;
            chkLock.Enabled = false;
            btnFlash.Enabled = false;
            DialogResult result = MessageBox.Show("Flashing firmware to your device can result in data loss. Make sure to backup all important data before proceeding.\n\nDo you want to continue?", "Data Loss Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DialogResult result2 = MessageBox.Show("There is a risk of bricking your device if the flashing process is interrupted or if incorrect firmware is used. Ensure you have the correct firmware for your device model and proceed with caution.\n\nDo you want to continue?", "Bricking Risk Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result2 == DialogResult.Yes)
                {
                    DialogResult result3 = MessageBox.Show("Flashing custom firmware may void your device's warranty. Before proceeding, please ensure you understand the potential consequences and verify the warranty status of your device.\n\nDo you want to continue?", "Warranty Void Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result3 == DialogResult.Yes)
                    {
                        FlashProcedure(path, deviceId);
                    }
                    else
                    {
                        CancelFlash();
                    }

                }
                else
                {
                    CancelFlash();
                }
            }
            else
            {
                CancelFlash();
            }
        }

        private void frmEng_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isFlashing)
            {
                e.Cancel = true;
            }
        }
    }
}