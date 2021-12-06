using System;

namespace cse210_RH2_csharp.Casting
{
    /// <summary>
    /// </summary>
    public class Arrow : Actor
    {
        public override bool isArrow()
        {
            return true;
        }
        public bool isDead()
        {
            return false;
        }
    }
}