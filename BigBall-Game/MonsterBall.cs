using System;
using System.Drawing;

namespace BigBall_Game
{
    public class MonsterBall : Ball
    {
        private int raza;
        private Point pozitie;
        private int vitezaX;
        private int vitezaY;
        private Color culoare;
        private bool exista;

        public MonsterBall()
        {
            Random rnd = new Random();
            raza = rnd.Next(30);
            pozitie.X = rnd.Next(Canvas.Width());
            pozitie.Y = rnd.Next(Canvas.Height());
            vitezaX = 0;
            vitezaY = 0;
            Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            exista = true;
        }

    }
}