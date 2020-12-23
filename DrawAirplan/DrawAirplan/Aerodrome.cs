using System.Drawing;
using System.Collections.Generic;
using System.Collections;

namespace DrawAirplan
{
    public class Aerodrome<T, U> : IEnumerator<T>, IEnumerable<T>  where T : class, ITransport where U : class, IDop
    {
        public readonly List<T> _places;

        private readonly int _maxCount;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 380;

        private readonly int _placeSizeHeight = 90;

        private int _currentIndex;

        public T Current => _places[_currentIndex];

        object IEnumerator.Current => _places[_currentIndex];

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
            _currentIndex = -1;
        }

        public static bool operator +(Aerodrome<T, U> a, T aircraft)
        {
            if (a._places.Count >= a._maxCount)
            {
                throw new AerodromeOverflowException();
            }
            if (a._places.Contains(aircraft))
            {
                throw new AerodromeAlreadyHaveException();
            }
            a._places.Add(aircraft);
            return true;
        }

        public static T operator -(Aerodrome<T, U> a, int index)
        {
            if (index < -1 || index > a._places.Count)
            {
                throw new AerodromeNotFoundException(index);
            }

            T aircraft = a._places[index];
            a._places.RemoveAt(index);
            return aircraft;
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

        public void Sort() => _places.Sort((IComparer<T>)new AircraftComparer());

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            _currentIndex++;
            return (_currentIndex < _places.Count);
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void ClearStages()
        {
            _places.Clear();
        }
    }
}
