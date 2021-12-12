using System.Collections.Generic;
using cse210_RH2_csharp.Casting;
using cse210_RH2_csharp.Services;


namespace cse210_RH2_csharp.Scripting
{
public class ShootArrow : Action
    {
        bool b = false;
        private InputService _inputService;
        public ShootArrow(InputService inputService)
        {
            _inputService = inputService;
        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            b = _inputService.IsSpacePressed();
            Point speed = _inputService.GetDirection();
            Arrow shot2 = new Arrow();
            Point loc = new Point(0,0);
            Point loc2 = new Point(0,0);
            int stablex = 0;
            int stabley = 0;
            foreach (List<Actor> group in cast.Values)
            {
                
                foreach (Actor acting in group)
                    {
                            if (acting.isRobinhood())
                            {
                                loc = acting.GetPosition();
                                string facing = acting.GetImage();
                                if (facing == Constants.IMAGE_DL || facing == Constants.IMAGE_DR)
                                {
                                    stabley = 10;
                                }
                                else if (facing == Constants.IMAGE_RL || facing == Constants.IMAGE_RR)
                                {
                                    stablex = 10;
                                }
                                else if (facing == Constants.IMAGE_UL || facing == Constants.IMAGE_UR)
                                {
                                    stabley = -10;
                                }
                                else if (facing == Constants.IMAGE_LL || facing == Constants.IMAGE_LR)
                                {
                                    stablex = -10;
                                }



                            }
                            if (b && acting.isArrow())
                            {
                                acting.SetPosition(loc);
                                acting.SetImage(Constants.IMAGE_LASER);
                                acting.SetHeight(Constants.LASER_HEIGHT);
                                acting.SetWidth(Constants.LASER_WIDTH);
                                acting.SetVelocity(speed);
                                
                                
                                int x = speed.GetX() * 10;
                                int y = speed.GetY() * 10;
                                if (x == 0 && y == 0)
                                {
                                    x = stablex;
                                    y = stabley;
                                }
                                Point speedNew = new Point(x,y);
                                acting.SetVelocity(speedNew);
                                acting.MoveNext();
                            }
                    }
            }
            
        }
    }
}