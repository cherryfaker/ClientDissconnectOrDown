namespace TcpIpServer
{
    partial class IpServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.IpBox = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.ListenerB = new System.Windows.Forms.Button();
            this.ClientCombox = new System.Windows.Forms.ComboBox();
            this.ServerLog = new System.Windows.Forms.RichTextBox();
            this.SendText = new System.Windows.Forms.RichTextBox();
            this.CloseB = new System.Windows.Forms.Button();
            this.SendB = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IpBox
            // 
            this.IpBox.Location = new System.Drawing.Point(13, 28);
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(100, 21);
            this.IpBox.TabIndex = 0;
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(132, 27);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(100, 21);
            this.PortBox.TabIndex = 1;
            // 
            // ListenerB
            // 
            this.ListenerB.Location = new System.Drawing.Point(257, 28);
            this.ListenerB.Name = "ListenerB";
            this.ListenerB.Size = new System.Drawing.Size(108, 23);
            this.ListenerB.TabIndex = 2;
            this.ListenerB.Text = "Start Listening";
            this.ListenerB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListenerB.UseVisualStyleBackColor = true;
            this.ListenerB.Click += new System.EventHandler(this.listnerB_Click);
            // 
            // ClientCombox
            // 
            this.ClientCombox.FormattingEnabled = true;
            this.ClientCombox.Location = new System.Drawing.Point(371, 31);
            this.ClientCombox.Name = "ClientCombox";
            this.ClientCombox.Size = new System.Drawing.Size(121, 20);
            this.ClientCombox.TabIndex = 3;
            // 
            // ServerLog
            // 
            this.ServerLog.Location = new System.Drawing.Point(13, 90);
            this.ServerLog.Name = "ServerLog";
            this.ServerLog.Size = new System.Drawing.Size(306, 154);
            this.ServerLog.TabIndex = 4;
            this.ServerLog.Text = "";
            // 
            // SendText
            // 
            this.SendText.Location = new System.Drawing.Point(12, 266);
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(307, 178);
            this.SendText.TabIndex = 5;
            this.SendText.Text = "";
            // 
            // CloseB
            // 
            this.CloseB.Location = new System.Drawing.Point(354, 171);
            this.CloseB.Name = "CloseB";
            this.CloseB.Size = new System.Drawing.Size(113, 23);
            this.CloseB.TabIndex = 6;
            this.CloseB.Text = "Close Listening";
            this.CloseB.UseVisualStyleBackColor = true;
            this.CloseB.Click += new System.EventHandler(this.Close_Click);
            // 
            // SendB
            // 
            this.SendB.Location = new System.Drawing.Point(354, 369);
            this.SendB.Name = "SendB";
            this.SendB.Size = new System.Drawing.Size(113, 23);
            this.SendB.TabIndex = 7;
            this.SendB.Text = "Send";
            this.SendB.UseVisualStyleBackColor = true;
            this.SendB.Click += new System.EventHandler(this.SendB_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 12);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "IpBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "PortBox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "ListenerB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "ClientCombox";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "ServerLog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "SendText";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "CloseB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "SendB";
            // 
            // IpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 501);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.SendB);
            this.Controls.Add(this.CloseB);
            this.Controls.Add(this.SendText);
            this.Controls.Add(this.ServerLog);
            this.Controls.Add(this.ClientCombox);
            this.Controls.Add(this.ListenerB);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.IpBox);
            this.Name = "IpServer";
            this.Text = "Ipserver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IpBox;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Button ListenerB;
        private System.Windows.Forms.ComboBox ClientCombox;
        private System.Windows.Forms.RichTextBox ServerLog;
        private System.Windows.Forms.RichTextBox SendText;
        private System.Windows.Forms.Button CloseB;
        private System.Windows.Forms.Button SendB;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

