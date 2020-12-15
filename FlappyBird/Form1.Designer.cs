
namespace FlappyBird
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
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipebot = new System.Windows.Forms.PictureBox();
            this.grounds = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.replay = new System.Windows.Forms.Button();
            this.scoreLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bird.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bird.Image = global::FlappyBird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(101, 166);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(63, 60);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            this.bird.Click += new System.EventHandler(this.bird_Click);
            // 
            // pipebot
            // 
            this.pipebot.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pipebot.Location = new System.Drawing.Point(511, 244);
            this.pipebot.Name = "pipebot";
            this.pipebot.Size = new System.Drawing.Size(85, 161);
            this.pipebot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebot.TabIndex = 1;
            this.pipebot.TabStop = false;
            // 
            // grounds
            // 
            this.grounds.Image = global::FlappyBird.Properties.Resources.ground;
            this.grounds.Location = new System.Drawing.Point(-1, 401);
            this.grounds.Name = "grounds";
            this.grounds.Size = new System.Drawing.Size(808, 50);
            this.grounds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grounds.TabIndex = 2;
            this.grounds.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pipetop.Location = new System.Drawing.Point(356, -1);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(100, 111);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 3;
            this.pipetop.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // replay
            // 
            this.replay.Location = new System.Drawing.Point(345, 149);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(148, 77);
            this.replay.TabIndex = 5;
            this.replay.Text = "Replay";
            this.replay.UseVisualStyleBackColor = true;
            this.replay.Visible = false;
            this.replay.Click += new System.EventHandler(this.replay_Click);
            // 
            // scoreLable
            // 
            this.scoreLable.AutoSize = true;
            this.scoreLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLable.Location = new System.Drawing.Point(40, 23);
            this.scoreLable.Name = "scoreLable";
            this.scoreLable.Size = new System.Drawing.Size(77, 24);
            this.scoreLable.TabIndex = 6;
            this.scoreLable.Text = "score: 0";
            this.scoreLable.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreLable);
            this.Controls.Add(this.replay);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.grounds);
            this.Controls.Add(this.pipebot);
            this.Controls.Add(this.bird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipebot;
        private System.Windows.Forms.PictureBox grounds;
        private System.Windows.Forms.PictureBox pipetop;
        
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button replay;
        private System.Windows.Forms.Label scoreLable;
    }
}

