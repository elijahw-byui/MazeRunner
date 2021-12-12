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
                    upy += 42;
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
                    upx += 69;
                }
            }
            // Builds the frame of the game.
            CreateTallWall(21, new Point(0,0));
            CreateWideWall(21, new Point(0,0));
            CreateTallWall(21, new Point(1431,0));
            CreateWideWall(21, new Point(0,865));
            // Builds the vertical walls of the maze in the game.
            CreateTallWall(4, new Point(69,83));
            CreateTallWall(6, new Point(69,332));
            CreateTallWall(2, new Point(69,622));
            CreateTallWall(2, new Point(69,747));
            CreateTallWall(3, new Point(138,83));
            CreateTallWall(4, new Point(138,373));
            CreateTallWall(2, new Point(138,664));
            CreateTallWall(2, new Point(138,788));
            CreateTallWall(3, new Point(207,125));
            CreateTallWall(3, new Point(207,373));
            CreateTallWall(3, new Point(207,747));
            CreateTallWall(1, new Point(271,42));
            CreateTallWall(3, new Point(276,166));
            CreateTallWall(1, new Point(276,332));
            CreateTallWall(3, new Point(276,415));
            CreateTallWall(1, new Point(276,664));
            CreateTallWall(1, new Point(276,788));
            CreateTallWall(1, new Point(343,0));
            CreateTallWall(4, new Point(343,208));
            CreateTallWall(3, new Point(343,456));
            CreateTallWall(1, new Point(343,622));
            CreateTallWall(1, new Point(414,42));
            CreateTallWall(4, new Point(414,250));
            CreateTallWall(5, new Point(414,456));
            CreateTallWall(1, new Point(414,747));
            CreateTallWall(1, new Point(483,0));
            CreateTallWall(13, new Point(483,291));
            CreateTallWall(10, new Point(552,250));
            CreateTallWall(3, new Point(552,747));
            CreateTallWall(8, new Point(621,208));
            CreateTallWall(1, new Point(621,621));
            CreateTallWall(3, new Point(621,747));
            CreateTallWall(5, new Point(690,166));
            CreateTallWall(3, new Point(690,415));
            CreateTallWall(6, new Point(690,581));
            CreateTallWall(5, new Point(759,125));
            CreateTallWall(3, new Point(759,456));
            CreateTallWall(6, new Point(759,622));
            CreateTallWall(1, new Point(828,42));
            CreateTallWall(5, new Point(828,125));
            CreateTallWall(3, new Point(828,456));
            CreateTallWall(2, new Point(828,622));
            CreateTallWall(2, new Point(828,747));
            CreateTallWall(5, new Point(897,166));
            CreateTallWall(3, new Point(897,415));
            CreateTallWall(3, new Point(897,581));
            CreateTallWall(1, new Point(897,788));
            CreateTallWall(7, new Point(966,208));
            CreateTallWall(2, new Point(966,581));
            CreateTallWall(3, new Point(966,747));
            CreateTallWall(3, new Point(1035,250));
            CreateTallWall(1, new Point(1035,456));
            CreateTallWall(3, new Point(1035,581));
            CreateTallWall(1, new Point(1035,788));
            CreateTallWall(2, new Point(1104,291));
            CreateTallWall(3, new Point(1104,415));
            CreateTallWall(3, new Point(1104,622));
            CreateTallWall(3, new Point(1173,291));
            CreateTallWall(6, new Point(1173,456));
            CreateTallWall(1, new Point(1173,7));
            CreateTallWall(2, new Point(1242,42));
            CreateTallWall(3, new Point(1242,250));
            CreateTallWall(5, new Point(1242,498));
            CreateTallWall(1, new Point(1311,125));
            CreateTallWall(3, new Point(1311,250));
            CreateTallWall(5, new Point(1311,498));
            CreateTallWall(2, new Point(1380,125));
            CreateTallWall(1, new Point(1380,250)); 
            CreateTallWall(3, new Point(1380,332));
            CreateTallWall(8, new Point(1380,498));

            // Builds the horizontal wall of the maze in the game. 
            CreateWideWall(4, new Point(4,42));
            CreateWideWall(4, new Point(552,42));
            CreateWideWall(4, new Point(897,42));
            CreateWideWall(2, new Point(1242,42));
            CreateWideWall(4, new Point(4,83));
            CreateWideWall(17, new Point(345,83));
            CreateWideWall(7, new Point(276,125));
            CreateWideWall(6, new Point(837,125));
            CreateWideWall(6, new Point(276,166));
            CreateWideWall(6, new Point(897,166));
            CreateWideWall(4, new Point(352,208));
            CreateWideWall(6, new Point(973,208));
            CreateWideWall(2, new Point(78,250));
            CreateWideWall(2, new Point(423,250));
            CreateWideWall(3, new Point(1044,250));
            CreateWideWall(2, new Point(1320,250));
            CreateWideWall(4, new Point(4,291));
            CreateWideWall(1, new Point(1104,291));
            CreateWideWall(3, new Point(69,332));
            CreateWideWall(1, new Point(759,332));
            CreateWideWall(1, new Point(276,373));
            CreateWideWall(3, new Point(690,373));
            CreateWideWall(1, new Point(1242,373));
            CreateWideWall(3, new Point(207,415));
            CreateWideWall(3, new Point(690,415));
            CreateWideWall(6, new Point(966,415));
            CreateWideWall(1, new Point(345,456));
            CreateWideWall(1, new Point(759,456));
            CreateWideWall(3, new Point(1173,456));
            CreateWideWall(1, new Point(966,498));
            CreateWideWall(2, new Point(1242,498));
            CreateWideWall(2, new Point(138,539));
            CreateWideWall(1, new Point(621,539));
            CreateWideWall(3, new Point(897,539));
            CreateWideWall(4, new Point(69,581));
            CreateWideWall(5, new Point(552,581));
            CreateWideWall(3, new Point(966,581));
            CreateWideWall(4, new Point(69,622));
            CreateWideWall(1, new Point(759,622));
            CreateWideWall(2, new Point(138,664));
            CreateWideWall(1, new Point(345,664));
            CreateWideWall(1, new Point(552,664));
            CreateWideWall(7, new Point(207,705));
            CreateWideWall(1, new Point(966,705));
            CreateWideWall(1, new Point(1173,705));
            CreateWideWall(1, new Point(4,705));
            CreateWideWall(5, new Point(69,747));
            CreateWideWall(7, new Point(828,747));
            CreateWideWall(1, new Point(276,788));
            CreateWideWall(5, new Point(1035,788));
            CreateWideWall(3, new Point(276,829));
            CreateWideWall(1, new Point(828,829));
            CreateWideWall(4, new Point(1035,829));
            
            
            
            

            cast["Robinhood"] = new List<Actor>();

            Robinhood one = new Robinhood();
            Point start = new Point(30,842);
            one.SetPosition(start);
            one.SetImage(Constants.IMAGE_UR);
            one.SetWidth(Constants.BALL_WIDTH);
            one.SetHeight(Constants.BALL_HEIGHT);
            cast["Robinhood"].Add(one);
            // The Ball (or balls if desired)
            cast["Richguys"] = new List<Actor>();
            void CreateRichGuys(Point danger, Point velocity)
            {
                Richguy dummy = new Richguy();
                dummy.SetPosition(danger);
                dummy.SetImage(Constants.IMAGE_RICHGUY_UP);
                dummy.SetHeight(Constants.RICHGUY_SIZE);
                dummy.SetWidth(Constants.RICHGUY_SIZE);
                cast["Richguys"].Add(dummy);
                dummy.SetVelocity(velocity);

            }
            CreateRichGuys(new Point(300,500), new Point(0,3));
            CreateRichGuys(new Point(500,430), new Point(0,3));
            CreateRichGuys(new Point(650,200), new Point(0,3));
            CreateRichGuys(new Point(230,135), new Point(3,0));
            CreateRichGuys(new Point(500,14), new Point(5,0));
            CreateRichGuys(new Point(1390,836), new Point(0,3));
            CreateRichGuys(new Point(207,300), new Point(3,0));
            CreateRichGuys(new Point(200,590), new Point(4,0));
            CreateRichGuys(new Point(207,15), new Point(3,0));
            CreateRichGuys(new Point(300,840), new Point(4,0));
            CreateRichGuys(new Point(800,92), new Point(3,0));
            CreateRichGuys(new Point(1035,134), new Point(4,0));
            CreateRichGuys(new Point(1350,92), new Point(3,0));
            CreateRichGuys(new Point(900,714), new Point(4,0));
            CreateRichGuys(new Point(1200,797), new Point(3,0));
            CreateRichGuys(new Point(1200,216), new Point(4,0));
            CreateRichGuys(new Point(1320,300), new Point(0,3));
            CreateRichGuys(new Point(910,400), new Point(0,3));
            CreateRichGuys(new Point(700,700), new Point(0,3));
            CreateRichGuys(new Point(155,830), new Point(0, 2));


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
            sympathy.SetPosition(new Point(1260,58));
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
