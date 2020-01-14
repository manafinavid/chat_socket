using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace chat_socket
{
    public partial class server_ : Form
    {
        static TcpListener server;
        static TcpClient Client;
        byte[] buffer = new byte[512];
        public server_()
        {
            InitializeComponent();
        }
        private void main_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (B.Text == "&Connect")
            {
                portbox.Enabled = false;
                ipbox.Enabled = false;
                IPAddress IP;
                int port;
                IPAddress.TryParse(ipbox.Text, out IP);
                int.TryParse(portbox.Text, out port);
                server = new TcpListener(IP, port);
                server.Start();
                connect.Text = "&Disconnect";
                
                server.BeginAcceptTcpClient(Callback, server);
            }
            else {try { server.Server.Close();Client.Close(); } catch { }; connect.Text = "&Connect"; portbox.Enabled =true;ipbox.Enabled = true;
            }
            
        
        }
        private void Callback(IAsyncResult ar)
        {
            TcpListener socket = (TcpListener)ar.AsyncState;
            try
            {
               Client=  socket.EndAcceptTcpClient(ar);
               Client.GetStream().BeginRead(buffer, 0, buffer.Length, getstream, Client);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void getstream(IAsyncResult ar)
        {

            TcpClient tcp;
            int i=0;
            string massage;
            tcp = (TcpClient)ar.AsyncState;
            try {i = tcp.GetStream().EndRead(ar); }catch(Exception ex) { }
            if (i == 0)
            {
                MessageBox.Show("Disconnected.!");
                return;
            }
            massage = Encoding.Unicode.GetString(buffer, 0, i);
            print("[Client] :"+massage,1);
            tcp.GetStream().BeginRead(buffer, 0, buffer.Length, getstream, tcp);
        }
        int color;
        void print(string m,int i)
        {
            color = i;
            richTextBox1.Invoke(new Action<string>(doinvoke), m);
        }
        void doinvoke(string m)
        {
            String i = (m + Environment.NewLine );
            richTextBox1.Text =i+ richTextBox1.Text;
            //richTextBox1.Select(0, 1);
            //MessageBox.Show(richTextBox1.SelectedText.ToString());
            //if (color == 0) richTextBox1.SelectionColor = Color.Blue;
            //if (color == 1) richTextBox1.SelectionColor = Color.Red;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                if ( textBox3.Text!="")if(Client.Connected == true)
                {
                    byte[] s;
                    s = new byte[1024];
                    s = Encoding.Unicode.GetBytes(textBox3.Text);
                    Client.GetStream().Write(s, 0, s.Length);
                    print("[Server] :" + textBox3.Text, 0);
                    textBox3.Text = null;
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                byte[] s;
                s= File.ReadAllBytes(openFileDialog1.FileName);
                Client.GetStream().Write(s,0,s.Length);
            }
          
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {if(richTextBox1.Text != "")
           if( MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo)==DialogResult.Yes)
            richTextBox1.Text = null;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {
               if (e.KeyChar.ToString()=="\r"&&textBox3.Text!="")if(Client.Connected == true)
            {
                    byte[] s;
                    s = new byte[1024];
                    s = Encoding.Unicode.GetBytes(textBox3.Text);
                    Client.GetStream().Write(s, 0, s.Length);
                    print("[Server] :" + textBox3.Text, 0);
                    textBox3.Text = null;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }
    }
}
