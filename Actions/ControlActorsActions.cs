using System.Collections.Generic;
using cse210_RH2_csharp.Casting;
using cse210_RH2_csharp.Services;



namespace cse210_RH2_csharp.Scripting
{
public class ControlActorsAction : Action
    {
        private InputService _inputService;
        private PhysicsService _physicsService;
        private bool first = true;
        int counter = 0;
 
        public ControlActorsAction(InputService inputService, PhysicsService physicsService)
        {
            _inputService = inputService;
            _physicsService = physicsService;
        }
        public override bool CheckGameOver()
        {
            return false;
        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Point p = _inputService.GetDirection();
            int up = p.GetY();
            
            
            foreach (List<Actor> group in cast.Values)
            {
                foreach (Actor acting in group)
                    {
                        
                        if (acting.isRobinhood())
                        {
                            if (up == -1)
                            {
                                bool second = !first;
                                if (counter%5 == 0)
                                {
                                if (second)
                                {
                                    acting.SetImage(Constants.IMAGE_UL);   
                                }
                                else if (!second)
                                {
                                    acting.SetImage(Constants.IMAGE_UR);
                                }
                                }
                                counter++;                                
                                first = second;
                            }
                            foreach (List<Actor> regroup in cast.Values)
                            {
                                foreach (Actor reacting in regroup)
                                {
                                    if (reacting.isBrick())
                                    {
                                        bool t = !_physicsService.IsCollision(acting,reacting);
                                        if (t)
                                        {
                                        
                                            int x = (p.GetX() * -1);
                                            int y = (p.GetY() * -1);
                                            acting.MoveDirection(new Point(x,y));
                                        }
                                    }
                                    else
                                    {
                                        acting.MoveDirection(p); 
                                    }
                                }
                            }
                        }
                    }
            }
            
        }
    }
}
