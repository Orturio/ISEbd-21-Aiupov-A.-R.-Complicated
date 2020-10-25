using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawAirplan
{
    public partial class FormAerodrome : Form
    {

        private readonly Aerodrome<Aircraft, DrawPortholeCircle> aerodrome;
        private Aircraft aircraft;

        public FormAerodrome()
        {
            InitializeComponent();
            aerodrome = new Aerodrome<Aircraft, DrawPortholeCircle>(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAerodrome.Width, pictureBoxAerodrome.Height);
            Graphics gr = Graphics.FromImage(bmp);
            aerodrome.Draw(gr);
            pictureBoxAerodrome.Image = bmp;
        }

        private void buttonLandAircraft_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                aircraft = new Aircraft(100, 1000, dialog.Color, true);
                if (aerodrome + aircraft)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Мест нет");
                }
            }
        }

        private void buttonLandAirbus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    aircraft = new Airbus(100, 1000, dialog.Color, dialogDop.Color, 20, 1);
                    if (aerodrome + aircraft)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Мест нет");
                    }
                }
            }
        }

        private void buttonTakeAircraft_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                aircraft = aerodrome - Convert.ToInt32(maskedTextBox.Text);
                if (aircraft != null)
                {
                    FormAirplan form = new FormAirplan();
                    form.SetAircraft(aircraft);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void buttonCompareForSimilarAicrafts_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxCompareForSimilarity.Text != "")           
            {
                int index = Convert.ToInt32(maskedTextBoxCompareForSimilarity.Text);
                if (aerodrome == index)
                {
                    MessageBox.Show("Есть самолёт такого же типа как и выбранный");
                }
                else 
                {
                    MessageBox.Show("Самолёт такой один");
                }
            }
        }

        private void buttonUniqChecking_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxCompareForSimilarity.Text != "")
            {
                int index = Convert.ToInt32(maskedTextBoxCompareForSimilarity.Text);
                if (aerodrome != index)
                {
                    MessageBox.Show("Самолёт уникален");
                }
                else 
                {
                    MessageBox.Show("Этот самолёт не уникален");
                }
            }
        }
    }
}
