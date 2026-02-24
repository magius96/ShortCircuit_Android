using System;

namespace Assets.Scripts.Levels
{
    class InfiniteLevel : GameLevel
    {
        private Random _rand = new Random();
        private int[,] _switches;

        public InfiniteLevel()
            : base("InfiniteLevel", "Infinite")
        {
            // This level should never be displayed.
            Initialize(Globals.InfiniteLevelGridSize, Globals.InfiniteLevelMoves);
            SetupGrid();
            for (var m = 0; m < Globals.InfiniteLevelMoves; m++)
            {
                SimulateReverseMove();
            }
        }
        public override GameLevel NextLevel
        {
            get { return new InfiniteLevel(); }
        }

        private void SetupGrid()
        {
            MapButtons = new int[Globals.InfiniteLevelGridSize, Globals.InfiniteLevelGridSize];
            _switches = new int[Globals.InfiniteLevelGridSize, Globals.InfiniteLevelGridSize];
            for (var i = 0; i < Globals.InfiniteLevelGridSize; i++)
            {
                for (var j = 0; j < Globals.InfiniteLevelGridSize; j++)
                {
                    _switches[i, j] = 0;
                    if (Globals.InfiniteLevelUses3Phase)
                    {
                        if (_rand.Next(0, 10000) >= 5000)
                        {
                            MapButtons[i, j] = OFF;
                        }
                        else
                        {
                            MapButtons[i, j] = RED;
                        }
                    }
                    else
                    {
                        MapButtons[i, j] = OFF;
                    }
                }
            }
        }

        private void SimulateReverseMove()
        {
            var i = -1;
            var j = -1;
            while (!CanMove(i, j))
            {
                i = _rand.Next(10000) % Globals.InfiniteLevelGridSize;
                j = _rand.Next(10000) % Globals.InfiniteLevelGridSize;
            }
            DoMove(i, j);
        }

        private bool CanMove(int i, int j)
        {
            if (i == -1 || j == -1) return false;
            if (IsTwoPhase(i, j) && _switches[i, j] > 0) return false;
            if (!IsTwoPhase(i, j) && _switches[i, j] > 1) return false;
            return true;
        }

        private bool IsTwoPhase(int i, int j)
        {
            return MapButtons[i, j] == OFF || MapButtons[i, j] == LIT;
        }

        private void DoMove(int i, int j)
        {
            SwitchButton(i - 1, j);
            SwitchButton(i, j - 1);
            SwitchButton(i, j);
            SwitchButton(i + 1, j);
            SwitchButton(i, j + 1);
            _switches[i, j]++;
        }

        private void SwitchButton(int i, int j)
        {
            if (i < 0 || j < 0 || i >= Globals.InfiniteLevelGridSize || j >= Globals.InfiniteLevelGridSize) return;
            switch (MapButtons[i, j])
            {
                case GRN:
                    MapButtons[i, j] = RED;
                    break;
                case YLW:
                    MapButtons[i, j] = GRN;
                    break;
                case RED:
                    MapButtons[i, j] = YLW;
                    break;
                case LIT:
                    MapButtons[i, j] = OFF;
                    break;
                case OFF:
                    MapButtons[i, j] = LIT;
                    break;
            }
        }
    }
}
