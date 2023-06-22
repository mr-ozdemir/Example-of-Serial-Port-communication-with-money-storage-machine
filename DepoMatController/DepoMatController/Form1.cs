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
using System.Threading;

namespace DepoMatController
{
    public partial class Form1 : Form
    {

        


    public Form1()
        {
            
            InitializeComponent();

            BaudRateCombo.SelectedItem = "9600";
            DataBitsCombo.SelectedItem = "8";

            var ports = SerialPort.GetPortNames();

            PortListCombo.DataSource = ports;
            changeallbuttonstatus(false);
        }


        private void changeallbuttonstatus(bool status)
        {
            ClearBut.Enabled = status;
            button1.Enabled = status;
            GetMoneyOp.Enabled = status;
            GetMoneyCLO.Enabled = status;
            DisconnectBut.Enabled = status;
            RefundCoverCLO.Enabled = status;
            RefundCoverOp.Enabled = status;
            MoneyBoxCLO.Enabled = status;
            MoneyBoxOP.Enabled = status;
            HaveMoney.Enabled = status;
            İnvestment.Enabled = status;
            MoneyNO.Enabled = status;
            DoorUnlock.Enabled = status;
        }


        private void ClearBut_Click(object sender, EventArgs e)
        {
            SensorStatusOp.ResetText();
            SensorStatusCLO.ResetText();
        }

        private void ConnectBut_Click(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                serialPort1.PortName = PortListCombo.Text;
                serialPort1.BaudRate = int.Parse(BaudRateCombo.Text);
                serialPort1.DataReceived += datareceived;
                serialPort1.Open();
                if (serialPort1.IsOpen)
                    MessageBox.Show("Bağlandı");
                ConnectBut.Enabled = false;
                changeallbuttonstatus(true);
                
            }

            catch
            {
                changeallbuttonstatus(false);
                MessageBox.Show("Bağlanamadı");


            }
        }

        

        void datareceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);
            byte[] data = new byte[serialPort1.BytesToRead];
            while (serialPort1.BytesToRead > 0)
            {
                serialPort1.Read(data, 0, serialPort1.BytesToRead);
            }
            Console.Write(data);

          


            if (data.Length >= 7)
            {
                if (data[0] == 0)
                    AppendTextBoxClo("Para Düşme" + Environment.NewLine);
                     
                else
                    AppendTextBox("Para Düşme" + Environment.NewLine);
                    
                 
       
                if (data[1] == 0)
                    AppendTextBoxClo("Para İade" + Environment.NewLine);
                    
                else
                    AppendTextBox("Para İade" + Environment.NewLine);

                if (data[2] == 0)

                    AppendTextBoxClo("Kasa Kapağı" + Environment.NewLine);
                else
                    AppendTextBox("Kasa Kapağı" + Environment.NewLine);

                if (data[3] == 0)
                    AppendTextBox("Üst Kapak" + Environment.NewLine);
                else
                    AppendTextBoxClo("Üst Kapak" + Environment.NewLine);

                if (data[4] == 0)
                    AppendTextBox("Para Torbası" + Environment.NewLine);
                else
                    AppendTextBoxClo("Para Torbası" + Environment.NewLine);

                if (data[5] == 0)
                    AppendTextBoxClo("Para Torbası Kapağı" + Environment.NewLine);
                else
                    AppendTextBox("Para Torbası Kapağı" + Environment.NewLine);

                if (data[6] == 0)
                    AppendTextBox("Bilgisayar Kapağı" + Environment.NewLine);
                else
                    AppendTextBoxClo("Bilgisayar Kapağı" + Environment.NewLine);

                if (data[7] == 0)
                    AppendTextBoxClo("Servis Kapağı" + Environment.NewLine);
                else
                    AppendTextBox("Servis Kapağı" + Environment.NewLine);
            }

            

            //AppendTextBox(System.Text.Encoding.UTF8.GetString(data));




        }
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            SensorStatusOp.Text += value;
        }

        public void AppendTextBoxClo(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBoxClo), new object[] { value });
                return;
            }
            SensorStatusCLO.Text += value;
        }





        private void DisconnectBut_Click(object sender, EventArgs e)
        {
      
            serialPort1.Close();
            MessageBox.Show("Bağlantı Sonlandırıldı");
            SensorStatusOp.Text = "";
            SensorStatusCLO.Text = "";
            changeallbuttonstatus(false);
            ConnectBut.Enabled = true;
        }
        public void DataSend()
        {
 
        }


        private void RefundCoverOp_Click(object sender, EventArgs e)
        {
            Byte[] RefundOPAry = new Byte[1];
            RefundOPAry[0] = 1;
            serialPort1.Write(RefundOPAry, 0, 1);

        }

        private void RefundCoverCLO_Click(object sender, EventArgs e)
        {
            Byte[] RefungCLOAry = new Byte[1];
            RefungCLOAry[0] = 2;
            serialPort1.Write(RefungCLOAry, 0, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Byte[]But2Ayr  = new Byte[1];
            But2Ayr[0] = 3;
            serialPort1.Write(But2Ayr, 0, 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Byte[] But7Ayr = new Byte[1];
            But7Ayr[0] = 4;
            serialPort1.Write(But7Ayr, 0, 1);
        }

        private void MoneyBoxOP_Click(object sender, EventArgs e)
        {
            Byte[] MoneyBoxOpAry = new Byte[1];
            MoneyBoxOpAry[0] = 5;
            serialPort1.Write(MoneyBoxOpAry, 0, 1);
        }

        private void MoneyBoxCLO_Click(object sender, EventArgs e)
        {
            Byte[] MoneyBoxCloAry = new Byte[1];
            MoneyBoxCloAry[0] = 6;
            serialPort1.Write(MoneyBoxCloAry, 0, 1);
        }

        private void DoorUnlock_Click(object sender, EventArgs e)
        {
            Byte[] DoorUnlAyr = new Byte[1];
            DoorUnlAyr[0] = 7;
            serialPort1.Write(DoorUnlAyr, 0, 1);
        }

        private void SensorStatus_Click(object sender, EventArgs e)
        {
            SensorStatusCLO.Text = "";
            SensorStatusOp.Text = "";
            Byte[] SensorstatAry = new Byte[1];
            SensorstatAry[0] = 8;
            serialPort1.Write(SensorstatAry, 0, 1);

        }

        private void İnvestment_Click(object sender, EventArgs e)
        {
            Byte[] İnvestmentAry = new Byte[1];
            İnvestmentAry[0] = 9;
            serialPort1.Write(İnvestmentAry, 0, 1);

        }
    

        private void HaveMoney_Click(object sender, EventArgs e)
        {
            Byte[] Havemoney = new Byte[1];
            Havemoney[0] = (byte)10;
            serialPort1.Write(Havemoney,0,1);

        }

        private void MoneyNO_Click(object sender, EventArgs e)
        {
            Byte[] MoneyNoAry = new Byte[1];
            MoneyNoAry[0] = (byte)11; 
            serialPort1.Write(MoneyNoAry, 0, 1);

        }

        private void PortListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
