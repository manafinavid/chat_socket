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
    public partial class clinet_ : Form
    {
        byte[] buffer=new byte[1024];
        TcpClient Client;
        public clinet_()
        {
            InitializeComponent();
        }
        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void connect_Click(object sender, EventArgs e)
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
                Client = new TcpClient();
                Client.BeginConnect(IP, port, completeconnect, Client);
            }
        }
        void completeconnect(IAsyncResult ar)
        {
            TcpClient tcp;
            try
            {
                tcp = (TcpClient)ar.AsyncState;
                tcp.EndConnect(ar);
                tcp.GetStream().BeginRead(buffer, 0, buffer.Length, read, tcp);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void read(IAsyncResult ar)
        {
            TcpClient tcp;
            string a;
            int i;
            try
            {
                tcp = (TcpClient)ar.AsyncState;
                i = tcp.GetStream().EndRead(ar);
                if (i == 0)
                    MessageBox.Show("Disconecced!");
                a = Encoding.Unicode.GetString(buffer, 0, i);
                print("[Server] :" + a);
                buffer = new byte[1024];
                tcp.GetStream().BeginRead(buffer, 0, buffer.Length, read, tcp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void print(string m)
        {
            
            richTextBox1.Invoke(new Action<string>(doinvoke), m);
        }
        void doinvoke(string m)
        {
            String i = (m + Environment.NewLine);
            richTextBox1.Text = i + richTextBox1.Text;
            //richTextBox1.Select(0, 1);
            //MessageBox.Show(richTextBox1.SelectedText.ToString());
            //if (color == 0) richTextBox1.SelectionColor = Color.Blue;
            //if (color == 1) richTextBox1.SelectionColor = Color.Red;
        }
        private void send_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "") return;
            byte[] tx;
            try
            {
                tx = Encoding.Unicode.GetBytes(textBox3.Text);
                if(Client!=null)
                {
                    if (Client.Client.Connected)
                    {
                        Client.GetStream().Write(tx, 0, tx.Length);
                        print("[Client] :" + textBox3.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
