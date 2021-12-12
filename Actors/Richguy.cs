using System;

namespace cse210_RH2_csharp.Casting
{
    /// <summary>
    /// </summary>
    public class Richguy : Actor
    {
        bool reset = false;
        public override bool isRichguy()
        {
            return true;
        }
        public override void switchImage()
        {
            bool set = !reset;
            
            reset = set; 
        }
    }
}