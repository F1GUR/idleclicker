﻿namespace idleclicker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.A1ammounttextBox = new System.Windows.Forms.TextBox();
            this.A1_Upgradeammount = new System.Windows.Forms.Button();
            this.A1_UpgradeInterval = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.A1_intervaltextBox = new System.Windows.Forms.TextBox();
            this.A1Timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(631, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 134);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hit me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(734, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kasa: 0$";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Upgrade";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(483, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(119, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1ammounttextBox
            // 
            this.A1ammounttextBox.Location = new System.Drawing.Point(32, 14);
            this.A1ammounttextBox.Name = "A1ammounttextBox";
            this.A1ammounttextBox.Size = new System.Drawing.Size(114, 23);
            this.A1ammounttextBox.TabIndex = 4;
            this.A1ammounttextBox.Text = "0";
            this.A1ammounttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1_Upgradeammount
            // 
            this.A1_Upgradeammount.Location = new System.Drawing.Point(184, 11);
            this.A1_Upgradeammount.Name = "A1_Upgradeammount";
            this.A1_Upgradeammount.Size = new System.Drawing.Size(96, 50);
            this.A1_Upgradeammount.TabIndex = 5;
            this.A1_Upgradeammount.Text = "Ulepsz ilość";
            this.A1_Upgradeammount.UseVisualStyleBackColor = true;
            this.A1_Upgradeammount.Click += new System.EventHandler(this.A1_Upgradeammount_Click);
            // 
            // A1_UpgradeInterval
            // 
            this.A1_UpgradeInterval.Location = new System.Drawing.Point(286, 12);
            this.A1_UpgradeInterval.Name = "A1_UpgradeInterval";
            this.A1_UpgradeInterval.Size = new System.Drawing.Size(137, 49);
            this.A1_UpgradeInterval.TabIndex = 6;
            this.A1_UpgradeInterval.Text = "Ulepsz czestotliwość";
            this.A1_UpgradeInterval.UseVisualStyleBackColor = true;
            this.A1_UpgradeInterval.Click += new System.EventHandler(this.A1_UpgradeInterval_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Auto upgrade ";
            // 
            // A1_intervaltextBox
            // 
            this.A1_intervaltextBox.Location = new System.Drawing.Point(436, 14);
            this.A1_intervaltextBox.Name = "A1_intervaltextBox";
            this.A1_intervaltextBox.Size = new System.Drawing.Size(123, 23);
            this.A1_intervaltextBox.TabIndex = 8;
            this.A1_intervaltextBox.Text = "0";
            this.A1_intervaltextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1Timer
            // 
            this.A1Timer.Tick += new System.EventHandler(this.A1klik);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "/na minute";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.A1_intervaltextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A1_UpgradeInterval);
            this.Controls.Add(this.A1_Upgradeammount);
            this.Controls.Add(this.A1ammounttextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private TextBox textBox1;
        private TextBox A1ammounttextBox;
        private Button A1_Upgradeammount;
        private Button A1_UpgradeInterval;
        private Label label2;
        private TextBox A1_intervaltextBox;
        private System.Windows.Forms.Timer A1Timer;
        private Label label3;
    }
}