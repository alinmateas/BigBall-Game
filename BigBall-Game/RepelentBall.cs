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

        public override bool Exista { get { return exista; } set { exista = value; } }

        public override Point Pozitie { get { return pozitie; } }
        public override int Raza { get { return raza; } set { raza = value; } }

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

        public override void Move()
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


        public override void Inghitire(Ball ball)
        {
            if (ball.GetType() == typeof(MonsterBall))
            {
                Inghitire((MonsterBall)ball);
            }
            else if (ball.GetType() == typeof(RepelentBall))
            {
                Inghitire((RepelentBall)ball);
            }
        }

        public void Inghitire(MonsterBall ball)
        {
            this.Raza = this.Raza / 2;
        }

        public void Inghitire(RepelentBall ball)
        {
            //combinare culori
        }

        public void Inghitire(RegularBall ball)
        {
            ball.VitezaX *= -1;
            ball.VitezaY *= -1;
        }
    }
}