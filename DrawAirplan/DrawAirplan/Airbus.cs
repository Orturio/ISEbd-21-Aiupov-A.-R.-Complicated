using System.Drawing;

namespace DrawAirplan
{
    public class Airbus : Aircraft
    {
        public Color DopColor { private set; get; }

        IDop Portholes;

        public int PortholeCount { private set; get; }

        public string PortholeForm { private set; get; }

        public Airbus(int maxSpeed, float weight, Color mainColor, Color dopColor, int windowCount, string portholeForm) :
            base(maxSpeed, weight, mainColor, 220, 100, false)
        {
            DopColor = dopColor;
            PortholeForm = portholeForm;

            if (PortholeForm == "DrawPortholeCircle")
            {
                Portholes = new DrawPortholeCircle(windowCount);

            }
            else if (PortholeForm == "DrawPortholeRectangle")
            {
                Portholes = new DrawPortholeRectangle(windowCount);
            }
            else
            {
                Portholes = new DrawPortholeTriangle(windowCount);
            }
        }

        public void SetPortholes(IDop porthole)
        {
            Portholes = porthole;
            PortholeForm = Portholes.GetType().Name;
        }

        public void SetPortholesCount(int portholeCount)
        {
            PortholeCount = portholeCount;
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);

            base.DrawTransport(g);
                 
            g.FillEllipse(dopBrush, _startPosX + 45, _startPosY + 30, 10, 10);
            g.FillEllipse(dopBrush, _startPosX + 55, _startPosY + 30, 10, 10);
            g.FillEllipse(dopBrush, _startPosX + 155, _startPosY + 30, 10, 10);
            g.FillEllipse(dopBrush, _startPosX + 165, _startPosY + 30, 10, 10);
            g.FillEllipse(dopBrush, _startPosX + 175, _startPosY + 30, 10, 10);         
          
            Portholes.DrawElements(g, DopColor, _startPosX, _startPosY);          
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}
