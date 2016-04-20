using System;
using System.Collections.Generic;

namespace MineSweeperKata
{
    public class MineSweeper
    {
        private readonly int[][] _directions = new[]
        {
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

                if (neighbourX >= 0
                    && neighbourY >= 0
                    && IsMine(grid[neighbourX][neighbourY]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}