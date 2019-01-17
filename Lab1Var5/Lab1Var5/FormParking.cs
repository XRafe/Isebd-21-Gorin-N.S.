using NLog;
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

        private Logger logger;

        public FormParking()
        {
            InitializeComponent();

            logger = LogManager.GetCurrentClassLogger();

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
                    try
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

                            logger.Info("Изъят корабль " + ship.ToString() + " с места " + maskedTextBox.Text);
                        }
                        Draw();
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);

                        Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width,
                       pictureBoxTakeShip.Height);

                        pictureBoxTakeShip.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                try
                {
                    int place = parking[listBoxLevels.SelectedIndex] + ship;
                    logger.Info("Добавлен корабль " + ship.ToString() + " на место " +
                    place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (ParkingAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                try
                {
                    parking.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            parking.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}
