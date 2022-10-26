namespace dy_Nextion_Kripto_Takip
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comPort = new System.Windows.Forms.ComboBox();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baglan_Buton = new System.Windows.Forms.Button();
            this.gonder_Buton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comPort);
            this.groupBox2.Controls.Add(this.baudRate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.baglan_Buton);
            this.groupBox2.Location = new System.Drawing.Point(22, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(368, 183);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bağlantı Ayarları";
            // 
            // comPort
            // 
            this.comPort.FormattingEnabled = true;
            this.comPort.Location = new System.Drawing.Point(130, 33);
            this.comPort.Margin = new System.Windows.Forms.Padding(6);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(218, 32);
            this.comPort.TabIndex = 6;
            this.comPort.Text = "COM4";
            // 
            // baudRate
            // 
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Location = new System.Drawing.Point(130, 79);
            this.baudRate.Margin = new System.Windows.Forms.Padding(6);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(218, 32);
            this.baudRate.TabIndex = 5;
            this.baudRate.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud rate: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM:";
            // 
            // baglan_Buton
            // 
            this.baglan_Buton.Location = new System.Drawing.Point(16, 133);
            this.baglan_Buton.Margin = new System.Windows.Forms.Padding(6);
            this.baglan_Buton.Name = "baglan_Buton";
            this.baglan_Buton.Size = new System.Drawing.Size(336, 39);
            this.baglan_Buton.TabIndex = 1;
            this.baglan_Buton.Text = "Bağlan";
            this.baglan_Buton.UseVisualStyleBackColor = true;
            this.baglan_Buton.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gonder_Buton
            // 
            this.gonder_Buton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gonder_Buton.Location = new System.Drawing.Point(386, 44);
            this.gonder_Buton.Margin = new System.Windows.Forms.Padding(6);
            this.gonder_Buton.Name = "gonder_Buton";
            this.gonder_Buton.Size = new System.Drawing.Size(214, 161);
            this.gonder_Buton.TabIndex = 1;
            this.gonder_Buton.Text = "Başlat";
            this.gonder_Buton.UseVisualStyleBackColor = true;
            this.gonder_Buton.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 235);
            this.Controls.Add(this.gonder_Buton);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(655, 299);
            this.MinimumSize = new System.Drawing.Size(655, 299);
            this.Name = "Form1";
            this.Text = "Nextion Kripto Takip Uygulaması | devreyakan.com";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button baglan_Buton;
		private System.Windows.Forms.ComboBox baudRate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comPort;
		private System.Windows.Forms.Button gonder_Buton;
	}
}

