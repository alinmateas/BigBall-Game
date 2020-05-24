using System;
using System.Drawing;

namespace BigBall_Game
{
    public class RepelentBall : Ball
    {
        private int raza;
        private Point pozitie;
        private int vitezaX;
        private int vitezaY;
        private Color culoare;
        private bool exista;

        public RepelentBall()
        {
            Random rnd = new Random();
            raza = rnd.Next(30);
            pozitie.X = rnd.Next(Canvas.Width());
            pozitie.Y = rnd.Next(Canvas.Height());
            vitezaX = rnd.Next(35);
            vitezaY = rnd.Next(35);
            culoare = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            exista = true;
        }
    }
}