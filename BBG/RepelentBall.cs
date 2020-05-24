using System;
using System.Drawing;
using System.Windows.Forms;

namespace BBG
{
    public class RepelentBall
    {
        private int raza;
        private Point pozitie;
        private int vitezaX;
        private int vitezaY;
        private Color culoare;

        public RepelentBall()
        {
            Random rnd = new Random();
            raza = 30;
            pozitie.X = rnd.Next(1000);
            pozitie.Y = rnd.Next(1000);
            vitezaX = rnd.Next(35);
            vitezaY = rnd.Next(35);
            this.culoare = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        public int Raza { get { return raza; } }

        public Point Pozitie { get { return pozitie; } }

        public int VitezaX { get { return vitezaX; } }
        public int VitezaY { get { return vitezaY; } }

        public void ToCanvas(Graphics grp, PictureBox pb, Bitmap bmp)
        {
            pb.BackColor = pb.BackColor;
            grp.FillEllipse(new SolidBrush(culoare), pozitie.X, pozitie.Y, raza, raza);
            grp.DrawEllipse(new Pen(culoare), pozitie.X, pozitie.Y, raza, raza);

            pb.Image = bmp;
        }

        public void Move(PictureBox pictureBox1)
        {
            pozitie.X += vitezaX;
            if (pozitie.X < 0)
            {
                vitezaX = -vitezaX;
            }
            else if (pozitie.X + raza > pictureBox1.Width)
            {
                vitezaX = -vitezaX;
            }

            pozitie.Y += vitezaY;
            if (pozitie.Y < 0)
            {
                vitezaY = -vitezaY;
            }
            else if (pozitie.Y + raza > pictureBox1.Height)
            {
                vitezaY = -vitezaY;
            }
        }
    }
}