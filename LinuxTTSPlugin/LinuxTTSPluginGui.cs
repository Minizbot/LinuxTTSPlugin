﻿
using System;
using System.Windows.Forms;

namespace LinuxTTSPlugin
{
    public partial class LinuxTTSPlugin : UserControl
    {
        #region Designer Created Code (Avoid editing)
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.opnTTS = new System.Windows.Forms.OpenFileDialog();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTTSBinary = new System.Windows.Forms.Label();
            this.lblArguments = new System.Windows.Forms.Label();
            this.lblPipe = new System.Windows.Forms.Label();
            this.txtTTSBinaryPath = new System.Windows.Forms.TextBox();
            this.btnSelectBinary = new System.Windows.Forms.Button();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.chkUsePipe = new System.Windows.Forms.CheckBox();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.tabs.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // opnTTS
            // 
            this.opnTTS.FileName = "Select TTS Binary";
            this.opnTTS.FileOk += new System.ComponentModel.CancelEventHandler(this.OpnTTS_FileOk);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tpSettings);
            this.tabs.Controls.Add(this.tpLog);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(686, 384);
            this.tabs.TabIndex = 1;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.tableLayoutPanel1);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(678, 358);
            this.tpSettings.TabIndex = 0;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.lblTTSBinary, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblArguments, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPipe, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTTSBinaryPath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectBinary, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtArguments, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkUsePipe, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 352);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTTSBinary
            // 
            this.lblTTSBinary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTTSBinary.AutoSize = true;
            this.lblTTSBinary.Location = new System.Drawing.Point(3, 52);
            this.lblTTSBinary.Name = "lblTTSBinary";
            this.lblTTSBinary.Size = new System.Drawing.Size(69, 26);
            this.lblTTSBinary.TabIndex = 8;
            this.lblTTSBinary.Text = "TTS Binary";
            this.lblTTSBinary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArguments
            // 
            this.lblArguments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArguments.AutoSize = true;
            this.lblArguments.Location = new System.Drawing.Point(3, 0);
            this.lblArguments.Name = "lblArguments";
            this.lblArguments.Size = new System.Drawing.Size(69, 26);
            this.lblArguments.TabIndex = 0;
            this.lblArguments.Text = "Arguments";
            this.lblArguments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPipe
            // 
            this.lblPipe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPipe.AutoSize = true;
            this.lblPipe.Location = new System.Drawing.Point(3, 26);
            this.lblPipe.Name = "lblPipe";
            this.lblPipe.Size = new System.Drawing.Size(69, 26);
            this.lblPipe.TabIndex = 5;
            this.lblPipe.Text = "Use Pipe";
            this.lblPipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTTSBinaryPath
            // 
            this.txtTTSBinaryPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTTSBinaryPath.Location = new System.Drawing.Point(78, 55);
            this.txtTTSBinaryPath.Name = "txtTTSBinaryPath";
            this.txtTTSBinaryPath.ReadOnly = true;
            this.txtTTSBinaryPath.Size = new System.Drawing.Size(441, 20);
            this.txtTTSBinaryPath.TabIndex = 9;
            this.txtTTSBinaryPath.Text = "Z:\\usr\\bin\\espeak";
            // 
            // btnSelectBinary
            // 
            this.btnSelectBinary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectBinary.Location = new System.Drawing.Point(525, 55);
            this.btnSelectBinary.Name = "btnSelectBinary";
            this.btnSelectBinary.Size = new System.Drawing.Size(144, 20);
            this.btnSelectBinary.TabIndex = 10;
            this.btnSelectBinary.Text = "Select TTS Binary";
            this.btnSelectBinary.UseVisualStyleBackColor = true;
            this.btnSelectBinary.Click += new System.EventHandler(this.BtnSelectBinary_Click);
            // 
            // txtArguments
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtArguments, 2);
            this.txtArguments.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtArguments.Location = new System.Drawing.Point(78, 3);
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(591, 20);
            this.txtArguments.TabIndex = 11;
            this.txtArguments.Text = "-a 15 -g 0 -p 50 -s 175";
            this.txtArguments.Leave += new System.EventHandler(this.TxtArguments_Leave);
            // 
            // chkUsePipe
            // 
            this.chkUsePipe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkUsePipe.AutoSize = true;
            this.chkUsePipe.Location = new System.Drawing.Point(78, 29);
            this.chkUsePipe.Name = "chkUsePipe";
            this.chkUsePipe.Size = new System.Drawing.Size(15, 20);
            this.chkUsePipe.TabIndex = 12;
            this.chkUsePipe.UseVisualStyleBackColor = true;
            this.chkUsePipe.CheckedChanged += new System.EventHandler(this.ChkUsePipe_CheckedChanged);
            // 
            // tpLog
            // 
            this.tpLog.Controls.Add(this.lstLogs);
            this.tpLog.Location = new System.Drawing.Point(4, 22);
            this.tpLog.Name = "tpLog";
            this.tpLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpLog.Size = new System.Drawing.Size(678, 358);
            this.tpLog.TabIndex = 1;
            this.tpLog.Text = "Logs";
            this.tpLog.UseVisualStyleBackColor = true;
            // 
            // lstLogs
            // 
            this.lstLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.Location = new System.Drawing.Point(3, 3);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(672, 352);
            this.lstLogs.TabIndex = 0;
            // 
            // LinuxTTSPlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabs);
            this.Name = "LinuxTTSPlugin";
            this.Size = new System.Drawing.Size(686, 384);
            this.tabs.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #endregion
        private TabControl tabs;
        private TabPage tpSettings;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTTSBinary;
        private Label lblArguments;
        private Label lblPipe;
        private TextBox txtTTSBinaryPath;
        private Button btnSelectBinary;
        private TextBox txtArguments;
        private CheckBox chkUsePipe;
        private TabPage tpLog;
        private ListBox lstLogs;
        private OpenFileDialog opnTTS;
        
        private void BtnSelectBinary_Click(object sender, EventArgs e)
        {
            opnTTS.ShowDialog();
        }

        private void OpnTTS_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtTTSBinaryPath.Text = opnTTS.FileName;
            ttsHandler.Command = opnTTS.FileName;
            if (chkUsePipe.Checked)
            {
                ttsHandler.Restart();
            }
        }

        private void ChkUsePipe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUsePipe.Checked)
            {
                ttsHandler.Restart();
            } else
            {
                ttsHandler.Close();
            }
        }

        private void TxtArguments_Leave(object sender, EventArgs e)
        {
            ttsHandler.CommandArguments = txtArguments.Text;
            if (chkUsePipe.Checked)
            {
                ttsHandler.CommandArguments += " --stdin";
                ttsHandler.Restart();
            }
        }
    }
}
