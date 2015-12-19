namespace ArduinoDoorbell
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblSerial = new System.Windows.Forms.Label();
            this.lblSerialValue = new System.Windows.Forms.Label();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnNoCoffee = new System.Windows.Forms.Button();
            this.lblHeartbeat = new System.Windows.Forms.Label();
            this.cbSoundOnly = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(18, 169);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Location = new System.Drawing.Point(87, 169);
            this.lblStatusValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(73, 20);
            this.lblStatusValue.TabIndex = 1;
            this.lblStatusValue.Text = "unknown";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(22, 18);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 35);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(22, 63);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(112, 35);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(18, 206);
            this.lblSerial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(92, 20);
            this.lblSerial.TabIndex = 5;
            this.lblSerial.Text = "Serial Data:";
            // 
            // lblSerialValue
            // 
            this.lblSerialValue.AutoSize = true;
            this.lblSerialValue.Location = new System.Drawing.Point(120, 206);
            this.lblSerialValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerialValue.Name = "lblSerialValue";
            this.lblSerialValue.Size = new System.Drawing.Size(13, 20);
            this.lblSerialValue.TabIndex = 6;
            this.lblSerialValue.Text = " ";
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(180, 18);
            this.cbComPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(180, 28);
            this.cbComPort.TabIndex = 7;
            // 
            // btnCoffee
            // 
            this.btnCoffee.Location = new System.Drawing.Point(22, 108);
            this.btnCoffee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(112, 35);
            this.btnCoffee.TabIndex = 8;
            this.btnCoffee.Text = "Coffee";
            this.btnCoffee.UseVisualStyleBackColor = true;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnNoCoffee
            // 
            this.btnNoCoffee.Location = new System.Drawing.Point(146, 108);
            this.btnNoCoffee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNoCoffee.Name = "btnNoCoffee";
            this.btnNoCoffee.Size = new System.Drawing.Size(112, 35);
            this.btnNoCoffee.TabIndex = 9;
            this.btnNoCoffee.Text = "No Coffee";
            this.btnNoCoffee.UseVisualStyleBackColor = true;
            this.btnNoCoffee.Click += new System.EventHandler(this.btnNoCoffee_Click);
            // 
            // lblHeartbeat
            // 
            this.lblHeartbeat.AutoSize = true;
            this.lblHeartbeat.Location = new System.Drawing.Point(176, 71);
            this.lblHeartbeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeartbeat.Name = "lblHeartbeat";
            this.lblHeartbeat.Size = new System.Drawing.Size(78, 20);
            this.lblHeartbeat.TabIndex = 10;
            this.lblHeartbeat.Text = "heartbeat";
            this.lblHeartbeat.Visible = false;
            // 
            // cbSoundOnly
            // 
            this.cbSoundOnly.AutoSize = true;
            this.cbSoundOnly.Location = new System.Drawing.Point(298, 206);
            this.cbSoundOnly.Name = "cbSoundOnly";
            this.cbSoundOnly.Size = new System.Drawing.Size(117, 24);
            this.cbSoundOnly.TabIndex = 11;
            this.cbSoundOnly.Text = "Sound Only";
            this.cbSoundOnly.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 240);
            this.Controls.Add(this.cbSoundOnly);
            this.Controls.Add(this.lblHeartbeat);
            this.Controls.Add(this.btnNoCoffee);
            this.Controls.Add(this.btnCoffee);
            this.Controls.Add(this.cbComPort);
            this.Controls.Add(this.lblSerialValue);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblStatusValue);
            this.Controls.Add(this.lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "John\'s Arduino Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label lblSerialValue;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnNoCoffee;
        private System.Windows.Forms.Label lblHeartbeat;
        private System.Windows.Forms.CheckBox cbSoundOnly;
    }
}

