using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLibrary
{
    class AI
    {
        private int[] _board;
        private int _difficulty;
        private Random _random = new Random();

        public AI(int difficulty, int[] board)
        {
            _difficulty = difficulty;
            _board = board;
        }

        public int MakeMove()
        {
            if (_difficulty == 1)
                return Difficulty1();
            else if (_difficulty == 2)
                return Difficulty2();
            else if (_difficulty == 3)
                return Difficulty3();
            return Difficulty4();
        }

        #region Difficulty
        private int Difficulty1()
        {
            int selected = _random.Next(0, 9);
            if (_board[selected] == 0)
                _board[selected] = 2;
            return selected;
        }
        
        private int Difficulty2()
        {
            int selected;
            while ((selected = _random.Next(0, 9)) != 0)
                continue;
            _board[selected] = 2;
            return selected;
        }

        private int Difficulty3()
        {
            int selected = HLineStrategy();
            if (selected == -1)
                return VLineStrategy();
            if (selected == -1)
                selected = _board.First(q => q == 0);
            if (selected != -1)
                _board[selected] = 2;
            return selected;
        }

        private int Difficulty4()
        {
            int selected = CornerStrategy();
            if (selected == -1)
                selected = DiagonalStrategy();
            if (selected == -1)
                selected = HLineStrategy();
            if (selected == -1)
                selected = VLineStrategy();
            if (selected == -1)
                selected = _board.First(q => q == 0);
            if (selected != -1)
                _board[selected] = 2;
            

            return selected;        
        }
        
        #endregion

        #region Availability
        private int CornerStrategy()
        {
            if (LookForCorner(0) == 0)
                return 0;
            if (LookForCorner(2) == 2)
                return 2;
            if (LookForCorner(6) == 6)
                return 6;
            return LookForCorner(8);
        }

        private int DiagonalStrategy()
        {
            int available = -1;
            for (int i = 0; i <= 8; i += 4)
            {
                if (_board[i] == 1)
                {
                    available = -1;
                    break;
                }
                else if (_board[i] == 0)
                    available = i;
            }
            if (available == -1)
            {
                for (int i = 2; i <= 8; i += 2)
                {
                    if (_board[i] == 1)
                        return -1;
                    if (_board[i] == 0)
                        available = i;
                }
            }
            return available;
        }

        private int HLineStrategy()
        {
            int available = LookForHLine(0);
            available = available == -1 ? LookForHLine(3) : available;
            available = available == -1 ? LookForHLine(6) : available;
            return available;
        }

        private int VLineStrategy()
        {
            int available = LookForVLine(0);
            available = available == -1 ? LookForVLine(1) : available;
            available = available == -1 ? LookForVLine(2) : available;
            return available;
        }

        private int LookForVLine(int fromIndex)
        {
            int available = -1;
            for (int i = fromIndex; i < 9; i+=3)
            {
                if (_board[i] == 1)
                    return -1;
                if (_board[i] == 0)
                    available = i;
            }
            return available;
        }

        private int LookForHLine(int fromIndex)
        {
            int available = -1;
            for (int i = fromIndex; i <= fromIndex + 2; i++)
            {
                if (_board[i] == 1)
                    return -1;
                if (_board[i] == 0)
                    available = i;
            }
            return available;
        }
        
        private int LookForCorner(int corner)
        {
            switch (corner)
            {
                case 0:
                    if (_board[0] == 0)
                    {
                        if (_board[2] == 1 || _board[6] == 1)
                            return -1;
                        return 0;
                    }
                    break;
                case 2:
                    if (_board[2] == 0)
                    {
                        if (_board[0] == 1 || _board[8] == 1)
                            return -1;
                        return 2;
                    }
                    break;
                case 6:
                    if (_board[6] == 0)
                    {
                        if (_board[0] == 1 || _board[8] == 1)
                            return -1;
                        return 6;
                    }
                    break;
                case 8:
                    if (_board[8] == 0)
                    {
                        if (_board[2] == 1 || _board[6] == 1)
                            return -1;
                        return 8;
                    }
                    break;
            }
            return -1;
        }
        #endregion

    }
}
