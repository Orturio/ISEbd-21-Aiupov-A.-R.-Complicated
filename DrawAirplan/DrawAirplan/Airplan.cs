using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawAirplan
{
    class Airbus
    {
        private float _startPosX; 

        private float _startPosY; 

        private float _pictureWidth; 

        private float _pictureHeight; 

        private readonly int airplanWidth = 220; 

        private readonly int airplanHeight = 100; 

        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }

        public bool Сhassis { private set; get; }        

        DrawPorthole Portholes = new DrawPorthole();

        public Airbus(int maxSpeed, float weight, Color mainColor, Color dopColor,
            bool chassis, int windowCount)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Сhassis = chassis;           
            Portholes.WindowСount = windowCount;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                //вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - airplanWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX + step > airplanWidth / 2.5)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY + step > airplanHeight / 2)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - airplanHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // рисуею задний спойлер самолёта
       
            g.DrawEllipse(pen, _startPosX + 23, _startPosY - 40, 30, 60);
            g.DrawRectangle(pen, _startPosX + 15, _startPosY - 40, 30, 40);
            Brush backSpoiler = new SolidBrush(DopColor);
            g.FillRectangle(backSpoiler, _startPosX + 15, _startPosY - 40, 28, 38);
            g.FillEllipse(backSpoiler, _startPosX + 24, _startPosY - 40, 28, 58);                                
                        
            
            // рисую корпус самолёта
            g.DrawRectangle(pen, _startPosX, _startPosY, 20, 20);
            g.DrawEllipse(pen, _startPosX , _startPosY - 10, 100, 40);
            g.DrawRectangle(pen, _startPosX + 40, _startPosY - 10, 150, 40);
            g.DrawEllipse(pen, _startPosX + 170, _startPosY - 10, 40,40);
            g.DrawRectangle(pen, _startPosX + 190, _startPosY + 10, 20, 20);
            g.DrawEllipse(pen, _startPosX + 195, _startPosY + 5, 30, 25);            
            Brush aircraftBody = new SolidBrush(MainColor);
            g.FillRectangle(aircraftBody, _startPosX + 3, _startPosY, 18, 18);
            g.FillEllipse(aircraftBody, _startPosX + 3, _startPosY - 8, 98, 38);
            g.FillRectangle(aircraftBody, _startPosX + 40, _startPosY - 9, 148, 38);
            g.FillEllipse(aircraftBody, _startPosX + 170, _startPosY - 10, 38, 38);
            g.FillRectangle(aircraftBody, _startPosX + 190, _startPosY + 9, 18, 18);
            g.FillRectangle(aircraftBody, _startPosX + 190, _startPosY + 11,30, 18);
            g.FillEllipse(aircraftBody, _startPosX + 195, _startPosY + 5, 28, 24);
            g.DrawLine(pen, _startPosX + 220, _startPosY + 8, _startPosX + 220, _startPosY + 27);

            //рисую шасси
            if (Сhassis)
            {
                Brush chassis = new SolidBrush(Color.Black);
                g.FillEllipse(chassis, _startPosX + 45, _startPosY + 30, 10, 10);
                g.FillEllipse(chassis, _startPosX + 55, _startPosY + 30, 10, 10);
                g.FillEllipse(chassis, _startPosX + 155, _startPosY + 30, 10, 10);
                g.FillEllipse(chassis, _startPosX + 165, _startPosY + 30, 10, 10);
                g.FillEllipse(chassis, _startPosX + 175, _startPosY + 30, 10, 10);
                g.FillRectangle(chassis, _startPosX + 195, _startPosY + 28, 15, 7);
                g.FillRectangle(chassis, _startPosX + 202, _startPosY + 33, 2, 6);
                g.FillEllipse(chassis, _startPosX + 198, _startPosY + 36, 10, 10);
            }

            // рисую крыло самолёта            
            Brush airplaneWing = new SolidBrush(DopColor);
            PointF p1 = new PointF(_startPosX +50, _startPosY + 10);
            PointF p2 = new PointF(_startPosX + 110, _startPosY +10);
            PointF p3 = new PointF(_startPosX + 140, _startPosY + 40);
            PointF p4 = new PointF(_startPosX + 80, _startPosY + 40);          
            PointF[] points = { p1, p2, p3, p4};
            g.FillPolygon(airplaneWing, points);
            g.DrawPolygon(pen, points);
            Brush turbine = new SolidBrush(Color.Green);
            g.FillRectangle(turbine, _startPosX + 60, _startPosY + 15, 30, 20);
            g.DrawRectangle(pen, _startPosX + 60, _startPosY + 15, 30, 20);

            // рисую двери
            
            g.DrawRectangle(pen, _startPosX + 35, _startPosY + 13, 8, 13);
            g.DrawRectangle(pen, _startPosX + 50, _startPosY - 6, 8, 13);            
            g.DrawRectangle(pen, _startPosX + 170, _startPosY - 6, 8, 13);
            g.DrawRectangle(pen, _startPosX + 175, _startPosY + 13, 8, 13);                      
            
           
            // нарисовал одно окно самолёта
            Brush window = new SolidBrush(MainColor);
            g.FillRectangle(window, _startPosX + 205, _startPosY, 5, 5);
            g.DrawRectangle(pen, _startPosX + 205, _startPosY, 5, 5);

            

            // рисую боковой спойлер самолёта
            
            g.DrawRectangle(pen, _startPosX + 10, _startPosY + 2, 10, 10);
            g.DrawEllipse(pen, _startPosX -3, _startPosY + 2, 20, 10);
            g.DrawEllipse(pen, _startPosX + 15, _startPosY + 2, 15, 10);
            Brush sideSpoiler = new SolidBrush(DopColor);
            g.FillRectangle(sideSpoiler, _startPosX + 10, _startPosY + 2, 10, 10);
            g.FillEllipse(sideSpoiler, _startPosX - 3, _startPosY + 2, 20, 10);
            g.FillEllipse(sideSpoiler, _startPosX + 15, _startPosY + 2, 15, 10);

            Portholes.DrawPortholes(g, DopColor, _startPosX, _startPosY);
        }
    }
}
