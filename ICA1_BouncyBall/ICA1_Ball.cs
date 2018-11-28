using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA1_BouncyBall
{
    class CBall
    {
        private Point _pos;             // Position of the ball
        private Point _direction;       // Direction the ball with move from the Move() method
        private Color _color;           // Color of the ball
        private int _size;              // Size of the ball

        // Basic constructor for the class
        public CBall(Color bColor)
        {
            // Preset properties
            _size = 50;
            _direction.X = 100;
            _direction.Y = 20;
            _pos.X = 400;
            _pos.Y = 300;

            // Gets color from the construction line
            _color = bColor;
        }

        // Optional constructor that includes basic constructor (i.e. leveraged the color constructor)
        public CBall(Color bColor, Point bDir)
            :this(bColor)
        {
            _direction = bDir;
        }

        // Method for adjusting the ball's position
        public void Move()
        {
            _pos.X += _direction.X;
            _pos.Y += _direction.Y;

            if (_pos.X < 0 || _pos.X > 799)
            {
                _direction.X *= -1;
                _pos.X += _direction.X;
                _size -= 2;
            }

            if (_pos.Y < 0 || _pos.Y > 599)
            {
                _direction.Y *= -1;
                _pos.Y += _direction.Y;
                _size -= 2;
            }
        }

        public void Render(CDrawer canvas)
        {
            if (_size >= 2)
            {
                canvas.AddCenteredEllipse(_pos.X, _pos.Y, _size, _size, _color, 2, Color.Black);
            }
        }
    }
}
