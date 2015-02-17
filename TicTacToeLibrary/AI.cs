using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLibrary
{
    class AI
    {
        private BoardScanner _scanner;
        private int[] _board;
        private int _difficulty;
        private Random _random = new Random();

        public AI(BoardScanner scanner, int difficulty, int[] board)
        {
            _scanner = scanner;
            _board = board;
            _difficulty = difficulty;
        }

        public void MakeMove()
        {
            int toWin = OneMoveToWin(2);
            int rivalToWin = OneMoveToWin(1);
        }

        private int OneMoveToWin(int player)
        {
            int index = -1;
            for (int i = 0; i < 9; i++)
            {
                if (_board[i] == 0)
                {
                    _board[i] = player;
                    if (_scanner.GameOver(player))
                        index = i;
                    _board[i] = 0;
                    if (index > -1)
                        break;
                }
            }
            return index;
        }

        private int TwoMovesAway(int player)
        {
            if (_board[0] == player && _board[1] == 0 && _board[2] == 0)
                return 2;
            else if (_board[0] == player && _board[3] == 0 && _board[6] == 0)
                return 6;
            else if (_board[2] == player && _board[0] == 0 && _board[1] == 0)
                return 0;
            else if (_board[2] == player && _board[5] == 0 && _board[8] == 0)
                return 8;
            else if (_board[6] == player && _board[0] == 0 && _board[3] == 0)
                return 0;
            else if (_board[6] == player && _board[7] == 0 && _board[8] == 0)
                return 8;
            else if (_board[8] == player && _board[6] == 0 && _board[7] == 0)
                return 6;
            else if (_board[8] == player && _board[2] == 0 && _board[5] == 0)
                return 2;
            else
                return 1;
        }

    }
}
