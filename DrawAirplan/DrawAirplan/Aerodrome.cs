using System.Drawing;

namespace DrawAirplan
{
    public class Aerodrome<T, U> where T : class, ITransport where U : class, IDop
    {
        private readonly T[] _places;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 380;

        private readonly int _placeSizeHeight = 90;

        /// <param name="picWidth">Рамзер парковки - ширина</param>
        /// <param name="picHeight">Рамзер парковки - высота</param>
        public Aerodrome(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static bool operator +(Aerodrome<T, U> a, T aircraft)
        {
            for (int i = 0; i < a._places.Length; i++)
            {
                if (a._places[i] == null)
                {
                    aircraft.SetPosition(10 + a._placeSizeWidth * (int)(i / (int)(a.pictureHeight / a._placeSizeHeight)), 30 + a._placeSizeHeight * (int)(i % (int)(a.pictureHeight / a._placeSizeHeight)), a.pictureWidth, a.pictureHeight);
                    a._places[i] = aircraft;
                    return true;
                }
            }
            return false;
        }

        public static T operator -(Aerodrome<T, U> a, int index)
        {
            if ((index < a._places.Length) && (index >= 0))
            {
                T aircraft = a._places[index];
                a._places[index] = null;
                return aircraft;
            }
            return null;
        }

        private int CompareHelper()
        {
            int count = 0;
            for (int i = 0; i < _places.Length; i++)
            {
                if (_places[i] == null)
                {
                    count++;
                }
            }
            return count;
        }

        public static bool operator ==(Aerodrome<T, U> a, int ind)
        {
            return (a.CompareHelper() == ind);
        }

        public static bool operator !=(Aerodrome<T, U> a, int ind)
        {
            return (a.CompareHelper() != ind);
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
