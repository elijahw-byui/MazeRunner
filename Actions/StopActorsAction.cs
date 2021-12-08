using System.Collections.Generic;
using cse210_RH2_csharp.Casting;
using cse210_RH2_csharp.Services;


namespace cse210_RH2_csharp.Scripting
{
    public class StopActorsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();
        public StopActorsAction(PhysicsService physicsService)
        {

        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            //throw new System.NotImplementedException();
        }

    }
}