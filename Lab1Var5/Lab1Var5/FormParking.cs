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
            parking = new Parking<ITransport>(20, pictureBoxGeneral.Width,
           pictureBoxGeneral.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxGeneral.Width, pictureBoxGeneral.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxGeneral.Image = bmp;
        }
  

        private void buttonToPut_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Ship(100, 1000, dialog.Color);
                int place = parking + ship;
                Draw();
            }
        }


        private void buttonToPutTun_Click(object sender, EventArgs e)
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

        private void buttonPickUp_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var Ship = parking - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (Ship != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxDop.Width,
                   pictureBoxDop.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    Ship.SetPosition(5, 5, pictureBoxDop.Width,
                   pictureBoxDop.Height);
                    Ship.DrawShip(gr);
                    pictureBoxDop.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxDop.Width,
                   pictureBoxDop.Height);
                    pictureBoxDop.Image = bmp;
                }
                Draw();
            }

        }

    }
}
