using System;
using System.Collections.Generic;
using System.Drawing;


namespace DrawAirplan
{
    class DrawPorthole
    {
        private int ten = 10;      
        private int step = 7;
        private int maxStep = 17;       

        private Porthole windowСount;

        public int WindowСount 
        {
            set
            {
                if (value == 10)
                {
                    windowСount = Porthole.ten;
                }
                if (value == 20)
                {
                    windowСount = Porthole.twenty;
                }
                if (value == 30)
                {
                    windowСount = Porthole.thirty;
                }
            }
        }

        public void DrawTenPortholes(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopColorBrush = new SolidBrush(dopColor);

            for (int i = 0; i < ten; i++)
            {
                g.DrawEllipse(pen, _startPosX + step * ten, _startPosY - 4, 3, 3);
                g.FillEllipse(dopColorBrush, _startPosX + step * ten, _startPosY - 4, 3, 3);
                step++;
                if (step == maxStep)
                {
                    step = 7;
                }
            }

            step = 7;
        }

        public void DrawTwentyPortholes(Graphics g, Color dopColor, float _startPosX, float _startPosY) 
        {
            Pen pen = new Pen(Color.Black);
            Brush dopColorBrush = new SolidBrush(dopColor);

            for (int i = 0; i < ten; i++)
            {
                g.DrawEllipse(pen, _startPosX + step * ten, _startPosY + 5, 3, 3);
                g.FillEllipse(dopColorBrush, _startPosX + step * ten, _startPosY + 5, 3, 3);
                step++;
                if (step == maxStep)
                {
                    step = 7;
                }
            }

            step = 7;
        }

        public void DrawThirtyPortholes(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopColorBrush = new SolidBrush(dopColor);
            step = 12;

            for (int i = 0; i <= 5; i++) 
            {
                g.DrawEllipse(pen, _startPosX + step * ten, _startPosY + 15, 3, 3);
                g.FillEllipse(dopColorBrush, _startPosX + step * ten, _startPosY + 15, 3, 3);
                step++;
            }

            step = 7;
        }

        public void DrawPortholes(Graphics g,Color dopColor ,float _startPosX, float _startPosY)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopColorBrush = new SolidBrush(dopColor);

            if (windowСount >= Porthole.ten) 
            {
                DrawTenPortholes(g, dopColor, _startPosX, _startPosY);
                if (windowСount >= Porthole.twenty)
                {
                    DrawTwentyPortholes(g, dopColor, _startPosX, _startPosY);
                    if (windowСount == Porthole.thirty) 
                    {
                        DrawThirtyPortholes(g, dopColor, _startPosX, _startPosY);
                    }
                }
            }          
        }  
    }
}
