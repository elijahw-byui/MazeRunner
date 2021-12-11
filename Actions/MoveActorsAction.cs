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
                    
                    acting.MoveNext();
                    if (acting.isRobinhood())
                    {
                        
                    }
                
                }
            }
        }
    }
}