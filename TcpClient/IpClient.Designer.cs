namespace TcpClient
{
    partial class IpClient
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
            this.ConnectB = new System.Windows.Forms.Button();
            this.CloseB = new System.Windows.Forms.Button();
            this.ClientLog = new System.Windows.Forms.RichTextBox();
            this.SendText = new System.Windows.Forms.RichTextBox();
            this.Send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IpBox
            // 
            this.IpBox.Location = new System.Drawing.Point(23, 27);
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(100, 21);
            this.IpBox.TabIndex = 0;
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(160, 27);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(100, 21);
            this.PortBox.TabIndex = 1;
            // 
            // ConnectB
            // 
            this.ConnectB.Location = new System.Drawing.Point(312, 27);
            this.ConnectB.Name = "ConnectB";
            this.ConnectB.Size = new System.Drawing.Size(75, 23);
            this.ConnectB.TabIndex = 2;
            this.ConnectB.Text = "Connect";
            this.ConnectB.UseVisualStyleBackColor = true;
            this.ConnectB.Click += new System.EventHandler(this.ConnectB_Click);
            // 
            // CloseB
            // 
            this.CloseB.Location = new System.Drawing.Point(428, 27);
            this.CloseB.Name = "CloseB";
            this.CloseB.Size = new System.Drawing.Size(75, 23);
            this.CloseB.TabIndex = 3;
            this.CloseB.Text = "Disconnect";
            this.CloseB.UseVisualStyleBackColor = true;
            this.CloseB.Click += new System.EventHandler(this.CloseB_Click);
            // 
            // ClientLog
            // 
            this.ClientLog.Location = new System.Drawing.Point(23, 78);
            this.ClientLog.Name = "ClientLog";
            this.ClientLog.Size = new System.Drawing.Size(480, 168);
            this.ClientLog.TabIndex = 4;
            this.ClientLog.Text = "";
            // 
            // SendText
            // 
            this.SendText.Location = new System.Drawing.Point(23, 276);
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(480, 158);
            this.SendText.TabIndex = 5;
            this.SendText.Text = "";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(191, 463);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(91, 29);
            this.Send.TabIndex = 6;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.SendB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "IpBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "PortBox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "ConnectB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "CloseB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "ClientLog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "SendText";
            // 
            // IpClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 504);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.SendText);
            this.Controls.Add(this.ClientLog);
            this.Controls.Add(this.CloseB);
            this.Controls.Add(this.ConnectB);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.IpBox);
            this.Name = "IpClient";
            this.Text = "IpClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IpBox;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Button ConnectB;
        private System.Windows.Forms.Button CloseB;
        private System.Windows.Forms.RichTextBox ClientLog;
        private System.Windows.Forms.RichTextBox SendText;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

