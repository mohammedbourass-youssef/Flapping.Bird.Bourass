using FlapyBird.Properties;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlapyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        //logic 
        int _boardheight = 640;
        int _boardwidrh = 360;
        int _pipesmovement = -68;
        int _freespace = 100;
        bool _GameOver = false;
        int _score = 0;
        //bird logic 
        Size flapybirdsize = new Size(344, 601);
        void _MoveTheBird(int vecX)
        {
           Bird.Location = new Point(Bird.Location.X, Bird.Location.Y + vecX);
           if(Bird.Location.Y <= 0)
           {
                _GameOver = true;
                clsMusic.GameOverSound();
            }
           if(Bird.Location.Y >= _boardheight-150)
            {
                _GameOver = true;
                clsMusic.GameOverSound();
            }
        }
        void _StartingLocationForBird()
        {
            Bird.Location = new Point(42, 267);
        }
        //pipes
        int _pipesheight = 512;
        int _pipeswidth = 64;
        List <System.Windows.Forms.PictureBox> _toppipes = new List <System.Windows.Forms.PictureBox>();
        System.Windows.Forms.PictureBox _AddTopPipes(int sizeX , int sizeY)
        {
            System.Windows.Forms.PictureBox pictureBox = new System.Windows.Forms.PictureBox();

            // Set properties
            pictureBox.Location = new Point(_boardwidrh, 0); // Position on the form
            pictureBox.Size = new Size(sizeX, sizeY);   // Set size
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust image to fit the PictureBox
            pictureBox.Tag = "not checked";
            // Set the image
            pictureBox.Image = Resources.toppipe; // Load image from file
                                                                         // Alternatively, use a resource if available:
                                                                         // pictureBox.Image = Resources.YourImageResource;
            // Add the PictureBox to the form
            this.Controls.Add(pictureBox);
            pictureBox.BringToFront();
            lblCurrrentScore.BringToFront();
            return pictureBox;
        }
        List<System.Windows.Forms.PictureBox> _buttompipes = new List<System.Windows.Forms.PictureBox>();
        System.Windows.Forms.PictureBox _AddButtmPipes(int y)
        {
            System.Windows.Forms.PictureBox pictureBox = new System.Windows.Forms.PictureBox();

            // Set properties
           // pictureBox.Location = new Point(_boardwidrh, _boardheight); // Position on the form
            pictureBox.Location = new Point(_boardwidrh,y + _freespace); // Position on the form

            pictureBox.Size = new Size(_pipeswidth, _pipesheight); // Set size
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust image to fit the PictureBox

            // Set the image
            pictureBox.Image = Resources.bottompipe; // Load image from file
                                                  // Alternatively, use a resource if available:
                                                  // pictureBox.Image = Resources.YourImageResource;
                                                  // Add the PictureBox to the form
            this.Controls.Add(pictureBox);
            pictureBox.BringToFront();

            return pictureBox;
        }
        void _MoveThepipes()
        {
            
            for(int i = 0 ; i< _toppipes.Count ; i++)
            {
                //_toppipes[i].Location = new Point(_toppipes[i].Location.X + _pipesmovement, 0);
                _toppipes[i].Left += _pipesmovement;
                Rectangle birdRect = new Rectangle(Bird.Location, Bird.Size);
                Rectangle pipeRect = new Rectangle(_toppipes[i].Location, _toppipes[i].Size);
                if (birdRect.IntersectsWith(pipeRect))
                {
                    _GameOver = true;
                    clsMusic.GameOverSound();
                }
                _buttompipes[i].Left += _pipesmovement;
                birdRect = new Rectangle(Bird.Location, Bird.Size);
                pipeRect = new Rectangle(_buttompipes[i].Location, _buttompipes[i].Size);
                if (birdRect.IntersectsWith(pipeRect))
                {
                    _GameOver = true;
                    clsMusic.GameOverSound();
                }
                if(_toppipes[i].Location.X < Bird.Location.X && _toppipes[i].Tag.ToString() != "checked")
                {
                    _score++;
                    lblCurrrentScore.Text = _score.ToString();
                    _toppipes[i].Tag = "checked";
                    
                }
            }
        }

        void _NewGame()
        {
            for(int i=0;i<_toppipes.Count;i++)
            {
                _toppipes [i].Visible = false;
                _buttompipes [i].Visible = false;
            }
            _toppipes.Clear();
            _buttompipes.Clear();
        }

        //Lose Option 
        void _ShowLosingButton()
        {
            
            lblLoseMessage.Visible = true;
            lblLoseMessage.BringToFront();
            lblScore.Visible = true;
            lblScore.Text = _score.ToString();
            lblCurrrentScore.Visible = false;
            lblScore.BringToFront();
            btnPlayAgain.Visible = true;
            btnPlayAgain.BringToFront();
            
        }
        void _HideTheLosingButton()
        {
            lblLoseMessage.Visible = false;
            lblScore.Visible = false;
            btnPlayAgain.Visible = false;
            lblCurrrentScore.Visible = true;
            lblCurrrentScore.Text = "0";
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
            _HideTheLosingButton();

            pipesloopmovement.Stop();
            createpipestimer.Stop();
            
        }



        private void pipesloopmovement_Tick(object sender, EventArgs e)
        {
            if (_GameOver)
            {
                _ShowLosingButton();
            }
            else
            {
                _MoveThepipes();
            }
            
        }

        private void createpipestimer_Tick(object sender, EventArgs e)
        {
           
            if (_GameOver)
            {
                _ShowLosingButton();
            }
            else
            {
                Random random = new Random();
                int Y = random.Next(_pipesheight / 8, _pipesheight - _pipesheight / 4);
                _toppipes.Add(_AddTopPipes(64, Y));
                _buttompipes.Add(_AddButtmPipes(Y));
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!_GameOver)
            {
                if (e.KeyChar == (char)Keys.W || e.KeyChar == 'w')
                {
                    _MoveTheBird(-30);
                    clsMusic.BirdFlappingSound();
                }
                if (e.KeyChar == (char)Keys.B || e.KeyChar == 'b')
                {
                    _MoveTheBird(30);
                    clsMusic.BirdFlappingSound();
                }
            }

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            _boardheight = 640;
            _boardwidrh = 360;
            _pipesmovement = -68;
            _freespace = 100;
            _GameOver = false;
            _score = 0;
            this.KeyPreview = true;
            _StartingLocationForBird();
            _HideTheLosingButton();
            createpipestimer.Start();
            pipesloopmovement.Start();
            
        }

        private void brnStartGame_Click(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            brnStartGame.Visible = false;
            for(int i=0; i<=3; i++)
            {
                Thread.Sleep(10);
                lblstartgame.Text = i.ToString();
            }
            lblstartgame.Visible = false;
            pipesloopmovement.Start();
            createpipestimer.Start();
            Bird.Visible = true;
        }
    }
}
