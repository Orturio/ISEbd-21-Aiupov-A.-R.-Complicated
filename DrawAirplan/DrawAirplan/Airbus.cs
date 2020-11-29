using System.Drawing;
using System;

namespace DrawAirplan
{
    public class Airbus : Aircraft
    {
        public Color DopColor { private set; get; }

        IDop Portholes;

        public int PortholeCount { private set; get; }

        public string PortholeForm { private set; get; }

        public Airbus(int maxSpeed, float weight, Color mainColor, Color dopColor, int PortholeCount, string portholeForm) :
            base(maxSpeed, weight, mainColor, 220, 100)
        {
            DopColor = dopColor;
            PortholeForm = portholeForm;

            if (PortholeForm == "DrawPortholeCircle")
            {
                Portholes = new DrawPortholeCircle(PortholeCount);

            }
            else if (PortholeForm == "DrawPortholeRectangle")
            {
                Portholes = new DrawPortholeRectangle(PortholeCount);
            }
            else
            {
                Portholes = new DrawPortholeTriangle(PortholeCount);
            }
        }

        public Airbus(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                PortholeCount = Convert.ToInt32(strs[4]);
                PortholeForm = strs[5];
                if (PortholeForm == "DrawPortholeCircle")
                {
                    Portholes = new DrawPortholeCircle(PortholeCount);

                }
                else if (PortholeForm == "DrawPortholeRectangle")
                {
                    Portholes = new DrawPortholeRectangle(PortholeCount);
                }
                else
                {
                    Portholes = new DrawPortholeTriangle(PortholeCount);
                }
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
          
            if (Portholes != null) 
            {
                Portholes.DrawElements(g, DopColor, _startPosX, _startPosY);
            }                     
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{PortholeCount}{separator}{PortholeForm}";
        }
    }
}
