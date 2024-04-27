namespace FinalProject
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
            this.Escape1 = new System.Windows.Forms.Button();
            this.clock_label = new System.Windows.Forms.Label();
            this.flower_label = new System.Windows.Forms.Label();
            this.wrench_label = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Wrench_pb = new System.Windows.Forms.PictureBox();
            this.Flower_pb = new System.Windows.Forms.PictureBox();
            this.Clock_pb = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.clock_1_found = new System.Windows.Forms.Label();
            this.wrench_1_found = new System.Windows.Forms.Label();
            this.flower_2_found = new System.Windows.Forms.Label();
            this.wrench_2_found = new System.Windows.Forms.Label();
            this.clock_3_found = new System.Windows.Forms.Label();
            this.flower_1_found = new System.Windows.Forms.Label();
            this.clock_2_found = new System.Windows.Forms.Label();
            this.clock_label_2 = new System.Windows.Forms.Label();
            this.flower_label_2 = new System.Windows.Forms.Label();
            this.wrench_label_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Wrench_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clock_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // Escape1
            // 
            this.Escape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Escape1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Escape1.FlatAppearance.BorderSize = 0;
            this.Escape1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Escape1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Escape1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Escape1.Location = new System.Drawing.Point(663, 362);
            this.Escape1.Name = "Escape1";
            this.Escape1.Size = new System.Drawing.Size(83, 34);
            this.Escape1.TabIndex = 8;
            this.Escape1.Tag = "Slide1";
            this.Escape1.Text = "ESCAPE";
            this.Escape1.UseVisualStyleBackColor = false;
            this.Escape1.Visible = false;
            this.Escape1.Click += new System.EventHandler(this.Escape1_Click);
            // 
            // clock_label
            // 
            this.clock_label.AutoSize = true;
            this.clock_label.Location = new System.Drawing.Point(816, 144);
            this.clock_label.Name = "clock_label";
            this.clock_label.Size = new System.Drawing.Size(91, 20);
            this.clock_label.TabIndex = 15;
            this.clock_label.Tag = "Slide1";
            this.clock_label.Text = "Parts        /3";
            // 
            // flower_label
            // 
            this.flower_label.AutoSize = true;
            this.flower_label.Location = new System.Drawing.Point(816, 324);
            this.flower_label.Name = "flower_label";
            this.flower_label.Size = new System.Drawing.Size(91, 20);
            this.flower_label.TabIndex = 16;
            this.flower_label.Tag = "Slide1";
            this.flower_label.Text = "Parts        /2";
            // 
            // wrench_label
            // 
            this.wrench_label.AutoSize = true;
            this.wrench_label.Location = new System.Drawing.Point(816, 480);
            this.wrench_label.Name = "wrench_label";
            this.wrench_label.Size = new System.Drawing.Size(91, 20);
            this.wrench_label.TabIndex = 17;
            this.wrench_label.Tag = "Slide1";
            this.wrench_label.Text = "Parts        /2";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Wrench_pb
            // 
            this.Wrench_pb.BackgroundImage = global::FinalProject.Properties.Resources.Wrench;
            this.Wrench_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Wrench_pb.Location = new System.Drawing.Point(767, 347);
            this.Wrench_pb.Name = "Wrench_pb";
            this.Wrench_pb.Size = new System.Drawing.Size(140, 153);
            this.Wrench_pb.TabIndex = 14;
            this.Wrench_pb.TabStop = false;
            this.Wrench_pb.Tag = "Slide1";
            this.Wrench_pb.Visible = false;
            // 
            // Flower_pb
            // 
            this.Flower_pb.BackgroundImage = global::FinalProject.Properties.Resources.Flower1;
            this.Flower_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Flower_pb.Location = new System.Drawing.Point(788, 179);
            this.Flower_pb.Name = "Flower_pb";
            this.Flower_pb.Size = new System.Drawing.Size(119, 162);
            this.Flower_pb.TabIndex = 13;
            this.Flower_pb.TabStop = false;
            this.Flower_pb.Tag = "Slide1";
            this.Flower_pb.Visible = false;
            // 
            // Clock_pb
            // 
            this.Clock_pb.BackColor = System.Drawing.Color.Transparent;
            this.Clock_pb.BackgroundImage = global::FinalProject.Properties.Resources.Clock;
            this.Clock_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clock_pb.Location = new System.Drawing.Point(776, 12);
            this.Clock_pb.Name = "Clock_pb";
            this.Clock_pb.Size = new System.Drawing.Size(131, 129);
            this.Clock_pb.TabIndex = 12;
            this.Clock_pb.TabStop = false;
            this.Clock_pb.Tag = "Slide1";
            this.Clock_pb.Visible = false;
            // 
            // background
            // 
            this.background.Image = global::FinalProject.Properties.Resources.Background_1;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1900, 500);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // clock_1_found
            // 
            this.clock_1_found.AutoSize = true;
            this.clock_1_found.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clock_1_found.Location = new System.Drawing.Point(-4, 266);
            this.clock_1_found.Name = "clock_1_found";
            this.clock_1_found.Size = new System.Drawing.Size(55, 20);
            this.clock_1_found.TabIndex = 19;
            this.clock_1_found.Tag = "Slide1";
            this.clock_1_found.Text = "Found";
            this.clock_1_found.Visible = false;
            // 
            // wrench_1_found
            // 
            this.wrench_1_found.AutoSize = true;
            this.wrench_1_found.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.wrench_1_found.Location = new System.Drawing.Point(127, 179);
            this.wrench_1_found.Name = "wrench_1_found";
            this.wrench_1_found.Size = new System.Drawing.Size(55, 20);
            this.wrench_1_found.TabIndex = 20;
            this.wrench_1_found.Tag = "Slide1";
            this.wrench_1_found.Text = "Found";
            this.wrench_1_found.Visible = false;
            // 
            // flower_2_found
            // 
            this.flower_2_found.AutoSize = true;
            this.flower_2_found.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.flower_2_found.Location = new System.Drawing.Point(309, 50);
            this.flower_2_found.Name = "flower_2_found";
            this.flower_2_found.Size = new System.Drawing.Size(55, 20);
            this.flower_2_found.TabIndex = 21;
            this.flower_2_found.Tag = "Slide1";
            this.flower_2_found.Text = "Found";
            this.flower_2_found.Visible = false;
            // 
            // wrench_2_found
            // 
            this.wrench_2_found.AutoSize = true;
            this.wrench_2_found.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.wrench_2_found.Location = new System.Drawing.Point(548, 67);
            this.wrench_2_found.Name = "wrench_2_found";
            this.wrench_2_found.Size = new System.Drawing.Size(55, 20);
            this.wrench_2_found.TabIndex = 22;
            this.wrench_2_found.Tag = "Slide1";
            this.wrench_2_found.Text = "Found";
            this.wrench_2_found.Visible = false;
            // 
            // clock_3_found
            // 
            this.clock_3_found.AutoSize = true;
            this.clock_3_found.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clock_3_found.Location = new System.Drawing.Point(675, 90);
            this.clock_3_found.Name = "clock_3_found";
            this.clock_3_found.Size = new System.Drawing.Size(55, 20);
            this.clock_3_found.TabIndex = 23;
            this.clock_3_found.Tag = "Slide1";
            this.clock_3_found.Text = "Found";
            this.clock_3_found.Visible = false;
            // 
            // flower_1_found
            // 
            this.flower_1_found.AutoSize = true;
            this.flower_1_found.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.flower_1_found.Location = new System.Drawing.Point(559, 198);
            this.flower_1_found.Name = "flower_1_found";
            this.flower_1_found.Size = new System.Drawing.Size(55, 20);
            this.flower_1_found.TabIndex = 24;
            this.flower_1_found.Tag = "Slide1";
            this.flower_1_found.Text = "Found";
            this.flower_1_found.Visible = false;
            // 
            // clock_2_found
            // 
            this.clock_2_found.AutoSize = true;
            this.clock_2_found.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clock_2_found.Location = new System.Drawing.Point(490, 347);
            this.clock_2_found.Name = "clock_2_found";
            this.clock_2_found.Size = new System.Drawing.Size(55, 20);
            this.clock_2_found.TabIndex = 25;
            this.clock_2_found.Tag = "Slide1";
            this.clock_2_found.Text = "Found";
            this.clock_2_found.Visible = false;
            // 
            // clock_label_2
            // 
            this.clock_label_2.AutoSize = true;
            this.clock_label_2.Location = new System.Drawing.Point(851, 144);
            this.clock_label_2.Name = "clock_label_2";
            this.clock_label_2.Size = new System.Drawing.Size(18, 20);
            this.clock_label_2.TabIndex = 26;
            this.clock_label_2.Tag = "Slide1";
            this.clock_label_2.Text = "0";
            // 
            // flower_label_2
            // 
            this.flower_label_2.AutoSize = true;
            this.flower_label_2.Location = new System.Drawing.Point(851, 324);
            this.flower_label_2.Name = "flower_label_2";
            this.flower_label_2.Size = new System.Drawing.Size(18, 20);
            this.flower_label_2.TabIndex = 27;
            this.flower_label_2.Tag = "Slide1";
            this.flower_label_2.Text = "0";
            // 
            // wrench_label_2
            // 
            this.wrench_label_2.AutoSize = true;
            this.wrench_label_2.Location = new System.Drawing.Point(851, 480);
            this.wrench_label_2.Name = "wrench_label_2";
            this.wrench_label_2.Size = new System.Drawing.Size(18, 20);
            this.wrench_label_2.TabIndex = 28;
            this.wrench_label_2.Tag = "Slide1";
            this.wrench_label_2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(928, 499);
            this.Controls.Add(this.wrench_label_2);
            this.Controls.Add(this.flower_label_2);
            this.Controls.Add(this.clock_label_2);
            this.Controls.Add(this.clock_2_found);
            this.Controls.Add(this.flower_1_found);
            this.Controls.Add(this.clock_3_found);
            this.Controls.Add(this.wrench_2_found);
            this.Controls.Add(this.flower_2_found);
            this.Controls.Add(this.wrench_1_found);
            this.Controls.Add(this.clock_1_found);
            this.Controls.Add(this.wrench_label);
            this.Controls.Add(this.flower_label);
            this.Controls.Add(this.clock_label);
            this.Controls.Add(this.Wrench_pb);
            this.Controls.Add(this.Flower_pb);
            this.Controls.Add(this.Clock_pb);
            this.Controls.Add(this.Escape1);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1900, 555);
            this.MinimumSize = new System.Drawing.Size(950, 555);
            this.Name = "Form1";
            this.Text = "Escape Room";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wrench_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clock_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Button Escape1;
        private System.Windows.Forms.PictureBox Clock_pb;
        private System.Windows.Forms.PictureBox Flower_pb;
        private System.Windows.Forms.PictureBox Wrench_pb;
        private System.Windows.Forms.Label clock_label;
        private System.Windows.Forms.Label flower_label;
        private System.Windows.Forms.Label wrench_label;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label clock_1_found;
        private System.Windows.Forms.Label wrench_1_found;
        private System.Windows.Forms.Label flower_2_found;
        private System.Windows.Forms.Label wrench_2_found;
        private System.Windows.Forms.Label clock_3_found;
        private System.Windows.Forms.Label flower_1_found;
        private System.Windows.Forms.Label clock_2_found;
        private System.Windows.Forms.Label clock_label_2;
        private System.Windows.Forms.Label flower_label_2;
        private System.Windows.Forms.Label wrench_label_2;
    }
}

