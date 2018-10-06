using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1Var5
{
    public enum Direction

    {
        Up,
        Down,
        Left,
        Right
    }



    /// <summary>
    /// Класс отрисовки корабля
    /// </summary>
    public class Ship : Vehicle
    {

    



        protected const int carWidth = 240;


        protected const int carHeight = 60;


        public Ship(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
 

        public override void DrawShip(Graphics g)
        {
            int yline = -5;

            Brush general = new SolidBrush(Color.Blue);
            Brush body = new SolidBrush(Color.Green);
            Brush tube = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Green);



            g.FillRectangle(body, _startPosX, _startPosY - 5, 90, 30);
            g.FillRectangle(general, _startPosX + 10, _startPosY - 20, 60, 15);
            g.FillRectangle(tube, _startPosX + 30, _startPosY - 40, 15, 20);
            while (yline < 25)
            {
                g.DrawLine(pen, _startPosX, _startPosY + yline, _startPosX - 30, _startPosY - 18);

                g.DrawLine(pen, _startPosX + 90, _startPosY + yline, _startPosX + 120, _startPosY - 18);
                yline++;
            }



        }
    }

}

