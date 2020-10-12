using System.Drawing;


namespace DrawAirplan
{
    public class DrawPorthole : IDop
    {
        private int ten = 10;      
        private int step = 7;
        private int maxStep = 17;       

        private Elements windowСount;

        private Elements windowForm;

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

        public int SetForm
        {
            set
            {
                if (value == 0)
                {
                    windowForm = Elements.Ellipse;
                }
                if (value == 1)
                {
                    windowForm = Elements.Rectangle;
                }
            }
        }

        public void DrawTenPortholes(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopColorBrush = new SolidBrush(dopColor);

            for (int i = 0; i < ten; i++)
            {
                if (windowForm == Elements.Ellipse)
                {
                    g.DrawEllipse(pen, _startPosX + step * ten, _startPosY - 4, 3, 3);
                    g.FillEllipse(dopColorBrush, _startPosX + step * ten, _startPosY - 4, 3, 3);
                }

                else if (windowForm == Elements.Rectangle)
                {
                    g.DrawRectangle(pen, _startPosX + step * ten, _startPosY - 4, 3, 3);
                    g.FillRectangle(dopColorBrush, _startPosX + step * ten, _startPosY - 4, 3, 3);
                }

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
                if (windowForm == Elements.Ellipse) 
                {
                    g.DrawEllipse(pen, _startPosX + step * ten, _startPosY + 5, 3, 3);
                    g.FillEllipse(dopColorBrush, _startPosX + step * ten, _startPosY + 5, 3, 3);
                }
                
                else if (windowForm == Elements.Rectangle)
                {
                    g.DrawRectangle(pen, _startPosX + step * ten, _startPosY + 5, 3, 3);
                    g.FillRectangle(dopColorBrush, _startPosX + step * ten, _startPosY + 5, 3, 3);
                }

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
                if (windowForm == Elements.Ellipse)
                {
                    g.DrawEllipse(pen, _startPosX + step * ten, _startPosY + 15, 3, 3);
                    g.FillEllipse(dopColorBrush, _startPosX + step * ten, _startPosY + 15, 3, 3);
                }

                else if (windowForm == Elements.Rectangle)
                {
                    g.DrawRectangle(pen, _startPosX + step * ten, _startPosY + 15, 3, 3);
                    g.FillEllipse(dopColorBrush, _startPosX + step * ten, _startPosY + 15, 3, 3);
                }
                step++;
            }

            step = 7;
        }

        public void DrawElements(Graphics g,Color dopColor ,float _startPosX, float _startPosY)
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
