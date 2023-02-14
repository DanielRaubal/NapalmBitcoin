
namespace NapalmBitcoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RealTimeTextBox = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LedDiode = new System.Windows.Forms.PictureBox();
            this.Minimise = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedDiode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise)).BeginInit();
            this.SuspendLayout();
            // 
            // RealTimeTextBox
            // 
            this.RealTimeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(203)))), ((int)(((byte)(220)))));
            this.RealTimeTextBox.Enabled = false;
            this.RealTimeTextBox.Font = new System.Drawing.Font("Edit Undo BRK", 8.25F);
            this.RealTimeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.RealTimeTextBox.Location = new System.Drawing.Point(14, 7);
            this.RealTimeTextBox.Name = "RealTimeTextBox";
            this.RealTimeTextBox.Size = new System.Drawing.Size(251, 17);
            this.RealTimeTextBox.TabIndex = 73;
            this.RealTimeTextBox.Text = "v 0.01";
            this.RealTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.Exit.BackgroundImage = global::NapalmBitcoin.Properties.Resources.Exit;
            this.Exit.Location = new System.Drawing.Point(289, 7);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(16, 16);
            this.Exit.TabIndex = 72;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Edit Undo BRK", 35.25F);
            this.textBox1.Location = new System.Drawing.Point(14, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 217);
            this.textBox1.TabIndex = 75;
            this.textBox1.Text = "\r\n\r\n0$";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LedDiode
            // 
            this.LedDiode.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LedDiode.Location = new System.Drawing.Point(280, 35);
            this.LedDiode.Name = "LedDiode";
            this.LedDiode.Size = new System.Drawing.Size(20, 20);
            this.LedDiode.TabIndex = 76;
            this.LedDiode.TabStop = false;
            // 
            // Minimise
            // 
            this.Minimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(155)))), ((int)(((byte)(180)))));
            this.Minimise.BackgroundImage = global::NapalmBitcoin.Properties.Resources.Minimise;
            this.Minimise.Location = new System.Drawing.Point(270, 7);
            this.Minimise.Name = "Minimise";
            this.Minimise.Size = new System.Drawing.Size(16, 16);
            this.Minimise.TabIndex = 77;
            this.Minimise.TabStop = false;
            this.Minimise.Click += new System.EventHandler(this.Minimise_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NapalmBitcoin.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 259);
            this.Controls.Add(this.Minimise);
            this.Controls.Add(this.LedDiode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RealTimeTextBox);
            this.Controls.Add(this.Exit);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedDiode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox RealTimeTextBox;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox LedDiode;
        private System.Windows.Forms.PictureBox Minimise;
        private System.Windows.Forms.Timer timer1;
    }
}

