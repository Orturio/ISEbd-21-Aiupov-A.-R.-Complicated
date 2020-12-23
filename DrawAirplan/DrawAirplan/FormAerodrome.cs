using System;
using System.Drawing;
using NLog;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace DrawAirplan
{
    public partial class FormAerodrome : Form
    {

        private readonly AerodromeCollection aerodromeCollection;

        private readonly Logger logger;

        public LinkedList<Vehicle> plains = new LinkedList<Vehicle>();     
    
        public FormAerodrome()
        {
            InitializeComponent();
            aerodromeCollection = new AerodromeCollection(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
            Draw();
            logger = LogManager.GetCurrentClassLogger();
        }

        private void ReloadLevels()
        {
            int index = listBoxAerodromes.SelectedIndex;
            listBoxAerodromes.Items.Clear();
            for (int i = 0; i < aerodromeCollection.Keys.Count; i++)
            {
                listBoxAerodromes.Items.Add(aerodromeCollection.Keys[i]);
            }
            if (listBoxAerodromes.Items.Count > 0 && (index == -1 || index >=
listBoxAerodromes.Items.Count))
            {
                listBoxAerodromes.SelectedIndex = 0;
            }
            else if (listBoxAerodromes.Items.Count > 0 && index > -1 && index <
listBoxAerodromes.Items.Count)
            {
                listBoxAerodromes.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxAerodromes.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
                Graphics gr = Graphics.FromImage(bmp);
                aerodromeCollection[listBoxAerodromes.SelectedItem.ToString()].Draw(gr);
                pictureBoxAerodrome.Image = bmp;
            }
        }

        private void buttonAddAerodrome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название аэродрома", "Ошибка",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили аэродром {textBoxNewLevelName.Text}");
            aerodromeCollection.AddAerodrome(textBoxNewLevelName.Text);
            textBoxNewLevelName.Text = "";
            ReloadLevels();
        }

        private void buttonDeleteAerodrome_Click(object sender, EventArgs e)
        {
            if (listBoxAerodromes.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить аэродром {listBoxAerodromes.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили аэродром{ listBoxAerodromes.SelectedItem.ToString()}");
                    aerodromeCollection.DelAerodrome(listBoxAerodromes.Text);
                    textBoxNewLevelName.Text = "";
                    ReloadLevels();
                }
            }
        }
             
        private void buttonTakeAircraft_Click(object sender, EventArgs e)
        {
            if (listBoxAerodromes.SelectedIndex > -1 && maskedTextBox.Text != "")
            {               
                try
                {
                    var aircraft = aerodromeCollection[listBoxAerodromes.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (aircraft != null)
                    {
                        FormAirplan form = new FormAirplan();
                        form.SetAircraft(aircraft);
                        form.ShowDialog();
                        logger.Info($"Изъят самолёт {aircraft} с места{ maskedTextBox.Text}");
                        Draw();
                    }
                }
                catch (AerodromeNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Не найдено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка");
                }
            }
        }
  
        private void buttonPlainsCheck_Click(object sender, EventArgs e)
        {
            if (plains.Count > 0)
            {
                FormAirplan form = new FormAirplan();
                form.SetAircraft(plains.First.Value);
                plains.RemoveFirst();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Самолётов не осталось");
            }
        }

        private void listBoxAerodrome_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на аэродром { listBoxAerodromes.SelectedItem.ToString()}");
            Draw();
        }

        private void buttonSetAircraft_Click(object sender, EventArgs e)
        {
            var formAircraftConfig = new FormAircraftConfig();
            formAircraftConfig.AddEvent(AddAircraft);
            formAircraftConfig.Show();
        }

        private void AddAircraft(Vehicle aircraft)
        {
            if (aircraft != null && listBoxAerodromes.SelectedIndex > -1)
            {
                try
                {
                    if ((aerodromeCollection[listBoxAerodromes.SelectedItem.ToString()]) + aircraft)
                    {
                        Draw();
                        logger.Info($"Добавлен самолёт {aircraft}");
                    }
                    else
                    {
                        MessageBox.Show("Самолёт не удалось посадить");
                    }
                    Draw();
                }
                catch (AerodromeOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Переполнение");
                }
                catch (AerodromeAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Дублирование");
                }
                catch (Exception ex)
                {                    
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    aerodromeCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }                              
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка при сохранении");
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    aerodromeCollection.LoadData(openFileDialog.FileName, true);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Error("Файл не найден");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Неверный формат файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неверный формат файла");
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message, "Значение = null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Значение = null");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка при загрузки");
                }
            }
        }

        private void сохранитьОдинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    aerodromeCollection.SaveOneLevel(saveFileDialog.FileName, listBoxAerodromes.SelectedItem.ToString());
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Неверный формат файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неверный формат файла");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка при сохранении");
                }
            }
        }
        

        private void загрузитьОдинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    aerodromeCollection.LoadOneLevel(openFileDialog.FileName, false);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Error("Файл не найден");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Неверный формат файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неверный формат файла");
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message, "Значение = null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Значение = null");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка при загрузки");
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxAerodromes.SelectedIndex > -1)
            {
                aerodromeCollection[listBoxAerodromes.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}
