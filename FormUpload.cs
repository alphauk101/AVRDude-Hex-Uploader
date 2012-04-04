/*
 * Copyright (c) 2012 Aidan Dunbar
 * -------------------------------
 * Permission is hereby granted, free of charge, to any person obtaining a 
 * copy of this software and associated documentation files (the "Software"), 
 * to deal in the Software without restriction, including without limitation 
 * the rights to use, copy, modify, merge, publish, distribute, sublicense, 
 * and/or sell copies of the Software, and to permit persons to whom the 
 * Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included 
 * in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS 
 * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
 * THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
 * IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using Utility.ModifyRegistry;

namespace AVRHexUploader
{
    public partial class FormUpload : Form
    {
        String[] chipDude = new String[100];
        String[] programmerDude = new String[100];
        String appName = "AVRDude Hex Uploader";
        String avrdudeLocation = "";
        String confLocation = "";

        // To handle ending the process and returning the output
        delegate void finishedProcessDelegate(string output);

        public FormUpload()
        {
            InitializeComponent();
        }

        private void buttonHexBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = labelHex.Text;
            openFileDialog.ShowDialog();
            labelHex.Text = openFileDialog.FileName;
            toolTip.SetToolTip(labelHex, labelHex.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String line;
            int i = 0;

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("chips.txt"))
                {
                    String[] chipData;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        chipData = line.Split(',');
                        chipDude[i] = chipData[0];
                        comboChip.Items.Add(chipData[1].Trim());
                        i++;
                    }
                }


                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("programmers.txt"))
                {
                    String[] programmerData;
                    i = 0;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        programmerData = line.Split(',');
                        programmerDude[i] = programmerData[0];
                        comboProgrammer.Items.Add(programmerData[1].Trim());
                        i++;

                    }
                }
                comboChip.SelectedIndex = 0;
                comboProgrammer.SelectedIndex = 0;

            }
            catch (Exception exc)
            {
                // Let the user know what went wrong.
                MessageBox.Show("There was a problem reading a configuration file.\r\n\r\n" + exc.Message + "\r\n\r\n" + appName +
                " will now close.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                Application.Exit();
            }
            foreach (string str in SerialPort.GetPortNames())
            {
                comboPorts.Items.Add(str);
                comboPorts.SelectedIndex = 0;

            }

            // Grab the location of avrdude and the conf file from the settings file,
            // and if the location is not know, ask for it.
            avrdudeLocation = AVRHexUploader.Properties.Settings.Default.avrdude;
            confLocation = AVRHexUploader.Properties.Settings.Default.conf;
            if (avrdudeLocation == "")
            {
                openAVRDude.ShowDialog();
                avrdudeLocation = openAVRDude.FileName;
                AVRHexUploader.Properties.Settings.Default.avrdude = avrdudeLocation;
            }
            if (confLocation == "")
            {
                openConf.ShowDialog();
                confLocation = openConf.FileName;
                AVRHexUploader.Properties.Settings.Default.conf = confLocation;

            }

            // Load the previous settings from the configuration file.
            labelHex.Text = AVRHexUploader.Properties.Settings.Default.hex;
            checkVerbose.Checked = AVRHexUploader.Properties.Settings.Default.verbose;
            checkForce.Checked = AVRHexUploader.Properties.Settings.Default.force;
            checkSelectPort.Checked = AVRHexUploader.Properties.Settings.Default.useport;
            textLowByte.Text = AVRHexUploader.Properties.Settings.Default.lowbyte;
            textHighByte.Text = AVRHexUploader.Properties.Settings.Default.highbyte;
            textExtendedByte.Text = AVRHexUploader.Properties.Settings.Default.extendedbyte;
            checkSetFuses.Checked = AVRHexUploader.Properties.Settings.Default.fuse;

            // These often break if it is the first time the program is run, so catch
            // troublesome values (or nulls, in this case) and set to 0 instead.
            try
            {
                comboProgrammer.SelectedIndex = AVRHexUploader.Properties.Settings.Default.programmer;
            }
            catch
            {
                comboProgrammer.SelectedIndex = 0;
            }
            try
            {
                comboPorts.SelectedIndex = AVRHexUploader.Properties.Settings.Default.port;
            }
            catch
            {
                comboPorts.SelectedIndex = 0;
            }
            try
            {
                comboChip.SelectedIndex = AVRHexUploader.Properties.Settings.Default.chip;
            }
            catch
            {
                comboChip.SelectedIndex = 0;
            }

            // We keep track of the number of chips in the listing file and warn the user if the
            // number of chips has changed from the last time the program was run.
            if (comboChip.Items.Count != AVRHexUploader.Properties.Settings.Default.chipscount & AVRHexUploader.Properties.Settings.Default.chipscount != 0)
            {
                MessageBox.Show("The chip listing file appears to have changed.\r\n" +
                                "Check you have the correct chip selected before continuing.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );

            }

            // Do the same with the programmers file listing.
            if (comboProgrammer.Items.Count != AVRHexUploader.Properties.Settings.Default.programmercount & AVRHexUploader.Properties.Settings.Default.programmercount != 0)
            {
                MessageBox.Show("The programmer listing file appears to have changed.\r\n" + 
                                "Check you have the correct programmer selected before continuing.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                                );

            }

            // Recreate the command line argument
            updateCommand(sender, e);


        }

        private void comboChip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // This function builds the command line string that will be sent
        // to AVRDude. It looks complicated, but it's not really. 
        private void updateCommand(object sender, EventArgs e)
        {
            if (comboProgrammer.Text != "" && 
                comboPorts.Text != "" && 
                comboChip.Text != "" && 
                labelHex.Text != "Select Hex File" && 
                labelHex.Text != "*.hex")
            {


                String command = "\"" + avrdudeLocation + 
                                 "\" -C \"" + confLocation + 
                                 "\" -c " + programmerDude[comboProgrammer.SelectedIndex] + 
                                 " -p " + chipDude[comboChip.SelectedIndex] + 
                                 " -U flash:w:\"" + labelHex.Text + "\":i ";

                if (checkSelectPort.Checked == true)
                {
                    command = command + "-P " + comboPorts.Text + " ";
                }

                if (checkVerbose.Checked == true)
                {
                    command = command + "-v ";
                    textBoxOutput.WordWrap = false;
                }
                else
                {
                    textBoxOutput.WordWrap = true;
                }

                if (checkForce.Checked == true)
                {
                    command = command + "-F ";
                }

                if (checkSetFuses.Checked == true)
                {
                    // If the text boxes are blank, ignore that fuse byte.
                    // As of yet we don't check if the fuse we are trying to burn is valid.
                    // TODO: Check if AVRDude validates fuses.
                    if (textLowByte.Text != "")
                    {
                        command = command + " -U lfuse:w:0x" + textLowByte.Text + ":m";
                    }
                    if (textHighByte.Text != "")
                    {
                        command = command + " -U hfuse:w:0x" + textHighByte.Text + ":m";
                    }
                    if (textExtendedByte.Text != "")
                    {
                        command = command + " -U efuse:w:0x" + textExtendedByte.Text + ":m";
                    }
                }

                textCommand.Text = command;
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {


                FormUpload.ActiveForm.Cursor = Cursors.WaitCursor;
                textBoxOutput.Cursor = Cursors.WaitCursor;
                FormUpload.ActiveForm.Text += " - Working...";

                textBoxOutput.Text = "Working...\r\n";
                textBoxOutput.Text += "(DO NOT RESET OR TURN OFF UNTIL THIS COMPLETES)\r\n";

                FormUpload.ActiveForm.Height = 560;

                backgroundWorker.RunWorkerAsync(textCommand.Text);

        }


        private void checkSetFuses_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSetFuses.Checked == true)
            {
                textLowByte.Enabled = true;
                textHighByte.Enabled = true;
                textExtendedByte.Enabled = true;
            }
            else
            {
                textLowByte.Enabled = false;
                textHighByte.Enabled = false;
                textExtendedByte.Enabled = false;
            }
            updateCommand(sender, e);
        }

        private void checkSelectPort_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSelectPort.Checked == true)
            {
                comboPorts.Enabled = true;
            }
            else
            {
                comboPorts.Enabled = false;
            }
            updateCommand(sender, e);
        }
        private void textCommand_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (textCommand.ReadOnly != true)
            {
                textCommand.ReadOnly = true;
            }
            else
            {
                textCommand.ReadOnly = false;
            }
        }

        private void linkFuses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.engbedded.com/fusecalc/");
        }

        private void textCommand_TextChanged(object sender, EventArgs e)
        {
            if (textCommand.Text != "")
            {
                buttonUpload.Enabled = true;
            }
            else
            {
                buttonUpload.Enabled = false;
            }
        }

        private void FormUpload_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            // Open the webpage where they can find more information and help
            System.Diagnostics.Process.Start("http://www.adnbr.co.uk/projects/avrdude-hex-uploader");
        }

        private void FormUpload_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save all the settings ready for next use.
            AVRHexUploader.Properties.Settings.Default.hex = labelHex.Text;
            AVRHexUploader.Properties.Settings.Default.chip = comboChip.SelectedIndex;
            AVRHexUploader.Properties.Settings.Default.programmer = comboProgrammer.SelectedIndex;
            AVRHexUploader.Properties.Settings.Default.verbose = checkVerbose.Checked;
            AVRHexUploader.Properties.Settings.Default.force = checkForce.Checked;
            AVRHexUploader.Properties.Settings.Default.useport = checkSelectPort.Checked;
            AVRHexUploader.Properties.Settings.Default.port = comboPorts.SelectedIndex;
            AVRHexUploader.Properties.Settings.Default.lowbyte = textLowByte.Text;
            AVRHexUploader.Properties.Settings.Default.highbyte = textHighByte.Text;
            AVRHexUploader.Properties.Settings.Default.extendedbyte = textExtendedByte.Text;
            AVRHexUploader.Properties.Settings.Default.fuse = checkSetFuses.Checked;
            AVRHexUploader.Properties.Settings.Default.chipscount = comboChip.Items.Count;
            AVRHexUploader.Properties.Settings.Default.programmercount = comboProgrammer.Items.Count;
            AVRHexUploader.Properties.Settings.Default.Save();
        }

        private void buttonLocate_Click(object sender, EventArgs e)
        {
            openAVRDude.ShowDialog();
            avrdudeLocation = openAVRDude.FileName;
            AVRHexUploader.Properties.Settings.Default.avrdude = avrdudeLocation;

            openConf.ShowDialog();
            confLocation = openConf.FileName;
            AVRHexUploader.Properties.Settings.Default.conf = confLocation;

        }

        private void finishedProcess(string output)
        {
            // Returned console output to the display
            textBoxOutput.Text = output;

            // Reset all the window chrome back to normal
            FormUpload.ActiveForm.Cursor = Cursors.Arrow;
            textBoxOutput.Cursor = Cursors.IBeam;
            FormUpload.ActiveForm.Text = appName;

            // Scroll to the end of the text box to show the important data
            textBoxOutput.SelectionStart = textBoxOutput.Text.Length;
            textBoxOutput.ScrollToCaret();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // This is the default response, it gets replaced if everything runs smoothly.
            string returnText = "Nothing was returned. Perhaps the command didn't run at all?";
            try
            {
                Process avrprog = new Process();
                StreamReader avrstdout, avrstderr;
                StreamWriter avrstdin;
                string command = (string)e.Argument;
                
                ProcessStartInfo psI = new ProcessStartInfo("cmd");
                psI.UseShellExecute = false;
                psI.RedirectStandardInput = true;
                psI.RedirectStandardOutput = true;
                psI.RedirectStandardError = true;
                psI.CreateNoWindow = true;
                avrprog.StartInfo = psI;
                avrprog.Start();
                avrstdin = avrprog.StandardInput;
                avrstdout = avrprog.StandardOutput;
                avrstderr = avrprog.StandardError;
                avrstdin.AutoFlush = true;
                avrstdin.WriteLine(command);
                avrstdin.Close();
                returnText = avrstdout.ReadToEnd();
                returnText += avrstderr.ReadToEnd();
            }
            catch (Exception exc)
            {
                MessageBox.Show("There was a problem executing this command. Check that you have the correct programmer selected and it is connected properly. \r\n\r\n" +
                                "(" + exc.Message + ")",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
            }

            // Update the UI, we're done here.
            Invoke(new finishedProcessDelegate(finishedProcess), returnText);

            // Fin.
        }

    }
}
