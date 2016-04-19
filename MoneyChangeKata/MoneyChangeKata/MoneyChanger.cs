using System;
using System.Collections.Generic;

namespace MoneyChangeKata
{
    public class MoneyChanger
    {
        public Dictionary<int, int> Change(int amount)
        {
            return new Dictionary<int, int>
            {
                {50, 0 },
                {25, 0 },
                {10, 0 },
                {5, 0 },
                {1, 0 }
            };
        }
    }
}