using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLibrary
{
    class BoardScanner
    {
        private int[] _board;

        public BoardScanner(int[] board)
        {
            _board = board;
        }

        public bool GameOver(int player)
        {
            if (_board[0] == player)
            {
                if ((_board[1] == player && _board[2] == player)
                    || (_board[3] == player && _board[6] == player)
                    || (_board[4] == player && _board[8] == player))
                    return true;
            }
            if (_board[2] == player)
            {
                if ((_board[4] == player && _board[6] == player)
                    || (_board[5] == player && _board[8] == player))
                    return true;
            }
            if ((_board[3] == player && _board[4] == player && _board[5] == player)
                || (_board[6] == player && _board[7] == player && _board[8] == player))
                return true;

            if (_board[1] == player && _board[4] == player && _board[7] == player)
                return true;

            return false;
        }

    }
}
