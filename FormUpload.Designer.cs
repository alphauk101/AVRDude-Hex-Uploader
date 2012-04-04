namespace AVRHexUploader
{
    partial class FormUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpload));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textCommand = new System.Windows.Forms.TextBox();
            this.checkSelectPort = new System.Windows.Forms.CheckBox();
            this.linkFuses = new System.Windows.Forms.LinkLabel();
            this.buttonLocate = new System.Windows.Forms.Button();
            this.labelHex = new System.Windows.Forms.Label();
            this.buttonHexBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboChip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboProgrammer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboPorts = new System.Windows.Forms.ComboBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.checkForce = new System.Windows.Forms.CheckBox();
            this.checkVerbose = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textExtendedByte = new System.Windows.Forms.TextBox();
            this.checkSetFuses = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textHighByte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textLowByte = new System.Windows.Forms.TextBox();
            this.openAVRDude = new System.Windows.Forms.OpenFileDialog();
            this.openConf = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCommand
            // 
            this.textCommand.Location = new System.Drawing.Point(14, 188);
            this.textCommand.Name = "textCommand";
            this.textCommand.ReadOnly = true;
            this.textCommand.Size = new System.Drawing.Size(424, 20);
            this.textCommand.TabIndex = 9;
            this.toolTip.SetToolTip(this.textCommand, "Double-click to edit");
            this.textCommand.TextChanged += new System.EventHandler(this.textCommand_TextChanged);
            this.textCommand.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textCommand_MouseDoubleClick);
            // 
            // checkSelectPort
            // 
            this.checkSelectPort.AutoSize = true;
            this.checkSelectPort.Checked = true;
            this.checkSelectPort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSelectPort.Location = new System.Drawing.Point(196, 91);
            this.checkSelectPort.Name = "checkSelectPort";
            this.checkSelectPort.Size = new System.Drawing.Size(15, 14);
            this.checkSelectPort.TabIndex = 7;
            this.toolTip.SetToolTip(this.checkSelectPort, "If you\'re using a USB programmer, you can probably uncheck this");
            this.checkSelectPort.UseVisualStyleBackColor = true;
            this.checkSelectPort.CheckedChanged += new System.EventHandler(this.checkSelectPort_CheckedChanged);
            // 
            // linkFuses
            // 
            this.linkFuses.AutoSize = true;
            this.linkFuses.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkFuses.Location = new System.Drawing.Point(168, 1);
            this.linkFuses.Name = "linkFuses";
            this.linkFuses.Size = new System.Drawing.Size(19, 13);
            this.linkFuses.TabIndex = 14;
            this.linkFuses.TabStop = true;
            this.linkFuses.Text = " ? ";
            this.toolTip.SetToolTip(this.linkFuses, "Link to the Engbedded Fuse Calculator");
            this.linkFuses.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFuses_LinkClicked);
            // 
            // buttonLocate
            // 
            this.buttonLocate.Location = new System.Drawing.Point(446, 155);
            this.buttonLocate.Name = "buttonLocate";
            this.buttonLocate.Size = new System.Drawing.Size(75, 24);
            this.buttonLocate.TabIndex = 13;
            this.buttonLocate.Text = "Locate...";
            this.toolTip.SetToolTip(this.buttonLocate, "Locate the AVRDude Executable and Configuration Files");
            this.buttonLocate.UseVisualStyleBackColor = true;
            this.buttonLocate.Click += new System.EventHandler(this.buttonLocate_Click);
            // 
            // labelHex
            // 
            this.labelHex.Location = new System.Drawing.Point(7, 20);
            this.labelHex.Name = "labelHex";
            this.labelHex.Size = new System.Drawing.Size(414, 18);
            this.labelHex.TabIndex = 7;
            this.labelHex.Text = "Select Hex File";
            this.labelHex.TextChanged += new System.EventHandler(this.updateCommand);
            // 
            // buttonHexBrowse
            // 
            this.buttonHexBrowse.Location = new System.Drawing.Point(427, 15);
            this.buttonHexBrowse.Name = "buttonHexBrowse";
            this.buttonHexBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonHexBrowse.TabIndex = 6;
            this.buttonHexBrowse.Text = "Browse...";
            this.buttonHexBrowse.UseVisualStyleBackColor = true;
            this.buttonHexBrowse.Click += new System.EventHandler(this.buttonHexBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelHex);
            this.groupBox1.Controls.Add(this.buttonHexBrowse);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 45);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hex File to Upload";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkSelectPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboChip);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboProgrammer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboPorts);
            this.groupBox2.Location = new System.Drawing.Point(13, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 118);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Standard Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chip:";
            // 
            // comboChip
            // 
            this.comboChip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChip.FormattingEnabled = true;
            this.comboChip.Location = new System.Drawing.Point(91, 54);
            this.comboChip.Name = "comboChip";
            this.comboChip.Size = new System.Drawing.Size(120, 21);
            this.comboChip.TabIndex = 4;
            this.comboChip.SelectionChangeCommitted += new System.EventHandler(this.updateCommand);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Programmer:";
            // 
            // comboProgrammer
            // 
            this.comboProgrammer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProgrammer.FormattingEnabled = true;
            this.comboProgrammer.Location = new System.Drawing.Point(91, 22);
            this.comboProgrammer.Name = "comboProgrammer";
            this.comboProgrammer.Size = new System.Drawing.Size(120, 21);
            this.comboProgrammer.TabIndex = 2;
            this.comboProgrammer.SelectionChangeCommitted += new System.EventHandler(this.updateCommand);
            this.comboProgrammer.Validated += new System.EventHandler(this.updateCommand);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "COM Port:";
            // 
            // comboPorts
            // 
            this.comboPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPorts.FormattingEnabled = true;
            this.comboPorts.Location = new System.Drawing.Point(91, 87);
            this.comboPorts.Name = "comboPorts";
            this.comboPorts.Size = new System.Drawing.Size(99, 21);
            this.comboPorts.TabIndex = 1;
            this.comboPorts.SelectedIndexChanged += new System.EventHandler(this.updateCommand);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Enabled = false;
            this.buttonUpload.Location = new System.Drawing.Point(445, 185);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(76, 25);
            this.buttonUpload.TabIndex = 8;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "hex";
            this.openFileDialog.Filter = "Compiled Hex Files|*.hex";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.Color.Black;
            this.textBoxOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.ForeColor = System.Drawing.Color.White;
            this.textBoxOutput.Location = new System.Drawing.Point(13, 224);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(507, 296);
            this.textBoxOutput.TabIndex = 10;
            this.textBoxOutput.WordWrap = false;
            // 
            // checkForce
            // 
            this.checkForce.AutoSize = true;
            this.checkForce.Location = new System.Drawing.Point(107, 21);
            this.checkForce.Name = "checkForce";
            this.checkForce.Size = new System.Drawing.Size(74, 17);
            this.checkForce.TabIndex = 7;
            this.checkForce.Text = "Force  (-F)";
            this.checkForce.UseVisualStyleBackColor = true;
            this.checkForce.CheckedChanged += new System.EventHandler(this.updateCommand);
            // 
            // checkVerbose
            // 
            this.checkVerbose.AutoSize = true;
            this.checkVerbose.Location = new System.Drawing.Point(14, 22);
            this.checkVerbose.Name = "checkVerbose";
            this.checkVerbose.Size = new System.Drawing.Size(83, 17);
            this.checkVerbose.TabIndex = 8;
            this.checkVerbose.Text = "Verbose (-v)";
            this.checkVerbose.UseVisualStyleBackColor = true;
            this.checkVerbose.CheckedChanged += new System.EventHandler(this.updateCommand);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkForce);
            this.groupBox3.Controls.Add(this.checkVerbose);
            this.groupBox3.Location = new System.Drawing.Point(245, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 48);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Options";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkFuses);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textExtendedByte);
            this.groupBox4.Controls.Add(this.checkSetFuses);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textHighByte);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textLowByte);
            this.groupBox4.Location = new System.Drawing.Point(245, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 64);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fuses";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Extd. Byte";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "0x";
            // 
            // textExtendedByte
            // 
            this.textExtendedByte.Enabled = false;
            this.textExtendedByte.Location = new System.Drawing.Point(151, 34);
            this.textExtendedByte.MaxLength = 2;
            this.textExtendedByte.Name = "textExtendedByte";
            this.textExtendedByte.Size = new System.Drawing.Size(26, 20);
            this.textExtendedByte.TabIndex = 7;
            this.textExtendedByte.TextChanged += new System.EventHandler(this.updateCommand);
            // 
            // checkSetFuses
            // 
            this.checkSetFuses.AutoSize = true;
            this.checkSetFuses.Location = new System.Drawing.Point(48, 0);
            this.checkSetFuses.Name = "checkSetFuses";
            this.checkSetFuses.Size = new System.Drawing.Size(15, 14);
            this.checkSetFuses.TabIndex = 6;
            this.checkSetFuses.UseVisualStyleBackColor = true;
            this.checkSetFuses.CheckedChanged += new System.EventHandler(this.checkSetFuses_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "High Byte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "0x";
            // 
            // textHighByte
            // 
            this.textHighByte.Enabled = false;
            this.textHighByte.Location = new System.Drawing.Point(89, 34);
            this.textHighByte.MaxLength = 2;
            this.textHighByte.Name = "textHighByte";
            this.textHighByte.Size = new System.Drawing.Size(26, 20);
            this.textHighByte.TabIndex = 3;
            this.textHighByte.TextChanged += new System.EventHandler(this.updateCommand);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Low Byte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "0x";
            // 
            // textLowByte
            // 
            this.textLowByte.Enabled = false;
            this.textLowByte.Location = new System.Drawing.Point(32, 34);
            this.textLowByte.MaxLength = 2;
            this.textLowByte.Name = "textLowByte";
            this.textLowByte.Size = new System.Drawing.Size(26, 20);
            this.textLowByte.TabIndex = 0;
            this.textLowByte.TextChanged += new System.EventHandler(this.updateCommand);
            // 
            // openAVRDude
            // 
            this.openAVRDude.FileName = "avrdude.exe";
            this.openAVRDude.Filter = "Executable|*.exe";
            this.openAVRDude.Title = "Locate AVRDude Executable";
            // 
            // openConf
            // 
            this.openConf.FileName = "avrdude.conf";
            this.openConf.Filter = "AVRDude Configuration|*.conf";
            this.openConf.Title = "Locate AVRDude Configuration File";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // FormUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 221);
            this.Controls.Add(this.buttonLocate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textCommand);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUpload";
            this.Text = "AVRDude Hex Uploader";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FormUpload_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUpload_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelHex;
        private System.Windows.Forms.Button buttonHexBrowse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboChip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPorts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textCommand;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.CheckBox checkForce;
        private System.Windows.Forms.CheckBox checkVerbose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textHighByte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLowByte;
        private System.Windows.Forms.CheckBox checkSetFuses;
        private System.Windows.Forms.CheckBox checkSelectPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textExtendedByte;
        private System.Windows.Forms.ComboBox comboProgrammer;
        private System.Windows.Forms.LinkLabel linkFuses;
        private System.Windows.Forms.OpenFileDialog openAVRDude;
        private System.Windows.Forms.OpenFileDialog openConf;
        private System.Windows.Forms.Button buttonLocate;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

