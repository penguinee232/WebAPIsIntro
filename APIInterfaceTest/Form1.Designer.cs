﻿namespace APIInterfaceTest
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
            this.messageDisplay = new System.Windows.Forms.ListBox();
            this.msg = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // messageDisplay
            // 
            this.messageDisplay.FormattingEnabled = true;
            this.messageDisplay.HorizontalScrollbar = true;
            this.messageDisplay.Location = new System.Drawing.Point(32, 27);
            this.messageDisplay.Name = "messageDisplay";
            this.messageDisplay.Size = new System.Drawing.Size(756, 199);
            this.messageDisplay.TabIndex = 0;
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(32, 267);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(756, 20);
            this.msg.TabIndex = 1;
            this.msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msg_KeyDown);
            this.msg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msg_KeyPress);
            this.msg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.msg_KeyUp);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(32, 241);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(377, 20);
            this.name.TabIndex = 2;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(32, 293);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(756, 23);
            this.send.TabIndex = 3;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 327);
            this.Controls.Add(this.send);
            this.Controls.Add(this.name);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.messageDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox messageDisplay;
        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Timer timer;
    }
}

