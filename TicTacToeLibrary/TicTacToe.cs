using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLibrary
{
    public class TicTacToe
    {
        private int _turn = 1, _result = 0;
        private int[] _board = new int[9];
        private BoardScanner _scanner;
        private AI _cpu;

        public int Result { get { return _result; } }

        public TicTacToe(int difficulty)
        {
            _scanner = new BoardScanner(_board);
            _cpu = new AI(difficulty, _board);
        }

        public void PlayerMove(int boardIndex)
        {
            if (_turn == 1 && _board[boardIndex] == 0)
                _board[boardIndex] = 1;
            if (_scanner.GameOver(1))
                _result = 1;
            else if (_board.Count(q => q == 0) == 0)
                _result = 3;
        }

        public int CPUMove()
        {
            int affected = _cpu.MakeMove();
            if (_scanner.GameOver(2))
                _result = 2;
            return affected;
        }

    }
}
