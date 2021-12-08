using System;
using cse210_RH2_csharp.Services;
using cse210_RH2_csharp.Casting;
using cse210_RH2_csharp.Scripting;
using System.Collections.Generic;

namespace cse210_RH2_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();
            
            cast["bricks"] = new List<Actor>();

            void CreateTallWall(int howMany, Point start)
            {
                int startx = start.GetX();
                int starty = start.GetY();
                int upy = starty;
                for (int i = 0; i < howMany; i++)
                {
                    
                    BrickWall four = new BrickWall();
                    four.SetPosition(new Point(startx, upy));
                    four.SetImage(Constants.IMAGE_WALLTALL);
                    four.SetWidth(Constants.WALLTALL_WIDTH);
                    four.SetHeight(Constants.WALLTALL_HEIGHT);
                    four.SetTall(true);
                    cast["bricks"].Add(four);
                    upy += 100;
                }
            }
            void CreateWideWall(int howMany, Point start)
            {
                int startx = start.GetX();
                int starty = start.GetY();
                int upx = startx;
                for (int i = 0; i < howMany; i++)
                {
                    
                    BrickWall four = new BrickWall();
                    four.SetPosition(new Point(upx, starty));
                    four.SetImage(Constants.IMAGE_WALLWIDE);
                    four.SetWidth(Constants.WALLWIDE_WIDTH);
                    four.SetHeight(Constants.WALLWIDE_HEIGHT);
                    four.SetWide(true);
                    cast["bricks"].Add(four);
                    upx += 100;
                }
            }
            // Builds the frame of the game.
            CreateTallWall(6, new Point(0,0));
            CreateWideWall(8, new Point(0,0));
            CreateTallWall(6, new Point(790,0));
            CreateWideWall(8, new Point(0,590));
            // Builds the vertical walls of the maze in the game.
            CreateTallWall(2, new Point(200,390));
            CreateTallWall(5, new Point(400,50));
            CreateTallWall(2, new Point(600,390));
            CreateTallWall(2, new Point(700,330));
            CreateTallWall(2, new Point(100,0));
            // Builds the horizontal wall of the maze in the game. 
            CreateWideWall(1, new Point(200,390));
            CreateWideWall(7, new Point(0,330));
            CreateWideWall(2, new Point(100,200));
            CreateWideWall(5, new Point(200, 50));
            CreateWideWall(3, new Point(490,180));
            
            

            cast["Robinhood"] = new List<Actor>();

            Robinhood one = new Robinhood();
            Point start = new Point(30,550);
            one.SetPosition(start);
            one.SetImage(Constants.IMAGE_BALL);
            one.SetWidth(Constants.BALL_WIDTH);
            one.SetHeight(Constants.BALL_HEIGHT);
            cast["Robinhood"].Add(one);
            // The Ball (or balls if desired)
            cast["Richguys"] = new List<Actor>();
            void CreateRichGuys(Point danger, Point velocity)
            {
                Richguy dummy = new Richguy();
                dummy.SetPosition(danger);
                dummy.SetImage(Constants.IMAGE_RICHGUY);
                dummy.SetHeight(Constants.RICHGUY_SIZE);
                dummy.SetWidth(Constants.RICHGUY_SIZE);
                cast["Richguys"].Add(dummy);
                dummy.SetVelocity(velocity);

            }
            CreateRichGuys(new Point(300,500), new Point(3,0));
            CreateRichGuys(new Point(500,430), new Point(2,2));
            CreateRichGuys(new Point(650,200), new Point(1,2));
            CreateRichGuys(new Point(200,150), new Point(2,1));
            


            // TODO: Add your ball here
            cast["arrows"] = new List<Actor>();
            Arrow shot = new Arrow();
            Point shotloc = new Point(1,1);
            shot.SetPosition(shotloc);
            shot.SetImage(Constants.IMAGE_LASER);
            shot.SetHeight(6);
            shot.SetWidth(12);
            cast["arrows"].Add(shot);

            /*Arrow shot2 = new Arrow();
            Point shotloc2 = new Point(100,100);
            shot.SetPosition(shotloc2);
            shot.SetImage(Constants.IMAGE_LASER);
            shot.SetHeight(6);
            shot.SetWidth(12);
            
            cast["arrows"].Add(shot2);*/

            
            // The paddle
            cast["Poorguy"] = new List<Actor>();
            Poorguy sympathy = new Poorguy();
            sympathy.SetPosition(new Point(30,30));
            sympathy.SetImage(Constants.IMAGE_POORGUY);
            sympathy.SetHeight(Constants.POORGUY_SIZE);
            sympathy.SetWidth(Constants.POORGUY_SIZE);
            cast["Poorguy"].Add(sympathy);
            

            // TODO: Add your paddle here

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            CheckGameOver checkGameOver = new CheckGameOver();
            script["output"].Add(checkGameOver);
            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);
            ControlActorsAction controlActorsAction = new ControlActorsAction(inputService, physicsService);
            script["input"].Add(controlActorsAction);
            ShootArrow shootArrow = new ShootArrow(inputService);
            script["input"].Add(shootArrow);
            MoveActorsAction moveActorsAction = new MoveActorsAction(physicsService);
            script["update"].Add(moveActorsAction);
            HandleCollisionAction handleCollisionAction = new HandleCollisionAction(physicsService, audioService);
            script["update"].Add(handleCollisionAction);
            
            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "RH2", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);
            
            Director theDirector = new Director(cast, script);
            theDirector.Direct();
            

            audioService.StopAudio();
        }
    }
}
