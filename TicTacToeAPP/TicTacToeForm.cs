using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeLibrary;

namespace TicTacToeAPP
{
    public partial class TicTacToeForm : Form
    {
        #region Metodos de la forma
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            ddlDificultad.SelectedIndex = 0;
        }
        #endregion

        #region Variables privadas
        private bool _isOturn = false;
        private int[] _board = new int[9];
        #endregion

        #region Pictureboxes
        private void pb1_Click(object sender, EventArgs e)
        {
            if (pb1.BackgroundImage == null)
            {
                if (_isOturn)
                {
                    pb1.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                    _isOturn = false;
                }

                else
                {
                    pb1.BackgroundImage = Image.FromFile("./Resources/dragonX.png");
                    _isOturn = true;
                }
            }
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if (pb2.BackgroundImage == null)
            {
                if (_isOturn)
                {
                    pb2.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                    _isOturn = false;
                }

                else
                {
                    pb2.BackgroundImage = Image.FromFile("./Resources/dragonX.png");
                    _isOturn = true;
                }
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if (pb3.BackgroundImage == null)
            {
                if (_isOturn)
                {
                    pb3.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                    _isOturn = false;
                }

                else
                {
                    pb3.BackgroundImage = Image.FromFile("./Resources/dragonX.png");
                    _isOturn = true;
                }
            }
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            if (pb4.BackgroundImage == null)
            {
                if (_isOturn)
                {
                    pb4.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                    _isOturn = false;
                }

                else
                {
                    pb4.BackgroundImage = Image.FromFile("./Resources/dragonX.png");
                    _isOturn = true;
                }
            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if (pb5.BackgroundImage == null)
            {
                if (_isOturn)
                {
                    pb5.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                    _isOturn = false;
                }

                else
                {
                    pb5.BackgroundImage = Image.FromFile("./Resources/dragonX.png");
                    _isOturn = true;
                }
            }
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            if (pb6.BackgroundImage == null)
            {
                if (_isOturn)
                {
                    pb6.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                    _isOturn = false;
                }

                else
                {
                    pb6.BackgroundImage = Image.FromFile("./Resources/dragonX.png");
                    _isOturn = true;
                }
            }
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            if (pb7.BackgroundImage == null)
            {
                if (_isOturn)
                {
                    pb7.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                    _isOturn = false;
                }

                else
                {
                    pb7.BackgroundImage = Image.FromFile("./Resources/dragonX.png");
                    _isOturn = true;
                }
            }
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            if (pb8.BackgroundImage == null)
            {
                if (_isOturn)
                {
                    pb8.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                    _isOturn = false;
                }

                else
                {
                    pb8.BackgroundImage = Image.FromFile("./Resources/dragonX.png");
                    _isOturn = true;
                }
            }
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            if (pb9.BackgroundImage == null)
            {
                if (_isOturn)
                {
                    pb9.BackgroundImage = Image.FromFile("./Resources/dragonBall.png");
                    _isOturn = false;
                }

                else
                {
                    pb9.BackgroundImage = Image.FromFile("./Resources/dragonX.png");
                    _isOturn = true;
                }
            }
        }
        #endregion

        #region Botón
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            BorrarImagenes();
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
        #endregion
    }
}
