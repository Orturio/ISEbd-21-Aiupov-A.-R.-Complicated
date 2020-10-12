using System.Drawing;

namespace DrawAirplan
{
    public class Airbus : Aircraft
    {
        public Color DopColor { private set; get; }

        public bool AirplanChassis { private set; get; }            

        IDop Portholes = new DrawPorthole();
        IDop Doors = new DrawDoors();
        
        public Airbus(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool airplanChassis, int windowCount, int windowForm, int doorCount, int doorForm) :
            base(maxSpeed, weight, mainColor, 220, 100, false, false)
        {
            DopColor = dopColor;
            AirplanChassis = airplanChassis;
            Portholes.SetCount = windowCount;
            Portholes.SetForm = windowForm;
            Doors.SetCount = doorCount;
            Doors.SetForm = doorForm;
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);

            base.DrawTransport(g);

            if (AirplanChassis)
            {
                g.FillEllipse(dopBrush, _startPosX + 45, _startPosY + 30, 10, 10);
                g.FillEllipse(dopBrush, _startPosX + 55, _startPosY + 30, 10, 10);
                g.FillEllipse(dopBrush, _startPosX + 155, _startPosY + 30, 10, 10);
                g.FillEllipse(dopBrush, _startPosX + 165, _startPosY + 30, 10, 10);
                g.FillEllipse(dopBrush, _startPosX + 175, _startPosY + 30, 10, 10);
            }
           
            Portholes.DrawElements(g, DopColor, _startPosX, _startPosY);
            Doors.DrawElements(g, DopColor, _startPosX, _startPosY);
        }
    }
}
