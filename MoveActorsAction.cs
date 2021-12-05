using System.Collections.Generic;
using cse210_RH2_csharp.Casting;
using cse210_RH2_csharp.Services;


namespace cse210_RH2_csharp.Scripting
{
    public class MoveActorsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();

        public MoveActorsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {

            foreach (List<Actor> group in cast.Values)
            {
                foreach (Actor acting in group)
                {   
                    //if (acting.isRobinhood())
                    /*{
                        foreach (List<Actor> regroup in cast.Values)
                        {
                            foreach (Actor reacting in regroup)
                            {
                                bool p = reacting.isBrick();
                                if(p)
                                {
                                    bool t =_physicsService.IsCollision(acting,reacting);
                                    if (t)
                                    {
                                       acting.HitsWall(); 
                                    }
                                    else
                                    {
                                        acting.MoveNext();
                                    }
                                }
                                else
                                {
                                    acting.MoveNext();
                                }
                            }
                        }
                    }
                    else*/
                    {
                        acting.MoveNext();
                    }
                }
            }
        }
    }
}