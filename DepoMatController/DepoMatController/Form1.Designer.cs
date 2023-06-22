namespace DepoMatController
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RefundCoverOp = new System.Windows.Forms.Button();
            this.GetMoneyOp = new System.Windows.Forms.Button();
            this.MoneyBoxOP = new System.Windows.Forms.Button();
            this.DoorUnlock = new System.Windows.Forms.Button();
            this.HaveMoney = new System.Windows.Forms.Button();
            this.RefundCoverCLO = new System.Windows.Forms.Button();
            this.GetMoneyCLO = new System.Windows.Forms.Button();
            this.MoneyBoxCLO = new System.Windows.Forms.Button();
            this.İnvestment = new System.Windows.Forms.Button();
            this.MoneyNO = new System.Windows.Forms.Button();
            this.PortListCombo = new System.Windows.Forms.ComboBox();
            this.ConnectBut = new System.Windows.Forms.Button();
            this.DisconnectBut = new System.Windows.Forms.Button();
            this.ClearBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BaudRateCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SensorStatusOp = new System.Windows.Forms.TextBox();
            this.DataBitsCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SensorStatusCLO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RefundCoverOp
            // 
            this.RefundCoverOp.BackColor = System.Drawing.Color.Transparent;
            this.RefundCoverOp.Location = new System.Drawing.Point(8, 397);
            this.RefundCoverOp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RefundCoverOp.Name = "RefundCoverOp";
            this.RefundCoverOp.Size = new System.Drawing.Size(79, 59);
            this.RefundCoverOp.TabIndex = 0;
            this.RefundCoverOp.Text = "AÇ";
            this.RefundCoverOp.UseVisualStyleBackColor = false;
            this.RefundCoverOp.Click += new System.EventHandler(this.RefundCoverOp_Click);
            // 
            // GetMoneyOp
            // 
            this.GetMoneyOp.Location = new System.Drawing.Point(106, 397);
            this.GetMoneyOp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GetMoneyOp.Name = "GetMoneyOp";
            this.GetMoneyOp.Size = new System.Drawing.Size(79, 59);
            this.GetMoneyOp.TabIndex = 1;
            this.GetMoneyOp.Text = "AÇ";
            this.GetMoneyOp.UseVisualStyleBackColor = true;
            this.GetMoneyOp.Click += new System.EventHandler(this.button2_Click);
            // 
            // MoneyBoxOP
            // 
            this.MoneyBoxOP.Location = new System.Drawing.Point(202, 397);
            this.MoneyBoxOP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoneyBoxOP.Name = "MoneyBoxOP";
            this.MoneyBoxOP.Size = new System.Drawing.Size(79, 59);
            this.MoneyBoxOP.TabIndex = 2;
            this.MoneyBoxOP.Text = "AÇ";
            this.MoneyBoxOP.UseVisualStyleBackColor = true;
            this.MoneyBoxOP.Click += new System.EventHandler(this.MoneyBoxOP_Click);
            // 
            // DoorUnlock
            // 
            this.DoorUnlock.Location = new System.Drawing.Point(298, 396);
            this.DoorUnlock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DoorUnlock.Name = "DoorUnlock";
            this.DoorUnlock.Size = new System.Drawing.Size(79, 59);
            this.DoorUnlock.TabIndex = 3;
            this.DoorUnlock.Text = "KAPAK KİLİT AÇ";
            this.DoorUnlock.UseVisualStyleBackColor = true;
            this.DoorUnlock.Click += new System.EventHandler(this.DoorUnlock_Click);
            // 
            // HaveMoney
            // 
            this.HaveMoney.Location = new System.Drawing.Point(400, 396);
            this.HaveMoney.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HaveMoney.Name = "HaveMoney";
            this.HaveMoney.Size = new System.Drawing.Size(79, 59);
            this.HaveMoney.TabIndex = 4;
            this.HaveMoney.Text = "PARA VAR";
            this.HaveMoney.UseVisualStyleBackColor = true;
            this.HaveMoney.Click += new System.EventHandler(this.HaveMoney_Click);
            // 
            // RefundCoverCLO
            // 
            this.RefundCoverCLO.Location = new System.Drawing.Point(8, 475);
            this.RefundCoverCLO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RefundCoverCLO.Name = "RefundCoverCLO";
            this.RefundCoverCLO.Size = new System.Drawing.Size(79, 59);
            this.RefundCoverCLO.TabIndex = 5;
            this.RefundCoverCLO.Text = "KAPAT";
            this.RefundCoverCLO.UseVisualStyleBackColor = true;
            this.RefundCoverCLO.Click += new System.EventHandler(this.RefundCoverCLO_Click);
            // 
            // GetMoneyCLO
            // 
            this.GetMoneyCLO.Location = new System.Drawing.Point(106, 476);
            this.GetMoneyCLO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GetMoneyCLO.Name = "GetMoneyCLO";
            this.GetMoneyCLO.Size = new System.Drawing.Size(79, 59);
            this.GetMoneyCLO.TabIndex = 6;
            this.GetMoneyCLO.Text = "KAPAT";
            this.GetMoneyCLO.UseVisualStyleBackColor = true;
            this.GetMoneyCLO.Click += new System.EventHandler(this.button7_Click);
            // 
            // MoneyBoxCLO
            // 
            this.MoneyBoxCLO.Location = new System.Drawing.Point(202, 476);
            this.MoneyBoxCLO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoneyBoxCLO.Name = "MoneyBoxCLO";
            this.MoneyBoxCLO.Size = new System.Drawing.Size(79, 59);
            this.MoneyBoxCLO.TabIndex = 7;
            this.MoneyBoxCLO.Text = "KAPAT";
            this.MoneyBoxCLO.UseVisualStyleBackColor = true;
            this.MoneyBoxCLO.Click += new System.EventHandler(this.MoneyBoxCLO_Click);
            // 
            // İnvestment
            // 
            this.İnvestment.Location = new System.Drawing.Point(252, 164);
            this.İnvestment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.İnvestment.Name = "İnvestment";
            this.İnvestment.Size = new System.Drawing.Size(101, 47);
            this.İnvestment.TabIndex = 8;
            this.İnvestment.Text = "Durum Bilgisi";
            this.İnvestment.UseVisualStyleBackColor = true;
            this.İnvestment.Click += new System.EventHandler(this.SensorStatus_Click);
            // 
            // MoneyNO
            // 
            this.MoneyNO.Location = new System.Drawing.Point(400, 475);
            this.MoneyNO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoneyNO.Name = "MoneyNO";
            this.MoneyNO.Size = new System.Drawing.Size(79, 59);
            this.MoneyNO.TabIndex = 9;
            this.MoneyNO.Text = "PARA YOK";
            this.MoneyNO.UseVisualStyleBackColor = true;
            this.MoneyNO.Click += new System.EventHandler(this.MoneyNO_Click);
            // 
            // PortListCombo
            // 
            this.PortListCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortListCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PortListCombo.Location = new System.Drawing.Point(11, 47);
            this.PortListCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PortListCombo.Name = "PortListCombo";
            this.PortListCombo.Size = new System.Drawing.Size(155, 44);
            this.PortListCombo.TabIndex = 10;
            this.PortListCombo.SelectedIndexChanged += new System.EventHandler(this.PortListCombo_SelectedIndexChanged);
            // 
            // ConnectBut
            // 
            this.ConnectBut.Location = new System.Drawing.Point(8, 164);
            this.ConnectBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConnectBut.Name = "ConnectBut";
            this.ConnectBut.Size = new System.Drawing.Size(101, 47);
            this.ConnectBut.TabIndex = 11;
            this.ConnectBut.Text = "Bağlan";
            this.ConnectBut.UseVisualStyleBackColor = true;
            this.ConnectBut.Click += new System.EventHandler(this.ConnectBut_Click);
            // 
            // DisconnectBut
            // 
            this.DisconnectBut.Location = new System.Drawing.Point(129, 164);
            this.DisconnectBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisconnectBut.Name = "DisconnectBut";
            this.DisconnectBut.Size = new System.Drawing.Size(101, 47);
            this.DisconnectBut.TabIndex = 12;
            this.DisconnectBut.Text = "Bağlantıyı Kes";
            this.DisconnectBut.UseVisualStyleBackColor = true;
            this.DisconnectBut.Click += new System.EventHandler(this.DisconnectBut_Click);
            // 
            // ClearBut
            // 
            this.ClearBut.Location = new System.Drawing.Point(375, 164);
            this.ClearBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(101, 47);
            this.ClearBut.TabIndex = 14;
            this.ClearBut.Text = "Temizle";
            this.ClearBut.UseVisualStyleBackColor = true;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Port Listesi";
            // 
            // BaudRateCombo
            // 
            this.BaudRateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BaudRateCombo.FormattingEnabled = true;
            this.BaudRateCombo.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200"});
            this.BaudRateCombo.Location = new System.Drawing.Point(184, 47);
            this.BaudRateCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BaudRateCombo.Name = "BaudRateCombo";
            this.BaudRateCombo.Size = new System.Drawing.Size(155, 44);
            this.BaudRateCombo.TabIndex = 16;
            this.BaudRateCombo.Tag = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(191, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Baud Hızı";
            // 
            // SensorStatusOp
            // 
            this.SensorStatusOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SensorStatusOp.Location = new System.Drawing.Point(518, 47);
            this.SensorStatusOp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SensorStatusOp.Multiline = true;
            this.SensorStatusOp.Name = "SensorStatusOp";
            this.SensorStatusOp.Size = new System.Drawing.Size(203, 224);
            this.SensorStatusOp.TabIndex = 18;
            this.SensorStatusOp.TextChanged += new System.EventHandler(this.SensorStatusOp_TextChanged);
            // 
            // DataBitsCombo
            // 
            this.DataBitsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBitsCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataBitsCombo.FormattingEnabled = true;
            this.DataBitsCombo.Items.AddRange(new object[] {
            "7",
            "8"});
            this.DataBitsCombo.Location = new System.Drawing.Point(358, 47);
            this.DataBitsCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataBitsCombo.Name = "DataBitsCombo";
            this.DataBitsCombo.Size = new System.Drawing.Size(128, 44);
            this.DataBitsCombo.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(365, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Veri Biti";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Para İade";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(103, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Para Düşme";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(200, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Para Torba";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 476);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 59);
            this.button1.TabIndex = 24;
            this.button1.Text = "PARA YATIRMA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.İnvestment_Click);
            // 
            // SensorStatusCLO
            // 
            this.SensorStatusCLO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SensorStatusCLO.Location = new System.Drawing.Point(518, 311);
            this.SensorStatusCLO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SensorStatusCLO.Multiline = true;
            this.SensorStatusCLO.Name = "SensorStatusCLO";
            this.SensorStatusCLO.Size = new System.Drawing.Size(203, 224);
            this.SensorStatusCLO.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(514, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Açık";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(514, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Kapalı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 584);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SensorStatusCLO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataBitsCombo);
            this.Controls.Add(this.SensorStatusOp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BaudRateCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearBut);
            this.Controls.Add(this.DisconnectBut);
            this.Controls.Add(this.ConnectBut);
            this.Controls.Add(this.PortListCombo);
            this.Controls.Add(this.MoneyNO);
            this.Controls.Add(this.İnvestment);
            this.Controls.Add(this.MoneyBoxCLO);
            this.Controls.Add(this.GetMoneyCLO);
            this.Controls.Add(this.RefundCoverCLO);
            this.Controls.Add(this.HaveMoney);
            this.Controls.Add(this.DoorUnlock);
            this.Controls.Add(this.MoneyBoxOP);
            this.Controls.Add(this.GetMoneyOp);
            this.Controls.Add(this.RefundCoverOp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(250, 100);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DepoMat Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefundCoverOp;
        private System.Windows.Forms.Button GetMoneyOp;
        private System.Windows.Forms.Button MoneyBoxOP;
        private System.Windows.Forms.Button DoorUnlock;
        private System.Windows.Forms.Button HaveMoney;
        private System.Windows.Forms.Button RefundCoverCLO;
        private System.Windows.Forms.Button GetMoneyCLO;
        private System.Windows.Forms.Button MoneyBoxCLO;
        private System.Windows.Forms.Button İnvestment;
        private System.Windows.Forms.Button MoneyNO;
        private System.Windows.Forms.ComboBox PortListCombo;
        private System.Windows.Forms.Button ConnectBut;
        private System.Windows.Forms.Button DisconnectBut;
        private System.Windows.Forms.Button ClearBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BaudRateCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SensorStatusOp;
        private System.Windows.Forms.ComboBox DataBitsCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SensorStatusCLO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

