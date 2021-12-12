using System;

namespace cse210_RH2_csharp.Casting
{
    /// <summary>
    /// </summary>
    public class Coin : Actor
    {
        private int score = 0;
        public override bool isCoin()
        {
            return true;
        }

        public string scorePoints(int points)
        {
            score += points;
            return score.ToString();
        }

    }
}