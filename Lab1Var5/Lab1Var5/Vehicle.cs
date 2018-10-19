using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1Var5
{
    public abstract class Vehicle : ITransport
    {
        /// <summary>
        /// Левая координата отрисовки автомобиля
        /// </summary>
        protected float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки автомобиля
        /// </summary>
        protected float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;
        //Высота окна отрисовки
        protected int _pictureHeight;


        public int MaxSpeed { protected set; get; }
 

        public float Weight { protected set; get; }


        public Color MainColor { protected set; get; }

        public void SetMainColor(Color color)
        {
            MainColor = color;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public abstract void DrawShip(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}

