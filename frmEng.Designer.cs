namespace EngTool
{
    partial class frmEng
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEng));
            this.pnlProgress = new MetroFramework.Controls.MetroProgressBar();
            this.btnFlash = new MetroFramework.Controls.MetroButton();
            this.chkWipe = new MetroFramework.Controls.MetroCheckBox();
            this.chkLock = new MetroFramework.Controls.MetroCheckBox();
            this.frmStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.txtDownload = new MetroFramework.Controls.MetroLink();
            this.txtPath = new MetroFramework.Controls.MetroTextBox();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.romBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.dbDevices = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.frmStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProgress
            // 
            this.pnlProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlProgress.FontSize = MetroFramework.MetroProgressBarSize.Small;
            this.pnlProgress.FontWeight = MetroFramework.MetroProgressBarWeight.Bold;
            this.pnlProgress.Location = new System.Drawing.Point(12, 465);
            this.pnlProgress.MarqueeAnimationSpeed = 25;
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.pnlProgress.Size = new System.Drawing.Size(795, 23);
            this.pnlProgress.Step = 0;
            this.pnlProgress.Style = MetroFramework.MetroColorStyle.Orange;
            this.pnlProgress.TabIndex = 0;
            this.pnlProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFlash
            // 
            this.btnFlash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlash.Location = new System.Drawing.Point(813, 465);
            this.btnFlash.Name = "btnFlash";
            this.btnFlash.Size = new System.Drawing.Size(75, 23);
            this.btnFlash.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnFlash.TabIndex = 1;
            this.btnFlash.Text = "Flash";
            this.btnFlash.Click += new System.EventHandler(this.btnFlash_Click);
            // 
            // chkWipe
            // 
            this.chkWipe.AutoSize = true;
            this.chkWipe.Checked = true;
            this.chkWipe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWipe.Location = new System.Drawing.Point(12, 444);
            this.chkWipe.Name = "chkWipe";
            this.chkWipe.Size = new System.Drawing.Size(76, 15);
            this.chkWipe.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkWipe.TabIndex = 2;
            this.chkWipe.Text = "Wipe data";
            this.metroToolTip1.SetToolTip(this.chkWipe, "Permanently remove user data (recommended)");
            this.chkWipe.UseVisualStyleBackColor = true;
            this.chkWipe.CheckedChanged += new System.EventHandler(this.chkWipe_CheckedChanged);
            // 
            // chkLock
            // 
            this.chkLock.AutoSize = true;
            this.chkLock.Location = new System.Drawing.Point(94, 444);
            this.chkLock.Name = "chkLock";
            this.chkLock.Size = new System.Drawing.Size(109, 15);
            this.chkLock.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkLock.TabIndex = 3;
            this.chkLock.Text = "Lock bootloader";
            this.metroToolTip1.SetToolTip(this.chkLock, "Lock device bootloader after flashing (only use with stock!!)");
            this.chkLock.UseVisualStyleBackColor = true;
            this.chkLock.CheckedChanged += new System.EventHandler(this.chkLock_CheckedChanged);
            // 
            // frmStyleManager
            // 
            this.frmStyleManager.Owner = this;
            this.frmStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
            this.frmStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtDownload
            // 
            this.txtDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownload.Location = new System.Drawing.Point(761, 33);
            this.txtDownload.Name = "txtDownload";
            this.txtDownload.Size = new System.Drawing.Size(127, 23);
            this.txtDownload.TabIndex = 4;
            this.txtDownload.Text = "Download stock ROM";
            this.txtDownload.Click += new System.EventHandler(this.txtDownload_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPath.Location = new System.Drawing.Point(162, 33);
            this.txtPath.MaxLength = 256;
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(593, 23);
            this.txtPath.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtPath.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(69, 23);
            this.btnRefresh.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(87, 33);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(69, 23);
            this.btnBrowse.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // romBrowse
            // 
            this.romBrowse.ShowNewFolderButton = false;
            // 
            // dbDevices
            // 
            this.dbDevices.AllowUserToAddRows = false;
            this.dbDevices.AllowUserToDeleteRows = false;
            this.dbDevices.AllowUserToResizeColumns = false;
            this.dbDevices.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(8)))));
            this.dbDevices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dbDevices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dbDevices.BackgroundColor = System.Drawing.Color.White;
            this.dbDevices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dbDevices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dbDevices.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dbDevices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbDevices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dbDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dbDevices.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbDevices.DefaultCellStyle = dataGridViewCellStyle3;
            this.dbDevices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dbDevices.GridColor = System.Drawing.SystemColors.Control;
            this.dbDevices.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dbDevices.Location = new System.Drawing.Point(12, 62);
            this.dbDevices.MultiSelect = false;
            this.dbDevices.Name = "dbDevices";
            this.dbDevices.ReadOnly = true;
            this.dbDevices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dbDevices.RowHeadersVisible = false;
            this.dbDevices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dbDevices.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dbDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbDevices.ShowCellErrors = false;
            this.dbDevices.ShowCellToolTips = false;
            this.dbDevices.ShowEditingIcon = false;
            this.dbDevices.ShowRowErrors = false;
            this.dbDevices.Size = new System.Drawing.Size(876, 376);
            this.dbDevices.TabIndex = 8;
            // 
            // frmEng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.dbDevices);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtDownload);
            this.Controls.Add(this.chkLock);
            this.Controls.Add(this.chkWipe);
            this.Controls.Add(this.btnFlash);
            this.Controls.Add(this.pnlProgress);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEng";
            this.Padding = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "EngTool";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEng_FormClosing);
            this.Load += new System.EventHandler(this.frmEng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDevices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar pnlProgress;
        private MetroFramework.Controls.MetroButton btnFlash;
        private MetroFramework.Controls.MetroCheckBox chkWipe;
        private MetroFramework.Controls.MetroCheckBox chkLock;
        private MetroFramework.Components.MetroStyleManager frmStyleManager;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLink txtDownload;
        private MetroFramework.Controls.MetroTextBox txtPath;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private System.Windows.Forms.FolderBrowserDialog romBrowse;
        private System.Windows.Forms.DataGridView dbDevices;
    }
}

