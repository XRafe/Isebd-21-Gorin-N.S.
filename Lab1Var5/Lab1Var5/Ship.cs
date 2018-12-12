using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Var5
{
    public class Ship
    {
        private float _startPosX;
        
        private float _startPosY;
        
        private int _pictureWidth;
        
        private int _pictureHeight;
        
        private const int shipWidth = 240;
        
        private const int shipHeight = 60;
        
        public int MaxSpeed { private set; get; }
        
        public float Weight { private set; get; }
        
        public Color MainColor { private set; get; }
        
        public Color DopColor { private set; get; }
        
        public bool General { private set; get; }
        
        public bool Tube { private set; get; }
        
        public Ship(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
       general, bool tube)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            General = general;
            Tube = tube;
        }
        
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - shipWidth)
                    {
                        _startPosX += step;
                    }
                    break;

                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;

                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;

                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - shipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawShip(Graphics g)
        {
            int yline = -5;

            Brush general = new SolidBrush(MainColor);
            Brush body = new SolidBrush(Color.Green);
            Brush tube = new SolidBrush(DopColor);
            Pen pen = new Pen(Color.Green);
            
            g.FillRectangle(body, _startPosX + 80, _startPosY - 6, 120, 40);
            if (General)
            {
                g.FillRectangle(general, _startPosX + 90, _startPosY - 26, 90, 20);
            }

            if (Tube)
            {
                g.FillRectangle(tube, _startPosX + 110, _startPosY - 56, 30, 30);
            }

            g.DrawLine(pen, _startPosX + 80, _startPosY + 30, _startPosX + 30, _startPosY - 30);
            while (yline < 35)
            {
                g.DrawLine(pen, _startPosX + 80, _startPosY + yline, _startPosX + 30, _startPosY - 30);

                g.DrawLine(pen, _startPosX + 200, _startPosY + yline, _startPosX + 250, _startPosY - 30);
                yline++;
            }

            g.DrawLine(pen, _startPosX + 200, _startPosY + 30, _startPosX + 250, _startPosY - 30);
        }
    }
}