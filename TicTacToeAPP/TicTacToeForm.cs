using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeLibrary;

namespace TicTacToeAPP
{
    public partial class TicTacToeForm : Form
    {
        #region Variables privadas
        private int[] _board = new int[9];
        private TicTacToe game = new TicTacToe(0);
        private List<PictureBox> availableBoxes;
        private bool weHaveAWinner = false;
        private SoundPlayer player = new SoundPlayer();
        #endregion

        #region Metodos de la forma
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            ddlDificultad.SelectedIndex = 0;

            availableBoxes = new List<PictureBox>();
            availableBoxes.Add(pb1);
            availableBoxes.Add(pb2);
            availableBoxes.Add(pb3);
            availableBoxes.Add(pb4);
            availableBoxes.Add(pb5);
            availableBoxes.Add(pb6);
            availableBoxes.Add(pb7);
            availableBoxes.Add(pb8);
            availableBoxes.Add(pb9);
        }
        #endregion

        #region Pictureboxes
        private void pb1_Click(object sender, EventArgs e)
        {
            if (pb1.BackgroundImage == null && !weHaveAWinner)
            {
                pb1.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                game.PlayerMove(0);
                GetResults();
            }
        }


        private void pb2_Click(object sender, EventArgs e)
        {
            if (pb2.BackgroundImage == null && !weHaveAWinner)
            {
                pb2.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                game.PlayerMove(1);
                GetResults();
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if (pb3.BackgroundImage == null && !weHaveAWinner)
            {
                pb3.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                game.PlayerMove(2);
                GetResults();
            }
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            if (pb4.BackgroundImage == null && !weHaveAWinner)
            {
                pb4.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                game.PlayerMove(3);
                GetResults();
            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if (pb5.BackgroundImage == null && !weHaveAWinner)
            {
                pb5.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                game.PlayerMove(4);
                GetResults();
            }
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            if (pb6.BackgroundImage == null && !weHaveAWinner)
            {
                pb6.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                game.PlayerMove(5);
                GetResults();
            }
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            if (pb7.BackgroundImage == null && !weHaveAWinner)
            {
                pb7.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                game.PlayerMove(6);
                GetResults();
            }
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            if (pb8.BackgroundImage == null && !weHaveAWinner)
            {
                pb8.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                game.PlayerMove(7);
                GetResults();
            }
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            if (pb9.BackgroundImage == null && !weHaveAWinner)
            {
                pb9.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                game.PlayerMove(8);
                GetResults();
            }
        }
        #endregion

        #region Botón
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            BorrarImagenes();

            game = new TicTacToe(ddlDificultad.SelectedIndex+1);
            ActivarPictureBoxes();
            weHaveAWinner = false;
        }
        #endregion

        #region Metodos de accion
        private void BorrarImagenes()
        {
            pb1.BackgroundImage = null;
            pb2.BackgroundImage = null;
            pb3.BackgroundImage = null;
            pb4.BackgroundImage = null;
            pb5.BackgroundImage = null;
            pb6.BackgroundImage = null;
            pb7.BackgroundImage = null;
            pb8.BackgroundImage = null;
            pb9.BackgroundImage = null;
        }

        private void ActivarPictureBoxes()
        {
            pb1.Enabled = true;
            pb2.Enabled = true;
            pb3.Enabled = true;
            pb4.Enabled = true;
            pb5.Enabled = true;
            pb6.Enabled = true;
            pb7.Enabled = true;
            pb8.Enabled = true;
            pb9.Enabled = true;
        }

        private void ComputerMove()
        {
            int index = game.CPUMove();

            while (availableBoxes[index].BackgroundImage != null)
            {
                index = game.CPUMove();
            }

            availableBoxes[index].BackgroundImage = Image.FromFile("./Resources/dragonX.png");
        }

        private void GetResults()
        {
            if (game.Result == 1)
            {
                weHaveAWinner = true;
                MessageBox.Show("CONGRATULATIONS, YOU WIN!");
                return;
            }
            if (game.Result == 3)
            {
                weHaveAWinner = true;
                MessageBox.Show("DRAW!");
                return;
            }

            ComputerMove();
            if (game.Result == 2)
            {
                weHaveAWinner = true;
                player = new SoundPlayer("./Resources/Maldicion.wav");
                player.Play();
                MessageBox.Show("CONGRATULATIONS, YOU SUCK!");
            }
        }
        #endregion
    }
}
