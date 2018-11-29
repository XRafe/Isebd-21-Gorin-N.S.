using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Lab1Var5
{
    public class WaterCar : Ship
    {
        

        public Color DopColor { private set; get; }

        public bool Wheel { private set; get; }

        public bool Decoreation { private set; get; }


        public bool Whistle { private set; get; }



        public WaterCar(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
       wheel, bool decoreation, bool whistle) :
            base(maxSpeed, weight, mainColor)
        {
            MainColor = mainColor;
            DopColor = dopColor;
            Wheel = wheel;
            Decoreation = decoreation;
            Whistle = whistle;
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
    }
}

