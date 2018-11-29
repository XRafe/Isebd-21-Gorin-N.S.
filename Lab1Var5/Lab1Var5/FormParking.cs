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
    public partial class FormParking : Form
    {

        Parking<ITransport> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(20, pictureBox1.Width,
           pictureBox1.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBox1.Image = bmp;
        }
  

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Ship(100, 1000, dialog.Color);
                int place = parking + ship;
                Draw();
            }
        }


        private void button3_Click_1(object sender, EventArgs e)
        {



            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var ship = new WaterCar(100, 1000, dialog.Color, dialogDop.Color,
                   true, true, true);
                    int place = parking + ship;
                    Draw();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var Ship = parking - Convert.ToInt32(maskedTextBox1.Text);
                if (Ship != null)
                {
                    Bitmap bmp = new Bitmap(pictureBox2.Width,
                   pictureBox2.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    Ship.SetPosition(5, 5, pictureBox2.Width,
                   pictureBox2.Height);
                    Ship.DrawShip(gr);
                    pictureBox2.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBox2.Width,
                   pictureBox2.Height);
                    pictureBox2.Image = bmp;
                }
                Draw();
            }

        }

    }
}
