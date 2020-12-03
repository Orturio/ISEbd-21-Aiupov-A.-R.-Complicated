using System.Drawing;
using System.Collections.Generic;

namespace DrawAirplan
{
    public class Aerodrome<T, U> where T : class, ITransport where U : class, IDop
    {
        public readonly List<T> _places;

        private readonly int _maxCount;

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
            _places = new List<T>();
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static bool operator +(Aerodrome<T, U> a, T aircraft)
        {
            if (a._places.Count >= a._maxCount)
            {
                return false;
            }
            a._places.Add(aircraft);
            return true;
        }

        public static T operator -(Aerodrome<T, U> a, int index)
        {
            if (index < -1 || index > a._places.Count)
            {
                return null;
            }

            else if (a._places.Count > index)
            {
                T aircraft = a._places[index];
                a._places.RemoveAt(index);
                return aircraft;
            }
            return null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i].SetPosition(5 + i / 4 * _placeSizeWidth + 5, i % 4 *
_placeSizeHeight + 30, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
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

        public T this[int ind]
        {
            get
            {
                if (ind > -1 && ind < _places.Count)
                {
                    return _places[ind];
                }
                else
                {
                    return null;
                }
            }
        }

        public void ClearStages()
        {
            _places.Clear();
        }
    }
}
