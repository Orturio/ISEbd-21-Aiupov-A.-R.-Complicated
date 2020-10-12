using System.Drawing;

namespace DrawAirplan
{
    public interface IDop
    {
        int SetCount{set; }

        int SetForm {set; }

        void DrawElements(Graphics g, Color dopColor, float _startPosX, float _startPosY);
    }
}
