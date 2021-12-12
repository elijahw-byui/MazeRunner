using System.Collections.Generic;
using cse210_RH2_csharp.Casting;
using cse210_RH2_csharp.Services;


namespace cse210_RH2_csharp.Scripting
{
    public class CollectCoins : Action
    {
        int coins = 0; 
        PhysicsService _physicsService = new PhysicsService();
        OutputService _outputService = new OutputService();
        public CollectCoins(PhysicsService physicsService, OutputService outputService)
        {
            _physicsService = physicsService;
            _outputService = outputService;
        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            _outputService.DrawText(50,50,coins.ToString(),false);
            foreach (List<Actor> group in cast.Values)
            {
                foreach (Actor acting in group)
                {       
                    if (acting.isArrow())
                    {
                        string text = acting.GetImage();
                        foreach (List<Actor> regroup in cast.Values)
                        {
                            foreach (Actor reacting in regroup)
                            {
                                
                                if (reacting.isRichguy())
                                {
                                    if (_physicsService.IsCollision(acting,reacting))
                                    {
                                        coins +=1000;
                                    } 
                                }
                            }
                        }
                    }
                }
            }
        
        }


    }
}