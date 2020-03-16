namespace Chat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.TextBox();
            this.A2 = new System.Windows.Forms.TextBox();
            this.A3 = new System.Windows.Forms.TextBox();
            this.A4 = new System.Windows.Forms.TextBox();
            this.A5 = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.A6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "เลข IP Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "เลขPORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "เลข IP Address ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "เลข PORT";
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(44, 71);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(291, 20);
            this.A1.TabIndex = 4;
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(402, 71);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(291, 20);
            this.A2.TabIndex = 5;
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(45, 155);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(291, 20);
            this.A3.TabIndex = 6;
            // 
            // A4
            // 
            this.A4.Location = new System.Drawing.Point(402, 155);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(291, 20);
            this.A4.TabIndex = 7;
            // 
            // A5
            // 
            this.A5.Location = new System.Drawing.Point(44, 229);
            this.A5.Multiline = true;
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(291, 168);
            this.A5.TabIndex = 8;
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(568, 98);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(125, 33);
            this.B1.TabIndex = 10;
            this.B1.Text = "เริ่ม server";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(568, 193);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(125, 33);
            this.B2.TabIndex = 11;
            this.B2.Text = "เชื่อมต่อ SERVER";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(341, 403);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(93, 35);
            this.B3.TabIndex = 12;
            this.B3.Text = "ส่ง";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // A6
            // 
            this.A6.Location = new System.Drawing.Point(44, 403);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(291, 20);
            this.A6.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.A6);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A5);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox A1;
        private System.Windows.Forms.TextBox A2;
        private System.Windows.Forms.TextBox A3;
        private System.Windows.Forms.TextBox A4;
        private System.Windows.Forms.TextBox A5;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox A6;
    }
}

