﻿using System.Drawing;

namespace DrawAirplan
{
    interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);

        void MoveTransport(Direction direction);

        void DrawTransport(Graphics g);
    }
}
