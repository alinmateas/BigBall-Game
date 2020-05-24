using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);

            

            pictureBox1.Image = bmp;
        }

        private void tmrMoveBall_Tick(object sender, EventArgs e)
        {
            foreach (RepelentBall ball in listaRepelent)
            {
                ball.Move(pictureBox1);
            }

            foreach (RepelentBall ball in listaRepelent)
                {
                    ball.ToCanvas(grp, pictureBox1, bmp);
                }

        }
        List<RepelentBall> listaRepelent;
        private void button1_Click(object sender, EventArgs e)
        {
            int numarRepelent = int.Parse(textBox1.Text);
            int numarMonster = int.Parse(textBox2.Text);
            int numarRegular = int.Parse(textBox1.Text);

            listaRepelent = new List<RepelentBall>();
            for (int i = 0; i < numarRepelent; i++)
            {
                listaRepelent.Add(new RepelentBall());
            }

            foreach (RepelentBall ball in listaRepelent)
            {
                ball.ToCanvas(grp, pictureBox1, bmp);
            }
            tmrMoveBall.Enabled = true;
        }
    }
}
