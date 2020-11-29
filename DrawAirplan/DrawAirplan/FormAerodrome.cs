using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DrawAirplan
{
    public partial class FormAerodrome : Form
    {

        private readonly AerodromeCollection aerodromeCollection;

        public LinkedList<Vehicle> plains = new LinkedList<Vehicle>();     
    
        public FormAerodrome()
        {
            InitializeComponent();
            aerodromeCollection = new AerodromeCollection(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
            Draw();
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
                    aerodromeCollection.DelAerodrome(listBoxAerodromes.Text);
                    textBoxNewLevelName.Text = "";
                    ReloadLevels();
                }
            }
        }
             
        private void buttonTakeAircraft_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var aircraft = aerodromeCollection[listBoxAerodromes.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (aircraft != null)
                {
                    plains.AddFirst(aircraft);                  
                }
                Draw();
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
                if ((aerodromeCollection[listBoxAerodromes.SelectedItem.ToString()]) + aircraft)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Самолёт не удалось посадить");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (aerodromeCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (aerodromeCollection.LoadData(openFileDialog.FileName, true))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }              
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьОдинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (aerodromeCollection.SaveData(saveFileDialog.FileName, listBoxAerodromes.SelectedItem.ToString()))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьОдинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {                
                if (aerodromeCollection.LoadData(openFileDialog.FileName, false))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
MessageBoxIcon.Error);
                }
            }
        }
    }
}
