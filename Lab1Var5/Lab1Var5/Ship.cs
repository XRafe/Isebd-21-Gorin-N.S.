using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1Var5
{
    public class Ship : Vehicle, IComparable<Ship>, IEquatable<Ship>
    {
        protected const int ShipWidth = 240;

        protected const int ShipHeight = 60;

        public Ship(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public Ship(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - ShipWidth)
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
                    if (_startPosY + step < _pictureHeight - ShipHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawShip(Graphics g)
        {
            int yline = -5;

            Brush general = new SolidBrush(MainColor);
            Brush body = new SolidBrush(Color.Green);
            Brush tube = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Green);

            g.FillRectangle(body, _startPosX + 10, _startPosY + 35, 90, 30);
            g.FillRectangle(general, _startPosX + 20, _startPosY + 20, 60, 15);
            g.FillRectangle(tube, _startPosX + 40, _startPosY, 15, 20);
            while (yline < 25)
            {
                g.DrawLine(pen, _startPosX + 10, _startPosY + 40 + yline, _startPosX - 5, _startPosY + 12);

                g.DrawLine(pen, _startPosX + 100, _startPosY + 40 + yline, _startPosX + 115, _startPosY + 12);
                yline++;
            }
        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

        public int CompareTo(Ship other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        public bool Equals(Ship other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Ship shipObj = obj as Ship;
            if (shipObj == null)
            {
                return false;
            }
            else
            {
                return Equals(shipObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}