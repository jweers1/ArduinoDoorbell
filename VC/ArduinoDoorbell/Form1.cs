using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  

namespace ArduinoDoorbell
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort1;


        public Form1()
        {
            InitializeComponent();
           
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string line = serialPort1.ReadLine();
                this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
            }
         
        }

        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {
            //What to do with the received line here
            //lblSerialValue.Text = line;

            //line.TrimEnd('\r','\n');
            switch (line.TrimEnd('\r','\n'))
            {
                case "Arduino Doorbell":
                    lblSerialValue.Text = "Arduino is online";
                    break;
                case "Available Option: Coffee":
                    btnCoffee.Visible = true;
                    btnNoCoffee.Visible = true;
                    break;
                case "Doorbell Pressed":
                    const string message = "You have a visitor";
                    const string caption = "Doorbell";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Heartbeat":
                    lblHeartbeat.Visible = !lblHeartbeat.Visible;
                    break;
                default:
                    lblSerialValue.Text = "RCV: " + line;
                    break;
            }

            //label2.text = int.Parse(line);
        }

    private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1 = new SerialPort();

            cbComPort.Items.AddRange(SerialPort.GetPortNames());
            cbComPort.SelectedIndex = 0;

            btnCoffee.Visible = false;
            btnNoCoffee.Visible = false;

        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try {
                serialPort1.PortName = (string)cbComPort.SelectedItem;
                serialPort1.BaudRate = 9600;
                serialPort1.DtrEnable = true;
                serialPort1.Open();

                serialPort1.DataReceived += serialPort1_DataReceived;

                btnDisconnect.Enabled = true;
                btnConnect.Enabled = false;
                lblStatusValue.Text = "Connected";
            }
            catch (Exception ex)
            {
                lblStatusValue.Text = ex.Message;
            }

        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnCoffee.Visible = false;
            btnNoCoffee.Visible = false;
            lblStatusValue.Text = "Disconnected";
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("Coffee");
            }
        }

        private void btnNoCoffee_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("No Coffee");
            }
        }
    }
}
