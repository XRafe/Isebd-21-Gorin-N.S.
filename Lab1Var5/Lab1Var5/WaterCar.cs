using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Lab1Var5
{
    public class WaterCar : Ship, IComparable<WaterCar>, IEquatable<WaterCar>
    {
        public Color DopColor { private set; get; }

        public bool Wheel { private set; get; }

        public bool Decoreation { private set; get; }

        public bool Whistle { private set; get; }

        public WaterCar(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
       wheel, bool decoreation, bool whistle) :
            base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Wheel = wheel;
            Decoreation = decoreation;
            Whistle = whistle;
        }

        public WaterCar(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Wheel = Convert.ToBoolean(strs[4]);
                Decoreation = Convert.ToBoolean(strs[5]);
                Whistle = Convert.ToBoolean(strs[6]);
            }
        }

        public override void DrawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Pen pen2 = new Pen(Color.LightGoldenrodYellow);

            int xline = 0;
            int yline = 0;

            base.DrawShip(g);
            Brush reactive = new SolidBrush(Color.Black);
            Brush Wh = new SolidBrush(DopColor);

            if (Decoreation)
            {
                while (xline < 65)
                {
                    g.DrawLine(pen2, _startPosX + 20 + xline, _startPosY + 20, _startPosX + xline, _startPosY + 55);
                    xline += 5;
                }
            }

            if (Whistle)
            {
                while (yline < 35)
                {
                    g.DrawLine(pen, _startPosX + 70, _startPosY + 30, _startPosX + 100, _startPosY + 10 + yline);
                    yline += 1;
                }
            }

            if (Wheel)
            {
                g.FillEllipse(Wh, _startPosX + 10, _startPosY + 35, 40, 40);
            }
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Wheel + ";" +
           Decoreation + ";" + Whistle;
        }

        /// <summary>
        /// Метод интерфейса IComparable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(WaterCar other)
        {
            var res = (this is Ship).CompareTo(other is Ship);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Wheel != other.Wheel)
            {
                return Wheel.CompareTo(other.Wheel);
            }
            if (Decoreation != other.Decoreation)
            {
                return Decoreation.CompareTo(other.Decoreation);
            }
            if (Whistle != other.Whistle)
            {
                return Whistle.CompareTo(other.Whistle);
            }
            return 0;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(WaterCar other)
        {
            var res = (this as Ship).Equals(other as Ship);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Wheel != other.Wheel)
            {
                return false;
            }
            if (Decoreation != other.Decoreation)
            {
                return false;
            }
            if (Whistle != other.Whistle)
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            WaterCar shipObj = obj as WaterCar;
            if (shipObj == null)
            {
                return false;
            }
            else
            {
                return Equals(shipObj);
            }
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

