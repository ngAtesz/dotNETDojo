using System;
using System.Collections.Generic;

namespace MoneyChangeKata
{
    public class MoneyChanger
    {
        private List<int> _coins = new List<int> { 50, 25, 10, 5, 1 };

        public List<int> Coins
        {
            get { return _coins; }
            set { _coins = value; }
        }

        public Dictionary<int, int> Change(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Negative numbers not allowed.");
            }

            var result = new Dictionary<int, int>();

            foreach (var coin in _coins)
            {
                var value = 0;
                if (amount >= coin)
                {
                    value = amount / coin;
                    amount -= value * coin;
                }
                result.Add(coin, value);
            }

            return result;
        }
    }
}