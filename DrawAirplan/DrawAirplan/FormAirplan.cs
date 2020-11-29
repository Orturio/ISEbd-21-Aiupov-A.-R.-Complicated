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
        }

        public void SetAircraft(ITransport aircraft)
        {
            this.aircraft = aircraft;
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAircraft.Width, pictureBoxAircraft.Height);
            Graphics gr = Graphics.FromImage(bmp);
            aircraft.DrawTransport(gr);
            pictureBoxAircraft.Image = bmp;
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
    }
}
