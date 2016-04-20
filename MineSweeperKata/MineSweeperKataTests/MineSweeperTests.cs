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
    }
}