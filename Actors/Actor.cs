using System;

namespace cse210_RH2_csharp.Casting
{
    /// <summary>
    /// Base class for all actors in the game.
    /// </summary>
    public class Actor
    {
        protected Point _position;
        protected Point _velocity;

        protected int _width = 0;
        protected int _height = 0;

        protected string _text = "";
        private string _image = "";
        
        private bool _isWide = false;
        private bool _isTall = false;

        public Actor()
        {
            // Start these at 0, 0 by default
            _position = new Point(0, 0);
            _velocity = new Point(0, 0);
        }


        public void SetImage(string image)
        {
            _image = image;
        }

        public string GetImage()
        {
            return _image;
        }

        public bool HasImage()
        {
            return _image != "";
        }

        public bool HasText()
        {
            return _text != "";
        }

        public bool HasBox()
        {
            return _width > 0 && _height > 0;
        }

        public string GetText()
        {
            return _text;
        }

        public void SetText(string text)
        {
            _text = text;
        }

        public int GetX()
        {
            return _position.GetX();
        }

        public int GetY()
        {
            return _position.GetY();
        }

        public int GetLeftEdge()
        {
            return _position.GetX();
        }

        public int GetRightEdge()
        {
            return _position.GetX() + _width;
        }

        public int GetTopEdge()
        {
            return _position.GetY();
        }

        public int GetBottomEdge()
        {
            return _position.GetY() + _height;
        }

        public int GetWidth()
        {
            return _width;
        }

        public void SetWidth(int width)
        {
            _width = width;
        }

        public int GetHeight()
        {
            return _height;
        }

        public void SetHeight(int height)
        {
            _height = height;
        }

        public Point GetPosition()
        {
            return _position;
        }

        public void SetPosition(Point position)
        {
            _position = position;
        }

        public Point GetVelocity()
        {
            return _velocity;
        }

        public void SetVelocity(Point newVelocity)
        {
            _velocity = newVelocity;
        }

        public void MoveNext()
        {
            int x = _position.GetX();
            int y = _position.GetY();

            int dx = _velocity.GetX();
            int dy = _velocity.GetY();

            int newX = (x + dx) % Constants.MAX_X;
            int newY = (y + dy) % Constants.MAX_Y;

            if (newX < 0)
            {
                newX = Constants.MAX_X;
            }

            if (newY < 0)
            {
                newY = Constants.MAX_Y;
            }

            _position = new Point(newX, newY);
        }
       
        public void MoveDirection(Point move)
        {
            int x = (move.GetX() * 4);
            int y = (move.GetY() * 4);
            _velocity = new Point(x,y);
        }
        public void HitsWall(Actor acting)
        {
            int dx = (_velocity.GetX() * -1);
            int dy = (_velocity.GetY() * -1);
            _velocity = new Point(dx, dy);
        }

        public virtual bool isRobinhood()
        {
            return false; 
        }
        public virtual bool isArrow()
        {
            return false;
        }
        public virtual bool isBrick()
        {
            return false;
        }
        public bool isWallTall()
        {
            return _isTall;
        }
        public void SetWide(bool wide)
        {
            _isWide = wide;
        }
        public virtual bool isWallWide()
        {
            return _isWide;
        }
        public void SetTall(bool tall)
        {
            _isTall = tall;
        }
        public virtual bool isRichguy()
        {
            return false;
        }
        public virtual bool isPoorguy()
        {
            return false;
        }
        public virtual bool isCoin()
        {
            return false; 
        }

        public override string ToString()
        {
            return $"Position: ({_position.GetX()}, {_position.GetY()}), Velocity({_velocity.GetX()}, {_velocity.GetY()})";
        }

    }

}