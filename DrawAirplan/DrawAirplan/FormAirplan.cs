using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawAirplan
{
    public partial class FormAirplan : Form
    {
        private Airbus airplan;

        public FormAirplan()
        {
            InitializeComponent();
            comboBoxWindowCount.Items.AddRange(new string[] { "10", "20", "30" });
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAirplans.Width, pictureBoxAirplans.Height);
            Graphics gr = Graphics.FromImage(bmp);
            airplan.DrawTransport(gr);
            pictureBoxAirplans.Image = bmp;
        }    

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int windowCount = Convert.ToInt32(comboBoxWindowCount.SelectedItem);
            airplan = new Airbus(rnd.Next(250, 450), rnd.Next(1000, 2000), Color.White,
            Color.Blue, true, windowCount);
            airplan.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAirplans.Width,
            pictureBoxAirplans.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    airplan.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    airplan.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    airplan.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    airplan.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

    }
}
