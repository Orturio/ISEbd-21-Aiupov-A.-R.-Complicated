using System.Drawing;

namespace DrawAirplan
{
    public class Airbus : Aircraft
    {
        public Color DopColor { private set; get; }

        public int WindowForm { private set; get; }

        IDop Portholes;

        public Airbus(int maxSpeed, float weight, Color mainColor, Color dopColor, int windowCount, int windowForm) :
            base(maxSpeed, weight, mainColor, 220, 100, false)
        {
            DopColor = dopColor;      
            WindowForm = windowForm;

            if (WindowForm == 0)
            {
                Portholes = new DrawPortholeCircle(windowCount);
                
            }
            else if (WindowForm == 1)
            {
                Portholes = new DrawPortholeRectangle(windowCount);
            }
            else 
            {
                Portholes = new DrawPortholeTriangle(windowCount);                
            }
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
    }
}
