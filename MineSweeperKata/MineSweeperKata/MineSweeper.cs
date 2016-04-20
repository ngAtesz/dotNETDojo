namespace MineSweeperKata
{
    public class MineSweeper
    {
        private readonly int[][] _directions = {
            new []{ -1, -1 },
            new []{ -1, 0 },
            new []{ -1, 1 },
            new []{ 0, -1 },
            new []{ 0, 1 },
            new []{ 1, -1 },
            new []{ 1, 0 },
            new []{ 1, 1 }
        };

        public bool IsMine(char field)
        {
            return field == '*';
        }

        public int CountNeighbourMines(char[][] grid, int x, int y)
        {
            var count = 0;

            foreach (var direction in _directions)
            {
                var neighbourX = x + direction[0];
                var neighbourY = y + direction[1];
                
                if (neighbourIsOnTheGrid(neighbourX, neighbourY, grid)
                    && IsMine(grid[neighbourX][neighbourY]))
                {
                    count++;
                }
            }

            return count;
        }

        private static bool neighbourIsOnTheGrid(int neighbourX, int neighbourY, char[][] grid)
        {
            var maxX = grid.Length;
            var maxY = grid.Length > 0 ? grid[0].Length : 0;

            return neighbourX >= 0
                   && neighbourY >= 0
                   && neighbourX < maxX
                   && neighbourY < maxY;
        }
    }
}