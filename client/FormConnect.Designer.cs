﻿namespace Client
{
    partial class FormConnect
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label1;
            Label label2;
            textBox_host = new TextBox();
            textBox_port = new TextBox();
            button_connect = new Button();
            button_exit = new Button();
            button_mini = new Button();
            button_debug = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(36, 88);
            label1.Margin = new Padding(3, 0, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 0;
            label1.Text = "服务器";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(287, 88);
            label2.Margin = new Padding(3, 0, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 2;
            label2.Text = "端口";
            // 
            // textBox_host
            // 
            textBox_host.Cursor = Cursors.IBeam;
            textBox_host.Font = new Font("Microsoft YaHei UI", 10.5F);
            textBox_host.Location = new Point(94, 86);
            textBox_host.Margin = new Padding(0, 3, 3, 3);
            textBox_host.Name = "textBox_host";
            textBox_host.Size = new Size(180, 25);
            textBox_host.TabIndex = 1;
            // 
            // textBox_port
            // 
            textBox_port.Cursor = Cursors.IBeam;
            textBox_port.Font = new Font("Microsoft YaHei UI", 10.5F);
            textBox_port.Location = new Point(329, 86);
            textBox_port.Margin = new Padding(0, 3, 3, 3);
            textBox_port.Name = "textBox_port";
            textBox_port.PlaceholderText = "0~65535";
            textBox_port.Size = new Size(69, 25);
            textBox_port.TabIndex = 3;
            // 
            // button_connect
            // 
            button_connect.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button_connect.Location = new Point(159, 180);
            button_connect.Name = "button_connect";
            button_connect.Size = new Size(146, 41);
            button_connect.TabIndex = 4;
            button_connect.Text = "连接";
            button_connect.UseVisualStyleBackColor = true;
            button_connect.Click += button_connect_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(366, 259);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(75, 23);
            button_exit.TabIndex = 5;
            button_exit.Text = "退出";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_mini
            // 
            button_mini.Location = new Point(266, 259);
            button_mini.Name = "button_mini";
            button_mini.Size = new Size(75, 23);
            button_mini.TabIndex = 6;
            button_mini.Text = "最小化";
            button_mini.UseVisualStyleBackColor = true;
            button_mini.Click += button_mini_Click;
            // 
            // button_debug
            // 
            button_debug.Location = new Point(141, 259);
            button_debug.Name = "button_debug";
            button_debug.Size = new Size(75, 23);
            button_debug.TabIndex = 7;
            button_debug.Text = "debug";
            button_debug.UseVisualStyleBackColor = true;
            button_debug.Click += button_debug_Click;
            // 
            // FormConnect
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = client.Properties.Resources.background2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(464, 321);
            ControlBox = false;
            Controls.Add(button_debug);
            Controls.Add(button_mini);
            Controls.Add(button_exit);
            Controls.Add(button_connect);
            Controls.Add(textBox_port);
            Controls.Add(label2);
            Controls.Add(textBox_host);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FormConnect";
            Text = "游戏标题";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_host;
        private Label label2;
        private TextBox textBox_port;
        private Button button_connect;
        private Button button_exit;
        private Button button_mini;
        private Button button_debug;
    }
}
