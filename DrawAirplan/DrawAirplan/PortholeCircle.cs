using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawAirplan
{
    class PortholeCircle : IDop
    {
        private int ten = 10;
        private int step = 7;
        private int maxStep = 17;

        private Elements windowСount;

        public PortholeCircle(int windowCount) {
            SetCount = windowCount;
        }

        public int SetCount
        {
            set
            {
                if (value == 10)
                {
                    windowСount = Elements.ten;
                }
                if (value == 20)
                {
                    windowСount = Elements.twenty;
                }
                if (value == 30)
                {
                    windowСount = Elements.thirty;
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

        public void DrawElements(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopColorBrush = new SolidBrush(dopColor);

            if (windowСount >= Elements.ten)
            {
                DrawTenPortholes(g, dopColor, _startPosX, _startPosY);
                if (windowСount >= Elements.twenty)
                {
                    DrawTwentyPortholes(g, dopColor, _startPosX, _startPosY);
                    if (windowСount == Elements.thirty)
                    {
                        DrawThirtyPortholes(g, dopColor, _startPosX, _startPosY);
                    }
                }
            }
        }
    }
}
