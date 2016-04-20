using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MineSweeperKata.Tests
{
    [TestClass]
    public class MineSweeperTests
    {
        [TestMethod]
        public void IsMine_Asterix_ReturnsTrue()
        {
            var sweeper = new MineSweeper();
            var result = sweeper.IsMine('*');

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsMine_NotAsterix_ReturnsFalse()
        {
            var sweeper = new MineSweeper();
            var result = sweeper.IsMine('.');

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CountNeighbourMines_OneMine_ReturnsOne()
        {
            var sweeper = new MineSweeper();
            var grid = new[]
            {
                new[]{ '.', '.', '.' },
                new[]{ '*', '.', '.' },
                new[]{ '.', '.', '.' }
            };

            var expected = 1;

            var result = sweeper.CountNeighbourMines(grid, 0, 0);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountNeighbourMines_TwoMine_ReturnsTwo()
        {
            var sweeper = new MineSweeper();
            var grid = new[]
            {
                new[]{ '*', '.', '.' },
                new[]{ '*', '.', '.' },
                new[]{ '.', '.', '.' }
            };

            var expected = 2;
            var result = sweeper.CountNeighbourMines(grid, 0, 1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountNeighbourMines_1MineAndGivenCoordinateAtBottomCorner_ReturnsOne()
        {
            var sweeper = new MineSweeper();
            var grid = new[]
            {
                new[]{ '*', '.', '.' },
                new[]{ '*', '.', '.' },
                new[]{ '.', '.', '.' }
            };

            var expected = 0;
            var result = sweeper.CountNeighbourMines(grid, 2, 2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountNeighbourMines_EmptyGrid_ReturnsZero()
        {
            var sweeper = new MineSweeper();
            var grid = new char[][] { };

            var expected = 0;
            var result = sweeper.CountNeighbourMines(grid, 2, 2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Solve_GridWithOneMine_ReturnsSolutionGrid()
        {
            var sweeper = new MineSweeper();
            var grid = new[]
            {
                new[]{ '.', '.', '.' },
                new[]{ '*', '.', '.' },
                new[]{ '.', '.', '.' }
            };

            var solutionGrid = new[]
            {
                new[]{ (char)1, (char)1, (char)0 },
                new[]{ '*', (char)1, (char)0 },
                new[]{ (char)1, (char)1, (char)0 }
            };

            var result = sweeper.Solve(grid);

            CollectionAssert.AreEqual(solutionGrid[0], result[0]);
            CollectionAssert.AreEqual(solutionGrid[1], result[1]);
            CollectionAssert.AreEqual(solutionGrid[2], result[2]);
        }
    }
}