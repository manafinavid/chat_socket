using System;
using System.Windows.Forms;

namespace chat_socket
{
    partial class clinet_
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
            this.button1 = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ipbox = new System.Windows.Forms.TextBox();
            this.portbox = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "Send &File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(162, 270);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(204, 23);
            this.send.TabIndex = 14;
            this.send.Text = "&Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(162, 247);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 20);
            this.textBox3.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(366, 241);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // ipbox
            // 
            this.ipbox.Location = new System.Drawing.Point(12, 247);
            this.ipbox.Name = "ipbox";
            this.ipbox.Size = new System.Drawing.Size(144, 20);
            this.ipbox.TabIndex = 11;
            this.ipbox.Text = "192.168.1.104";
            // 
            // portbox
            // 
            this.portbox.Location = new System.Drawing.Point(12, 273);
            this.portbox.Name = "portbox";
            this.portbox.Size = new System.Drawing.Size(59, 20);
            this.portbox.TabIndex = 10;
            this.portbox.Text = "8080";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(77, 270);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(79, 23);
            this.connect.TabIndex = 9;
            this.connect.Text = "&Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(375, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(375, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 46);
            this.button2.TabIndex = 16;
            this.button2.Text = "&Clear Chat";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // clinet_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ipbox);
            this.Controls.Add(this.portbox);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "clinet_";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox ipbox;
        private System.Windows.Forms.TextBox portbox;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}