using Microsoft.VisualStudio.TestTools.UnitTesting;
using MineSweeperKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperKata.Tests
{
    [TestClass()]
    public class MineSweeperTests
    {
        [TestMethod()]
        public void IsMine_Asterix_ReturnsTrue()
        {
            var sweeper = new MineSweeper();
            var result = sweeper.IsMine('*');

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsMine_NotAsterix_ReturnsFalse()
        {
            var sweeper = new MineSweeper();
            var result = sweeper.IsMine('.');

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CountNeighbourMines_OneMine_ReturnsOne()
        {
            var sweeper = new MineSweeper();
            var grid = new char[][]
            {
                new char[]{ '.', '.', '.' },
                new char[]{ '*', '.', '.' },
                new char[]{ '.', '.', '.' }
            };

            var expected = 1;

            var result = sweeper.CountNeighbourMines(grid, 0, 0);

            Assert.AreEqual(expected, result);
        }
        
        [TestMethod()]
        public void CountNeighbourMines_TwoMine_ReturnsTwo()
        {
            var sweeper = new MineSweeper();
            var grid = new char[][]
            {
                new char[]{ '*', '.', '.' },
                new char[]{ '*', '.', '.' },
                new char[]{ '.', '.', '.' }
            };

            var expected = 2;
            var result = sweeper.CountNeighbourMines(grid, 0, 1);

            Assert.AreEqual(expected, result);
        }
    }
}