using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Var5
{
    public partial class FormShip : Form
    {
        private Ship ship;


        public FormShip()
        {
            InitializeComponent();
        }


        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCars.Width, pictureBoxCars.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship.DrawCar(gr);
            pictureBoxCars.Image = bmp;
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Ship(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
           Color.Yellow, true, true, true);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCars.Width,
           pictureBoxCars.Height);
            Draw();
        }


        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    ship.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    ship.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    ship.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    ship.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void Button_Down_Click(object sender, EventArgs e)
        {

        }
    }
}

