using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortApp
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            LoadAvailablePorts();
            buttonDisconnect.Enabled = false;
        }
        private void LoadAvailablePorts()
        {
            comboBoxPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.AddRange(ports);
        }

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            if (comboBoxPorts.SelectedItem == null)
            {
                MessageBox.Show("Please select a COM port.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedPort = comboBoxPorts.SelectedItem.ToString();
            try
            {
                serialPort = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
                MessageBox.Show("Port opened successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonOpenPort.Text = "Connected";
                buttonOpenPort.Enabled = false;
                buttonDisconnect.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                MessageBox.Show("Port closed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonOpenPort.Text = "OPEN";
                buttonOpenPort.Enabled = true;
                buttonDisconnect.Enabled = false;
            }
            else
            {
                MessageBox.Show("Port is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadExisting();
            Invoke(new Action(() => textBoxOutput.AppendText(data + "\n")));
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine(textBoxCommand.Text);
                //textBoxCommand.Clear();
            }
            else
            {
                MessageBox.Show("Port is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonOpenDeviceManager_Click(object sender, EventArgs e)
        {
            Process.Start("devmgmt.msc");
        }
        private void clearOutputButton_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void buttonSPdiagnostic_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("*SP");
                //textBoxCommand.Clear();
            }
            else
            {
                MessageBox.Show("Port is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCommand.Text = "*SP";
            }
        }
        private void buttonUnlockCommand_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine("*UC89C7");
                //textBoxCommand.Clear();
            }
            else
            {
                MessageBox.Show("Port is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCommand.Text = "*UC89C7";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
