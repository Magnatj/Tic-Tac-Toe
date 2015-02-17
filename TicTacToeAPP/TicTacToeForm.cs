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
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            ddlDificultad.SelectedIndex = 0;
        }

        private bool _isOturn = false;
        private int[] _board = new int[9];

        private void pb1_Click(object sender, EventArgs e)
        {
            if (_isOturn)
            {

            }

            else
            {
                
            }
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if (_isOturn)
            {

            }

            else
            {

            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if (_isOturn)
            {

            }

            else
            {

            }
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            if (_isOturn)
            {

            }

            else
            {

            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if (_isOturn)
            {

            }

            else
            {

            }
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            if (_isOturn)
            {

            }

            else
            {

            }
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            if (_isOturn)
            {

            }

            else
            {

            }
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            if (_isOturn)
            {

            }

            else
            {

            }
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            if (_isOturn)
            {

            }

            else
            {

            }
        }
    }
}
