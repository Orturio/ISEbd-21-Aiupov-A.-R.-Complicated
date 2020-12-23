using System.Drawing;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DrawAirplan
{
    public class Airbus : Aircraft, IEquatable<Airbus>, IComparable<Airbus>, IEnumerator<object>, IEnumerable<object>
    {
        public Color DopColor { private set; get; }

        IDop Portholes;

        public int PortholeCount { private set; get; }

        public string PortholeForm { private set; get; }

        private int _currentIndex = -1;

        public new List<Object> objectProperties = new List<Object>();

        public new object Current => objectProperties[_currentIndex];

        object IEnumerator<Object>.Current => objectProperties[_currentIndex];

        public Airbus(int maxSpeed, float weight, Color mainColor, Color dopColor, int PortholeCount, string portholeForm) :
            base(maxSpeed, weight, mainColor, 220, 100)
        {
            DopColor = dopColor;
            PortholeForm = portholeForm;

            if (PortholeForm == "DrawPortholeCircle")
            {
                Portholes = new DrawPortholeCircle(PortholeCount);

            }
            else if (PortholeForm == "DrawPortholeRectangle")
            {
                Portholes = new DrawPortholeRectangle(PortholeCount);
            }
            else
            {
                Portholes = new DrawPortholeTriangle(PortholeCount);
            }
            objectProperties.Add(MaxSpeed);
            objectProperties.Add(Weight);
            objectProperties.Add(MainColor);
            objectProperties.Add(DopColor);
            objectProperties.Add(PortholeCount);
            objectProperties.Add(portholeForm);
        }

        public Airbus(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                PortholeCount = Convert.ToInt32(strs[4]);
                PortholeForm = strs[5];
                if (PortholeForm == "DrawPortholeCircle")
                {
                    Portholes = new DrawPortholeCircle(PortholeCount);

                }
                else if (PortholeForm == "DrawPortholeRectangle")
                {
                    Portholes = new DrawPortholeRectangle(PortholeCount);
                }
                else
                {
                    Portholes = new DrawPortholeTriangle(PortholeCount);
                }
                objectProperties.Add(MaxSpeed);
                objectProperties.Add(Weight);
                objectProperties.Add(MainColor);
                objectProperties.Add(DopColor);
                objectProperties.Add(PortholeCount);
                objectProperties.Add(PortholeForm);
            }
        }

        public void SetPortholes(IDop porthole)
        {
            Portholes = porthole;
            PortholeForm = Portholes.GetType().Name;
        }

        public void SetPortholesCount(int portholeCount)
        {
            PortholeCount = portholeCount;
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush dopBrush = new SolidBrush(DopColor);

            base.DrawTransport(g);
                 
            g.FillEllipse(dopBrush, _startPosX + 45, _startPosY + 30, 10, 10);
            g.FillEllipse(dopBrush, _startPosX + 55, _startPosY + 30, 10, 10);
            g.FillEllipse(dopBrush, _startPosX + 155, _startPosY + 30, 10, 10);
            g.FillEllipse(dopBrush, _startPosX + 165, _startPosY + 30, 10, 10);
            g.FillEllipse(dopBrush, _startPosX + 175, _startPosY + 30, 10, 10);         
          
            if (Portholes != null) 
            {
                Portholes.DrawElements(g, DopColor, _startPosX, _startPosY);
            }                     
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{PortholeCount}{separator}{PortholeForm}";
        }

        public bool Equals(Airbus other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (PortholeCount != other.PortholeCount)
            {
                return false;
            }
            if (PortholeForm != other.PortholeForm)
            {
                return false;
            }   
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Airbus carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }

        public int CompareTo(Airbus a)
        {
            var res = base.CompareTo(a);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != a.DopColor)
            {
                return DopColor.Name.CompareTo(a.DopColor.Name);
            }
            if (PortholeCount != a.PortholeCount)
            {
                return PortholeCount.CompareTo(a.PortholeCount);
            }
            if (PortholeForm != a.PortholeForm)
            {
                return PortholeForm.CompareTo(a.PortholeForm);
            }           
            return 0;
        }

        public new void Dispose() { }

        public new bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < 7;
        }

        public new void Reset()
        {
            _currentIndex = -1;
        }

        public new IEnumerator<object> GetEnumerator()
        {
            return (IEnumerator<object>)objectProperties;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
