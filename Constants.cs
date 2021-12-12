using System;

namespace cse210_RH2_csharp
{
    /// <summary>
    /// This is a set of program wide constants to be used in other classes.
    /// </summary>
    public static class Constants
    {
        public const int MAX_X = 1440;
        public const int MAX_Y = 872;
        public const int FRAME_RATE = 30;

        public const int DEFAULT_SQUARE_SIZE = 20;
        public const int DEFAULT_FONT_SIZE = 20;
        public const int DEFAULT_TEXT_OFFSET = 4;

        public const string IMAGE_BRICK = "./Assets/brick-3.png";
        public const string IMAGE_BRICK2 = "./Assets/brick-2.png";
        public const string IMAGE_LASER = "./Assets/laser.png";
        public const string IMAGE_WALLTALL = "./Assets/WallTall.png";
        public const string IMAGE_WALLWIDE = "./Assets/WallWide.png";
        public const string IMAGE_RICHGUY = "./Assets/Richguy.png";
        public const string IMAGE_POORGUY = "./Assets/Poorman.png";
        public const string IMAGE_UR = "./Assets/Up_Right.png";
        public const string IMAGE_UL = "./Assets/Up_Left.png";
        public const string IMAGE_DR = "./Assets/Down_Right.png";
        public const string IMAGE_DL = "./Assets/Down_Left.png";
        public const string IMAGE_RR = "./Assets/Right_Right.png";
        public const string IMAGE_RL = "./Assets/Right_Left.png";
        public const string IMAGE_LR = "./Assets/Left_Right.png";
        public const string IMAGE_LL = "./Assets/Left_Left.png";
        public const string IMAGE_DS = "./Assets/Down_Still.png";
        public const string IMAGE_US = "./Assets/Up_Still.png";
        public const string IMAGE_RS = "./Assets/Right_Still.png";
        public const string IMAGE_LS = "./Assets/Left_Still.png";

        public const string IMAGE_PADDLE = "./Assets/bat.png";
        public const string IMAGE_BALL = "./Assets/ball.png";

        public const string SOUND_START = "./Assets/start.wav";
        public const string SOUND_BOUNCE = "./Assets/boing.wav";
        public const string SOUND_OVER = "./Assets/over.wav";

        public const int BALL_X = MAX_X / 2;
        public const int BALL_Y = MAX_Y - 125;

        public const int BALL_DX = 8;
        public const int BALL_DY = BALL_DX * -1;

        public const int PADDLE_X = MAX_X / 2;
        public const int PADDLE_Y = MAX_Y - 25;

        public const int BRICK_WIDTH = 48;
        public const int BRICK_HEIGHT = 24;
        public const int LASER_HEIGHT = 6;
        public const int LASER_WIDTH = 12;
        public const int WALLTALL_HEIGHT = 41;
        public const int WALLTALL_WIDTH = 9;
        public const int WALLWIDE_HEIGHT = 7;
        public const int WALLWIDE_WIDTH = 69;
        public const int RICHGUY_SIZE = 25;
        public const int POORGUY_SIZE = 20;

        public const int BRICK_SPACE = 5;

        public const int PADDLE_SPEED = 15;

        public const int PADDLE_WIDTH = 96;
        public const int PADDLE_HEIGHT = 24;

        public const int BALL_WIDTH = 24;
        public const int BALL_HEIGHT = 24;
    }

}