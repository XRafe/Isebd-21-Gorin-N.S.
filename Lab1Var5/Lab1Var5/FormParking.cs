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
        MultiLevelParking parking;

        FormShipConfig form;

        private const int countLevel = 5;

        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width,
           pictureBoxParking.Height);

            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }

        private void Draw()

        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
  pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var ship = parking[listBoxLevels.SelectedIndex] -
                   Convert.ToInt32(maskedTextBox.Text);
                    if (ship != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width,
                       pictureBoxTakeShip.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        ship.SetPosition(5, 5, pictureBoxTakeShip.Width,
                       pictureBoxTakeShip.Height);
                        ship.DrawShip(gr);
                        pictureBoxTakeShip.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width,
                       pictureBoxTakeShip.Height);
                        pictureBoxTakeShip.Image = bmp;
                    }
                    Draw();
                }
            }
        }

        private void buttonSetShip_Click_1(object sender, EventArgs e)
        {
            form = new FormShipConfig();
            form.AddEvent(AddShip);
            form.Show();
        }

        private void AddShip(ITransport ship)
        {
            if (ship != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = parking[listBoxLevels.SelectedIndex] + ship;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Корабль не удалось поставить");
                }
            }
        }

        private void listBoxLevels_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Draw();
        }

        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}