using System;
using System.Collections;

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

        public char[][] Solve(char[][] grid)
        {
            var result = new char[grid.Length][];

            for (var i = 0; i < grid.Length; i++)
            {
                var sizeY = grid[i].Length;
                result[i] = new char[sizeY];

                for (var j = 0; j < sizeY; j++)
                {
                    if (IsMine(grid[i][j]))
                    {
                        result[i][j] = '*';
                    }
                    else
                    {
                        result[i][j] = (char)CountNeighbourMines(grid, i, j);
                    }
                }
            }

            return result;
        }
    }
}