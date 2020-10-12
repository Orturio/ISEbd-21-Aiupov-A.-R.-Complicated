using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawAirplan
{
    public partial class FormAirplan : Form
    {
        private ITransport aircraft;

        public FormAirplan()
        {
            InitializeComponent();
            comboBoxWindowCount.Items.AddRange(new string[] { "10", "20", "30" });
            comboBoxDoorsCount.Items.AddRange(new string[] { "2", "4" });
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAircraft.Width, pictureBoxAircraft.Height);
            Graphics gr = Graphics.FromImage(bmp);
            aircraft.DrawTransport(gr);
            pictureBoxAircraft.Image = bmp;
        }

        private void buttonCreateAircraft_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();           
            aircraft = new Aircraft(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.LightBlue, true, true);
            aircraft.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAircraft.Width,
pictureBoxAircraft.Height);
            Draw();
        }

        private void buttonCreateAirbus_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int windowCount = Convert.ToInt32(comboBoxWindowCount.SelectedItem);
            int doorCount = Convert.ToInt32(comboBoxDoorsCount.SelectedItem);
            int doorForm = Convert.ToInt32(buttonDoorEllipseForm.Enabled ? buttonDoorEllipseForm.Text: (buttonDoorRectangleForm.Enabled ?
buttonDoorRectangleForm.Text: "0"));
            aircraft = new Airbus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.LightBlue,
Color.Black, true, windowCount, checkedListBoxForm.SelectedIndex, doorCount, doorForm);
            aircraft.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAircraft.Width,
pictureBoxAircraft.Height);
            Draw();

            buttonDoorEllipseForm.Enabled = true;
            buttonDoorRectangleForm.Enabled = true;
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    aircraft.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    aircraft.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    aircraft.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    aircraft.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonDoorForm_Click(object sender, EventArgs e)
        {
            if (sender == buttonDoorEllipseForm) 
            {
                buttonDoorRectangleForm.Enabled = false;
            }
            if (sender == buttonDoorRectangleForm)
            {
                buttonDoorEllipseForm.Enabled = false;
            }
        }        
    }
}
