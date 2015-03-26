﻿namespace MotionCaptureAudio
{
	partial class MainWindow
	{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.player = new MotionCaptureAudio.Player();
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCountDown = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.player);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 720);
            this.panel1.TabIndex = 1;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Dock = System.Windows.Forms.DockStyle.Left;
            this.player.ForeColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(190, 720);
            this.player.TabIndex = 13;
            // 
            // pictBox
            // 
            this.pictBox.BackColor = System.Drawing.Color.Black;
            this.pictBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictBox.Location = new System.Drawing.Point(191, 0);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(800, 720);
            this.pictBox.TabIndex = 2;
            this.pictBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(991, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 720);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelCountDown
            // 
            this.labelCountDown.AutoSize = true;
            this.labelCountDown.BackColor = System.Drawing.Color.Black;
            this.labelCountDown.Font = new System.Drawing.Font("Meiryo UI", 360F);
            this.labelCountDown.ForeColor = System.Drawing.Color.Yellow;
            this.labelCountDown.Location = new System.Drawing.Point(286, 101);
            this.labelCountDown.Name = "labelCountDown";
            this.labelCountDown.Size = new System.Drawing.Size(553, 610);
            this.labelCountDown.TabIndex = 4;
            this.labelCountDown.Text = "3";
            this.labelCountDown.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 720);
            this.Controls.Add(this.labelCountDown);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "mca";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictBox;
        private Player player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCountDown;
    }
}

