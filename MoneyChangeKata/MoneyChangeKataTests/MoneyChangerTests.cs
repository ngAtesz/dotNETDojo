﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod()]
        public void Change_Three_Returns3One()
        {
            var money = 3;
            var changer = new MoneyChanger();
            var result = changer.Change(money);
            var expected = new Dictionary<int, int>
            {
                {50, 0 },
                {25, 0 },
                {10, 0 },
                {5, 0 },
                {1, 3 }
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Change_Five_Returns1Five()
        {
            var money = 5;
            var changer = new MoneyChanger();
            var result = changer.Change(money);
            var expected = new Dictionary<int, int>
            {
                {50, 0 },
                {25, 0 },
                {10, 0 },
                {5, 1 },
                {1, 0 }
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Change_Seven_Returns1Five2One()
        {
            var money = 7;
            var changer = new MoneyChanger();
            var result = changer.Change(money);
            var expected = new Dictionary<int, int>
            {
                {50, 0 },
                {25, 0 },
                {10, 0 },
                {5, 1 },
                {1, 2 }
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Change_Thirteen_Returns1Ten3One()
        {
            var money = 13;
            var changer = new MoneyChanger();
            var result = changer.Change(money);
            var expected = new Dictionary<int, int>
            {
                {50, 0 },
                {25, 0 },
                {10, 1 },
                {5, 0 },
                {1, 3 }
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Negative numbers not allowed.")]
        public void Change_NegativeAmount_ThrowArgumentException()
        {
            var money = -13;
            var changer = new MoneyChanger();
            var result = changer.Change(money);
            var expected = new Dictionary<int, int>
            {
                {50, 0 },
                {25, 0 },
                {10, 1 },
                {5, 0 },
                {1, 3 }
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}