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
            base (maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            FrontSpoiler = frontSpoiler;
            SideSpoiler = sideSpoiler;
            BackSpoiler = backSpoiler;
        }
        public override void DrawCar(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
           
 if (FrontSpoiler)
            {
                g.DrawEllipse(pen, _startPosX + 80, _startPosY - 6, 20, 20);
                g.DrawEllipse(pen, _startPosX + 80, _startPosY + 35, 20, 20);
                g.DrawEllipse(pen, _startPosX - 5, _startPosY - 6, 20, 20);
                g.DrawEllipse(pen, _startPosX - 5, _startPosY + 35, 20, 20);
                g.DrawRectangle(pen, _startPosX + 80, _startPosY - 6, 15, 15);
                g.DrawRectangle(pen, _startPosX + 80, _startPosY + 40, 15, 15);
                g.DrawRectangle(pen, _startPosX, _startPosY - 6, 14, 15);
                g.DrawRectangle(pen, _startPosX, _startPosY + 40, 14, 15);
                Brush spoiler = new SolidBrush(DopColor);
                g.FillEllipse(spoiler, _startPosX + 80, _startPosY - 5, 20, 20);
                g.FillEllipse(spoiler, _startPosX + 80, _startPosY + 35, 20, 20);
                g.FillRectangle(spoiler, _startPosX + 75, _startPosY, 25, 40);
                g.FillRectangle(spoiler, _startPosX + 80, _startPosY - 5, 15, 15);
                g.FillRectangle(spoiler, _startPosX + 80, _startPosY + 40, 15, 15);
                g.FillEllipse(spoiler, _startPosX - 5, _startPosY - 5, 20, 20);
                g.FillEllipse(spoiler, _startPosX - 5, _startPosY + 35, 20, 20);
                g.FillRectangle(spoiler, _startPosX - 5, _startPosY, 25, 40);
                g.FillRectangle(spoiler, _startPosX, _startPosY - 5, 15, 15);
                g.FillRectangle(spoiler, _startPosX, _startPosY + 40, 15, 15);
            }
            // и боковые
            if (SideSpoiler)
            {
                g.DrawRectangle(pen, _startPosX + 25, _startPosY - 6, 39, 10);
                g.DrawRectangle(pen, _startPosX + 25, _startPosY + 45, 39, 10);
                Brush spoiler = new SolidBrush(DopColor);
                g.FillRectangle(spoiler, _startPosX + 25, _startPosY - 5, 40, 10);
                g.FillRectangle(spoiler, _startPosX + 25, _startPosY + 45, 40, 10);
            }
            // теперь отрисуем основной кузов автомобиля
            base.DrawCar(g);
            // рисуем гоночные полоски
            SolidBrush br = new SolidBrush(DopColor);
            g.FillRectangle(br, _startPosX + 65, _startPosY + 15, 25, 5);
            g.FillRectangle(br, _startPosX + 65, _startPosY + 30, 25, 5);
            g.FillRectangle(br, _startPosX + 25, _startPosY + 15, 35, 5);
            g.FillRectangle(br, _startPosX + 25, _startPosY + 30, 35, 5);
            g.FillRectangle(br, _startPosX, _startPosY + 15, 20, 5);
            g.FillRectangle(br, _startPosX, _startPosY + 30, 20, 5);
            // рисуем задний спойлер автомобиля
            if (BackSpoiler)
            {
                Brush spoiler = new SolidBrush(DopColor);
                g.FillRectangle(spoiler, _startPosX - 5, _startPosY, 10, 50);
                g.DrawRectangle(pen, _startPosX - 5, _startPosY, 10, 50);
            }
        }
    }

}

