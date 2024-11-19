namespace FlapyBird
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bird = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pipesloopmovement = new System.Windows.Forms.Timer(this.components);
            this.createpipestimer = new System.Windows.Forms.Timer(this.components);
            this.lblLoseMessage = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCurrrentScore = new System.Windows.Forms.Label();
            this.brnStartGame = new System.Windows.Forms.Button();
            this.lblstartgame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FlapyBird.Properties.Resources.flappybirdbg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 601);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.Image = global::FlapyBird.Properties.Resources.flappybird;
            this.Bird.Location = new System.Drawing.Point(42, 267);
            this.Bird.Name = "Bird";
            this.Bird.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Bird.ShadowDecoration.Parent = this.Bird;
            this.Bird.Size = new System.Drawing.Size(32, 29);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 1;
            this.Bird.TabStop = false;
            this.Bird.Visible = false;
            // 
            // pipesloopmovement
            // 
            this.pipesloopmovement.Enabled = true;
            this.pipesloopmovement.Interval = 300;
            this.pipesloopmovement.Tick += new System.EventHandler(this.pipesloopmovement_Tick);
            // 
            // createpipestimer
            // 
            this.createpipestimer.Enabled = true;
            this.createpipestimer.Interval = 2000;
            this.createpipestimer.Tick += new System.EventHandler(this.createpipestimer_Tick);
            // 
            // lblLoseMessage
            // 
            this.lblLoseMessage.AutoSize = true;
            this.lblLoseMessage.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoseMessage.ForeColor = System.Drawing.Color.Red;
            this.lblLoseMessage.Location = new System.Drawing.Point(72, 219);
            this.lblLoseMessage.Name = "lblLoseMessage";
            this.lblLoseMessage.Size = new System.Drawing.Size(185, 36);
            this.lblLoseMessage.TabIndex = 2;
            this.lblLoseMessage.Text = "GAME OVER";
            this.lblLoseMessage.Visible = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.Red;
            this.btnPlayAgain.Location = new System.Drawing.Point(87, 326);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(134, 38);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Navy;
            this.lblScore.Location = new System.Drawing.Point(127, 267);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(40, 44);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            this.lblScore.Visible = false;
            // 
            // lblCurrrentScore
            // 
            this.lblCurrrentScore.AutoSize = true;
            this.lblCurrrentScore.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrrentScore.ForeColor = System.Drawing.Color.Red;
            this.lblCurrrentScore.Location = new System.Drawing.Point(137, 9);
            this.lblCurrrentScore.Name = "lblCurrrentScore";
            this.lblCurrrentScore.Size = new System.Drawing.Size(31, 36);
            this.lblCurrrentScore.TabIndex = 5;
            this.lblCurrrentScore.Text = "0";
            // 
            // brnStartGame
            // 
            this.brnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnStartGame.ForeColor = System.Drawing.Color.Red;
            this.brnStartGame.Location = new System.Drawing.Point(97, 198);
            this.brnStartGame.Name = "brnStartGame";
            this.brnStartGame.Size = new System.Drawing.Size(134, 38);
            this.brnStartGame.TabIndex = 6;
            this.brnStartGame.Text = "Play";
            this.brnStartGame.UseVisualStyleBackColor = true;
            this.brnStartGame.Click += new System.EventHandler(this.brnStartGame_Click);
            // 
            // lblstartgame
            // 
            this.lblstartgame.AutoSize = true;
            this.lblstartgame.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstartgame.ForeColor = System.Drawing.Color.Red;
            this.lblstartgame.Location = new System.Drawing.Point(81, 159);
            this.lblstartgame.Name = "lblstartgame";
            this.lblstartgame.Size = new System.Drawing.Size(186, 36);
            this.lblstartgame.TabIndex = 7;
            this.lblstartgame.Text = "START GAME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(197)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.lblstartgame);
            this.Controls.Add(this.brnStartGame);
            this.Controls.Add(this.lblCurrrentScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblLoseMessage);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devlopped By Mohammed bourass";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Bird;
        private System.Windows.Forms.Timer pipesloopmovement;
        private System.Windows.Forms.Timer createpipestimer;
        private System.Windows.Forms.Label lblLoseMessage;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCurrrentScore;
        private System.Windows.Forms.Button brnStartGame;
        private System.Windows.Forms.Label lblstartgame;
    }
}

