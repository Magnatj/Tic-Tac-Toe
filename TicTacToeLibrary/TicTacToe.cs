using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLibrary
{
    public class TicTacToe
    {
        private int _turn = 1;
        private int[] _board = new int[9];
        private BoardScanner _scanner;
        private AI _cpu;

        public TicTacToe(int difficulty)
        {
            _scanner = new BoardScanner(_board);
            _cpu = new AI(_scanner, difficulty, _board);
        }

        public bool? PlayerMove(int boardIndex)
        {
            if (_turn != 1 || _board[boardIndex] != 0)
                return null;
            _board[boardIndex] = 1;
            return _scanner.GameOver(1);
        }

        public bool? CPUMove()
        {
            return true;
        }

    }
}
