using System;
using System.Collections.Generic;
using System.Drawing;


namespace DrawAirplan
{
    class DrawPorthole
    {
        int ten = 10;
        int twenty = 20;
        int thirty = 30;
        int step = 7;
        int maxStep = 17;       

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

        public void DrawPortholes(Graphics g,Color dopColor ,float _startPosX, float _startPosY)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopColorBrush = new SolidBrush(dopColor);

            if (windowСount == Porthole.ten) 
            {                              
                for (int i = 0; i < ten; i++)
                {
                    g.DrawEllipse(pen, _startPosX + step * ten, _startPosY - 4, 3, 3);
                    g.FillEllipse(dopColorBrush, _startPosX + step * ten, _startPosY - 4, 3, 3);
                    step++;
                }

                step = 7;
            }

            if (windowСount == Porthole.twenty)
            {                
                for (int i = 0; i < twenty; i++)
                {
                    if (i < 10)
                    {
                        g.DrawEllipse(pen, _startPosX + step * ten, _startPosY - 4, 3, 3);
                        g.FillEllipse(dopColorBrush, _startPosX + step * ten, _startPosY - 4, 3, 3);
                        step++;
                        if (step == maxStep)
                        {
                            step = 7;
                        }
                    }

                    else 
                    {
                        g.DrawEllipse(pen, _startPosX + step * ten, _startPosY + 5, 3, 3);
                        g.FillEllipse(dopColorBrush, _startPosX + step * ten, _startPosY + 5, 3, 3);
                        step++;
                    }                   
                }

                step = 7;
            }

            if (windowСount == Porthole.thirty) 
            {
                for (int i = 0; i < thirty; i++)
                {
                    if (i < 10)
                    {
                        g.DrawEllipse(pen, _startPosX + step * ten, _startPosY - 4, 3, 3);
                        g.FillEllipse(dopColorBrush, _startPosX + step * ten, _startPosY - 4, 3, 3);
                        step++;
                        if (step == maxStep)
                        {
                            step = 7;
                        }
                    }

                    else if (i < 20)
                    {
                        g.DrawEllipse(pen, _startPosX + step * ten, _startPosY + 5, 3, 3);
                        g.FillEllipse(dopColorBrush, _startPosX + step * ten, _startPosY + 5, 3, 3);
                        step++;
                        if (step == maxStep)
                        {
                            step = 12;
                        }
                    }

                    else if (i < 25)
                    {
                        g.DrawEllipse(pen, _startPosX + step * ten, _startPosY + 15, 3, 3);
                        g.FillEllipse(dopColorBrush, _startPosX + step * ten, _startPosY + 15, 3, 3);
                        step++;                      
                    }
                }

                step = 7;
            }
        }
        
    }
}
