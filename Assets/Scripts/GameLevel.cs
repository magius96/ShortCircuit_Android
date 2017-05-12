using System;

namespace Assets.Scripts
{
    public class GameLevel
    {
        public const int RED = 0;
        public const int YLW = 1;
        public const int GRN = 2;
        public const int OFF = 3;
        public const int LIT = 4;

        public int[,] MapButtons;

        public string Id = "";

        public int MapSize { get { return _mapGridSize; } }
        public int MinimumMoves { get {  return _minimumMoves; } }
        public int Par { get { return _par; } }

        private int _mapGridSize = 5;
        private int _minimumMoves = 0;
        private int _par = 0;

        public virtual GameLevel NextLevel { get { return null; } }

        protected void Initialize(int mapGridSize, int minimumMoves)
        {
            _mapGridSize = mapGridSize;
            _minimumMoves = minimumMoves;
            MapButtons = new int[MapSize, MapSize];
            _par = (int)Math.Round(MinimumMoves * 1.2, 0);
        }

        private void PrepArray(int gridSize)
        {
            MapButtons = new int[gridSize, gridSize];
            for (var x = 0; x < gridSize; x++)
            {
                for (var y = 0; y < gridSize; y++)
                {
                    MapButtons[x, y] = LIT;
                }
            }
        }

        public GameLevel(string id)
        {
            Id = id;
            PrepArray(5);
        }
    }
}
