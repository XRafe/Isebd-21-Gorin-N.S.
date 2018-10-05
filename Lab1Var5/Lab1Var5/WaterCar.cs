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
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>
        public bool FrontSpoiler { private set; get; }
        /// <summary>
        /// Признак наличия боковых спойлеров
        /// </summary>
        public bool SideSpoiler { private set; get; }
        /// <summary>
        /// Признак наличия заднего спойлера
        /// </summary>
        public bool BackSpoiler { private set; get; }

        public WaterCar(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
       frontSpoiler, bool sideSpoiler, bool backSpoiler) :
            base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            FrontSpoiler = frontSpoiler;
            SideSpoiler = sideSpoiler;
            BackSpoiler = backSpoiler;
        }
        public override void DrawCar(Graphics g)
        {
            int xline = 0;
            Pen pen = new Pen(Color.Black);
            Pen pen2 = new Pen(Color.LightGoldenrodYellow);


            base.DrawCar(g);
            Brush reactive = new SolidBrush(Color.Black);
            Brush gun1 = new SolidBrush(Color.DarkRed);

            g.FillRectangle(reactive, _startPosX + 32, _startPosY - 36, 60, 10);
            g.FillEllipse(gun1, _startPosX + 30, _startPosY - 40, 22, 22);

            while (xline < 65)
            {

                g.DrawLine(pen2, _startPosX + 10 + xline, _startPosY - 20, _startPosX + xline, _startPosY + 25);
                xline += 5;
            }

            g.FillRectangle(reactive, _startPosX - 30, _startPosY - 6, 60, 15);
        }

    }
}

