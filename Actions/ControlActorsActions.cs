using System.Collections.Generic;
using cse210_RH2_csharp.Casting;
using cse210_RH2_csharp.Services;


namespace cse210_RH2_csharp.Scripting
{
public class ControlActorsAction : Action
    {
        private InputService _inputService;
        private PhysicsService _physicsService;
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
            
            foreach (List<Actor> group in cast.Values)
            {
                foreach (Actor acting in group)
                    {
                        
                        if (acting.isRobinhood())
                        {
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
