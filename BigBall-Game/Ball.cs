using System.Drawing;

namespace BigBall_Game
{
    public class Ball : IBall
    {
        private int raza;
        private Point pozitie;
        private int vitezaX;
        private int vitezaY;
        private Color culoare;
        private bool exista;

        public bool Exista { get { return exista; } }

        public Point Pozitie { get { return pozitie; } }
        public int Raza { get { return raza; } }

        public void Move()
        {
            pozitie.X += vitezaX;
            if (pozitie.X < 0)
            {
                vitezaX = -vitezaX;
            }
            else if (pozitie.X + raza > Canvas.Width())
            {
                vitezaX = -vitezaX;
            }

            pozitie.Y += vitezaY;
            if (pozitie.Y < 0)
            {
                vitezaY = -vitezaY;
            }
            else if (pozitie.Y + raza > Canvas.Height())
            {
                vitezaY = -vitezaY;
            }
        }
    }
}