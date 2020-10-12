using System.Drawing;

namespace DrawAirplan
{
    class DrawDoors : IDop
    {
        private Elements doorCount;

        private Elements doorForm;

        public int SetCount
        {
            set
            {
                if(value == 2)
                {
                    doorCount = Elements.two;
                }
                if(value == 4)
                {
                    doorCount = Elements.four;
                }
            }
        }
        
        public int SetForm
        {
            set
            {
                if(value == 0)
                {
                    doorForm = Elements.Ellipse;
                }
                if(value == 1)
                {
                    doorForm = Elements.Rectangle;
                }
            }
        }

        public void DrawElements(Graphics g, Color dopColor, float _startPosX, float _startPosY) 
        {
            Pen pen = new Pen(Color.Black);
            Brush dopColorBrush = new SolidBrush(dopColor);
            if (doorCount >= Elements.two) 
            {
                if (doorForm == Elements.Rectangle)
                {                    
                    g.DrawRectangle(pen, _startPosX + 35, _startPosY + 13, 8, 13);
                    g.DrawRectangle(pen, _startPosX + 180, _startPosY + 13, 8, 13);                    
                }

                else if (doorForm == Elements.Ellipse) 
                {
                    g.DrawEllipse(pen, _startPosX + 35, _startPosY + 13, 8, 13);
                    g.DrawEllipse(pen, _startPosX + 180, _startPosY + 13, 8, 13);
                }

                if (doorCount == Elements.four)
                {
                    if (doorForm == Elements.Rectangle)
                    {
                        g.DrawRectangle(pen, _startPosX + 50, _startPosY - 6, 8, 13);
                        g.DrawRectangle(pen, _startPosX + 175, _startPosY - 6, 8, 13);                        
                    }

                    else if (doorForm == Elements.Ellipse) 
                    {
                        g.DrawEllipse(pen, _startPosX + 50, _startPosY - 6, 8, 13);
                        g.DrawEllipse(pen, _startPosX + 175, _startPosY - 6, 8, 13);                        
                    }
                }
            }
        }
    }
}
