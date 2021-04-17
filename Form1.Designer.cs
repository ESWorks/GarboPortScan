namespace PortScan
{
    partial class PortScan
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
            this.port_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ipadr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeout = new System.Windows.Forms.NumericUpDown();
            this.nsport = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.neport = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.portProg = new System.Windows.Forms.ProgressBar();
            this.tport = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sscan = new System.Windows.Forms.ProgressBar();
            this.lbl7 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fscan = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neport)).BeginInit();
            this.SuspendLayout();
            // 
            // port_type
            // 
            this.port_type.FormattingEnabled = true;
            this.port_type.Items.AddRange(new object[] {
            "UDP",
            "TCP"});
            this.port_type.Location = new System.Drawing.Point(118, 6);
            this.port_type.Name = "port_type";
            this.port_type.Size = new System.Drawing.Size(76, 21);
            this.port_type.TabIndex = 0;
            this.port_type.Text = "UDP";
            this.port_type.SelectedIndexChanged += new System.EventHandler(this.port_type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Port Scan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target Address";
            // 
            // ipadr
            // 
            this.ipadr.Location = new System.Drawing.Point(12, 55);
            this.ipadr.Name = "ipadr";
            this.ipadr.Size = new System.Drawing.Size(182, 20);
            this.ipadr.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Timeout";
            // 
            // timeout
            // 
            this.timeout.Location = new System.Drawing.Point(12, 104);
            this.timeout.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.timeout.Name = "timeout";
            this.timeout.Size = new System.Drawing.Size(182, 20);
            this.timeout.TabIndex = 6;
            // 
            // nsport
            // 
            this.nsport.Location = new System.Drawing.Point(12, 154);
            this.nsport.Maximum = new decimal(new int[] {
            32676,
            0,
            0,
            0});
            this.nsport.Name = "nsport";
            this.nsport.Size = new System.Drawing.Size(76, 20);
            this.nsport.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port Start";
            // 
            // neport
            // 
            this.neport.Location = new System.Drawing.Point(118, 154);
            this.neport.Maximum = new decimal(new int[] {
            32676,
            0,
            0,
            0});
            this.neport.Name = "neport";
            this.neport.Size = new System.Drawing.Size(76, 20);
            this.neport.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Port End";
            // 
            // portProg
            // 
            this.portProg.Location = new System.Drawing.Point(12, 193);
            this.portProg.Name = "portProg";
            this.portProg.Size = new System.Drawing.Size(182, 10);
            this.portProg.TabIndex = 11;
            // 
            // tport
            // 
            this.tport.AutoSize = true;
            this.tport.Location = new System.Drawing.Point(12, 206);
            this.tport.Name = "tport";
            this.tport.Size = new System.Drawing.Size(72, 13);
            this.tport.TabIndex = 12;
            this.tport.Text = "Targeted Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Scanned";
            // 
            // sscan
            // 
            this.sscan.Location = new System.Drawing.Point(12, 246);
            this.sscan.Name = "sscan";
            this.sscan.Size = new System.Drawing.Size(182, 10);
            this.sscan.TabIndex = 14;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(9, 230);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(87, 13);
            this.lbl7.TabIndex = 15;
            this.lbl7.Text = "Successful Scan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Failed Scan";
            // 
            // fscan
            // 
            this.fscan.Location = new System.Drawing.Point(12, 275);
            this.fscan.Name = "fscan";
            this.fscan.Size = new System.Drawing.Size(182, 10);
            this.fscan.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Stop Scan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PortScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 328);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fscan);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.sscan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tport);
            this.Controls.Add(this.portProg);
            this.Controls.Add(this.neport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nsport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipadr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PortScan";
            this.ShowIcon = false;
            this.Text = "Port Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.timeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nsport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox port_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipadr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown timeout;
        private System.Windows.Forms.NumericUpDown nsport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown neport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar portProg;
        private System.Windows.Forms.Label tport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar sscan;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar fscan;
        private System.Windows.Forms.Button button2;
    }
}

