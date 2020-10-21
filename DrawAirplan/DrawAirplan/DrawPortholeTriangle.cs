using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawAirplan
{
    class DrawPortholeTriangle : IDop
    {
        private int ten = 10;
        private int step = 7;
        private int maxStep = 17;

        private Elements windowСount;

        public DrawPortholeTriangle(int windowCount)
        {
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

        private void DrawTenPortholes(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopColorBrush = new SolidBrush(dopColor);

            for (int i = 0; i < ten; i++)
            {

                PointF s1 = new PointF(_startPosX + 10 * step - 3, _startPosY);
                PointF s2 = new PointF(_startPosX + 10 * step, _startPosY - 5);
                PointF s3 = new PointF(_startPosX + 10 * step + 3, _startPosY);
                PointF[] points = { s1, s2, s3 };
                g.FillPolygon(dopColorBrush, points);

                step++;

                if (step == maxStep)
                {
                    step = 7;
                }
            }

            step = 7;
        }

        private void DrawTwentyPortholes(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopColorBrush = new SolidBrush(dopColor);

            for (int i = 0; i < ten; i++)
            {
                PointF s1 = new PointF(_startPosX + 10 * step - 3, _startPosY + 7);
                PointF s2 = new PointF(_startPosX + 10 * step, _startPosY + 2);
                PointF s3 = new PointF(_startPosX + 10 * step + 3, _startPosY + 7);
                PointF[] points = { s1, s2, s3 };
                g.FillPolygon(dopColorBrush, points);


                step++;

                if (step == maxStep)
                {
                    step = 7;
                }
            }

            step = 7;
        }

        private void DrawThirtyPortholes(Graphics g, Color dopColor, float _startPosX, float _startPosY)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopColorBrush = new SolidBrush(dopColor);
            step = 12;

            for (int i = 0; i <= 5; i++)
            {
                PointF s1 = new PointF(_startPosX + 10 * step - 3, _startPosY + 19);
                PointF s2 = new PointF(_startPosX + 10 * step, _startPosY + 14);
                PointF s3 = new PointF(_startPosX + 10 * step + 3, _startPosY + 19);
                PointF[] points = { s1, s2, s3 };
                g.FillPolygon(dopColorBrush, points);

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
