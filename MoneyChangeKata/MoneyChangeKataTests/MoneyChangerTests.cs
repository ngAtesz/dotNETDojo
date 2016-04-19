using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MoneyChangeKata.Tests
{
    [TestClass()]
    public class MoneyChangerTests
    {
        [TestMethod()]
        public void Change_Zero_ReturnsDictionaryWithZeroValues()
        {
            var money = 0;
            var changer = new MoneyChanger();
            var result = changer.Change(money);
            var expected = new Dictionary<int, int>
            {
                {50, 0 },
                {25, 0 },
                {10, 0 },
                {5, 0 },
                {1, 0 }
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Change_One_Returns1One()
        {
            var money = 1;
            var changer = new MoneyChanger();
            var result = changer.Change(money);
            var expected = new Dictionary<int, int>
            {
                {50, 0 },
                {25, 0 },
                {10, 0 },
                {5, 0 },
                {1, 1 }
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}