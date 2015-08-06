using System.Collections.Generic;

namespace oqhra_android
{
    public class betting
    {
        public betting()
        {
        }

        public double calcReturns(int r1, int r2, double wager)
        {
            if (r2 == 0)
                return (r1 * wager) + wager;
            else
                return ((r1 / r2) * wager) + wager;
        }

        public double calcWagers(int r1, int r2, double wager, int routine)
        {
            // routine marries up with SiteFunction.js
            double ans = 0;
            switch (routine)
            {
                case 0: ans = r1 * r2 * wager;
                    break;
                case 1: ans = r1 * (r1 - 1) * wager;
                    break;
                case 2: ans = r1 * wager;
                    break;
                case 3: List<int> multiplier = new List<int>();
                    multiplier.AddRange(new int[] { 2, 6, 12, 20, 30, 42, 56, 72, 90, 110 });
                    ans = r1 * multiplier[r1 - 3];
                    break;
            }
            return ans;
        }
    }
}