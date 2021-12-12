using System.Collections.Generic;
using cse210_RH2_csharp.Casting;
using cse210_RH2_csharp.Services;


namespace cse210_RH2_csharp.Scripting
{
    public class MoveActorsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();
        private bool first = true;
        private int counter = 0;

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
                    if (acting.isRichguy())
                    {
                        Point p = acting.GetVelocity();
                        int x = p.GetX();
                        int y = p.GetY();
                        if (y < 0)
                        {
                            bool second = !first;
                                
                                    if (second)
                                    {
                                        acting.SetImage(Constants.IMAGE_UL);   
                                    }
                                    else if (!second)
                                    {
                                        acting.SetImage(Constants.IMAGE_UR);
                                    }
                                
                            counter++;                                
                            first = second;
                        
                        }
                        else if (y > 0)
                        {
                            bool second = !first;
                                
                                if (second)
                                {
                                    acting.SetImage(Constants.IMAGE_DL);   
                                }
                                else if (!second)
                                {
                                    acting.SetImage(Constants.IMAGE_DR);
                                }
                                
                                counter++;                                
                                first = second;
                        }
                        else if (x < 0)
                        {
                            bool second = !first;
                                
                                if (second)
                                {
                                    acting.SetImage(Constants.IMAGE_LL);   
                                }
                                else if (!second)
                                {
                                    acting.SetImage(Constants.IMAGE_LR);
                                }
                                
                                counter++;                                
                                first = second;
                        }
                        else if (x > 0)
                        {
                            bool second = !first;
                                
                                if (second)
                                {
                                    acting.SetImage(Constants.IMAGE_RL);   
                                }
                                else if (!second)
                                {
                                    acting.SetImage(Constants.IMAGE_RR);
                                }
                            
                                counter++;                                
                                first = second;
                        }
                    }
                
                }
            }
        }
    }
}