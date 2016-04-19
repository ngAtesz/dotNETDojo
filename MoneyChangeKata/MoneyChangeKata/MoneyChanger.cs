using System;
using System.Collections.Generic;

namespace MoneyChangeKata
{
    public class MoneyChanger
    {
        public Dictionary<int, int> Change(int amount)
        {
            var result = new Dictionary<int, int>
            {
                {50, 0 },
                {25, 0 },
                {10, 0 },
                {5, 0 },
                {1, 0 }
            };

            if (amount >= 5)
            {
                result[5] = amount/5;
                amount -= result[5]*5;
            }

            if (amount > 0)
            {
                result[1] = amount;
            }

            return result;
        }
    }
}