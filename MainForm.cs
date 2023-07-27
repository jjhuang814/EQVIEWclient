using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace EQVIWEclient
{
    public partial class MainForm : Form
    {
        private IPEndPoint endPoint = null;
        private IPAddress clientIP = null;
        private TcpClient clientSocket = null;
        private NetworkStream clientNetworkStream = null;
        private string hostname = null;
        Thread threadClient = null; // 創建用於接收服務端訊息的執行緒

        public MainForm()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false; //跨執行緒處理，錯誤訊息不會出現，不過等於是違反了上述的原則，後果自負。
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 取得本機的識別名稱
            hostname = Dns.GetHostName();
            // 取得主機的DNS資訊
            clientIP = Dns.Resolve(hostname).AddressList[0];
            lblHostIP.Text = "Host IP : " + clientIP;

            btnTcpState.BackColor = Color.Red;
            btnTcpDisconnect.Enabled = false;
            btnCommandSend.Enabled = false;
            btnResponseClear.Enabled = false;
            btnRun.Enabled = false;
            btnStop.Enabled = false;
            btnPLCType.Enabled = false;
        }

        private void btnTcpConnect_Click(object sender, EventArgs e)
        {
            lstState.Items.Clear();
            lstResponse.Items.Clear();

            // 建立client端-EQVIEW
            clientSocket = new TcpClient();
            endPoint = new IPEndPoint(IPAddress.Parse(tbxServerIP.Text), Int32.Parse(tbxServerPort.Text));//服務器的IP和端口

            try
            {
                lstState.Items.Add("To Connected the server......");
                lstState.TopIndex = lstState.Items.Count - 1;
                clientSocket.Connect(endPoint);
                lstState.Items.Add("Connect the server, state : connected!!");
            }
            catch (ArgumentNullException se)
            {
                MessageBox.Show(se.Message);
                return;
            }
            catch (ArgumentOutOfRangeException se)
            {
                MessageBox.Show(se.Message);
                return;
            }
            catch (SocketException se)
            {
                lstState.Items.Add("Unable to connect the server, state : disconnected!!");
                lstState.TopIndex = lstState.Items.Count - 1;
                MessageBox.Show(se.Message);
                return;
            }

            //接收訊息的多執行緒
            threadClient = new Thread(receive);
            threadClient.IsBackground = true; //背景執行緒
            threadClient.Start();


            lstState.TopIndex = lstState.Items.Count - 1;
            btnTcpState.BackColor = Color.Green;

            tbxServerIP.Enabled = false;
            tbxServerPort.Enabled = false;
            btnTcpConnect.Enabled = false;
            btnTcpDisconnect.Enabled = true;
            btnCommandSend.Enabled = true;
            btnResponseClear.Enabled = true;
            btnRun.Enabled = true;
            btnStop.Enabled = true;
            btnPLCType.Enabled = true;

        }

        private void btnTcpDisconnect_Click(object sender, EventArgs e)
        {
            send("14FF000A");
            threadClient.Abort();
            threadClient.Join();

            lstState.Items.Clear();
            lstResponse.Items.Clear();
            txtResponse.Clear();

            lstState.Items.Add("Disconnect the server, state : disconnected!!");
            lstState.TopIndex = lstState.Items.Count - 1;
            clientSocket.Close();
            btnTcpState.BackColor = Color.Red;

            tbxServerIP.Enabled = true;
            tbxServerPort.Enabled = true;
            btnTcpConnect.Enabled = true;
            btnTcpDisconnect.Enabled = false;
            btnCommandSend.Enabled = false;
            btnResponseClear.Enabled = false;
            btnRun.Enabled = false;
            btnStop.Enabled = false;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnCommandSend_Click(object sender, EventArgs e)
        {
            if (tbxCommand.Text != "")
            {
                send(tbxCommand.Text);
            }
            else
            {
                lstResponse.Items.Clear();
                txtResponse.Clear();
                MessageBox.Show("Please keyin the command package!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void btnResponseClear_Click(object sender, EventArgs e)
        {
            tbxCommand.Clear();
            lstResponse.Items.Clear();
            txtResponse.Clear();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        //按鈕指令
        private void btnRun_Click(object sender, EventArgs e)
        {
            send("13FF000A");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            send("14FF000A");
        }

        private void btnPLCType_Click(object sender, EventArgs e)
        {
            send("15FF000A");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        //send & receive
        public void send(string sendMessage)
        {
            tbxCommand.Clear();
            lstResponse.Items.Clear();
            clientNetworkStream = clientSocket.GetStream(); //用來傳送和接收資料 for server
            if (clientNetworkStream.CanRead)
            {
                string CommandMessageBuffer = sendMessage;
                Byte[] StreamWriter = Encoding.ASCII.GetBytes(CommandMessageBuffer); // Translate data bytes to a ASCII string.
                clientNetworkStream.Write(StreamWriter, 0, StreamWriter.Length); //// Send back a response, 將資料寫入網路串流中
                lstResponse.Items.Add("Send to server : " + CommandMessageBuffer);
                Thread.Sleep(200);
            }
        }

        public void receive()
        {
            while (true)
            {
                // 定義一個2M的暫存區
                byte[] MyReadBuffer = new byte[1024 * 1024 * 2]; //空字串         

                try
                {
                    clientNetworkStream = clientSocket.GetStream(); //用來傳送和接收資料 for server
                    int StreamReader = clientNetworkStream.Read(MyReadBuffer, 0, MyReadBuffer.Length);
                    Thread.Sleep(200);
                    String ResponseMessage = Encoding.ASCII.GetString(MyReadBuffer, 0, StreamReader);
                    ShowResponseMessage(ResponseMessage);
                }
                catch (IOException se)
                {
                    //MessageBox.Show(se.Message);
                    return;
                }
                catch (ObjectDisposedException se)
                {
                    //MessageBox.Show(se.Message);
                    return;
                }

                catch (ArgumentNullException se)
                {
                    MessageBox.Show(se.Message);
                    return;
                }
                catch (ArgumentOutOfRangeException se)
                {
                    MessageBox.Show(se.Message);
                    return;
                }
                catch (SocketException se)
                {
                    MessageBox.Show(se.Message);
                    return;
                }

                //PLC型號判斷
                if (txtResponse.Text == "9500F300")
                {
                    lblPLCType.Text = "PLC Type : FX3U";
                }


                clientNetworkStream.Flush(); //排清資料流的資料
            }
        }

        void ShowResponseMessage(string str)
        {
            lstResponse.Items.Add("->Received from server : " + str);
            lstResponse.TopIndex = lstResponse.Items.Count - 1;
            txtResponse.Text = str;
        }





        ////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////



    }
}
