using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace starwarsTrenchRun
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int drop;
        int lineUp;
        int lineDown;
        int lineLeft;
        int lineRight;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.White);
            Pen pen = new Pen(Color.White);
            Pen pen2 = new Pen(Color.Lime);
            Font title = new Font("Times New Roman", 20);
            Font messageT = new Font("Courier New", 20);
            Font messageM = new Font("Courier New", 12);

            BackgroundImage.Dispose();
            g.Clear(Color.Black);

            g.DrawString("The Mission", messageT, brush, 20, 20);
            g.DrawString(
              "The battle station is heavily shielded and carries a"
            + "\nfirepower greater than half the star fleet. It's"
            + "\ndefenses are designed around a direct large-scale"
            + "\nassault. A small one-man fighter should be able to"
            + "\npenetrate the outer defense. The Empire doesn't"
            + "\nconsider a small one-man fighter to be any threat,"
            + "\nnor they'd have a tighter defense. You are required"
            + "\nto maneuver straight down a trench and skim the"
            + "\nsurface. The target area is only two meters wide."
            + "\nIt's a small thermal exhaust port, right below the" 
            + "\nmain port. The shaft leads directly to the reactor"
            + "\nsystem. A precise hit will start a chain reaction" 
            + "\nwhich should destroy the station. Only a precise hit"
            + "\nwill set up a chain reaction. The shaft is "
            + "\nray-shielded, so you'll have to use proton torpedoes.", messageM, brush, 20, 80);

            Thread.Sleep(2000);

            pen2.Width = 27;
            lineUp = 283;
            lineDown = 283;
            lineRight = 330;
            lineLeft = 330;           
            x = 675;
            y = 50;
            drop = 115;

            for (int i=0; i<=304;i++)
            {
                if (i>=0 && i<=60)
                {
                    g.Clear(Color.Black);
                    g.DrawEllipse(pen, 180, 130, 300, 300);
                    g.DrawEllipse(pen, 322, 275, 16, 16);
                    g.DrawLine(pen, 330, 153, 330, 275);
                    g.DrawRectangle(pen, 305, 132, 50, 20);

                    g.FillRectangle(brush, x, y, 30, 10);

                    Thread.Sleep(10);
                    x -= 5;
                    y = y + 1;
                }
                else if (i>=60 && i<=106)
                {
                    g.Clear(Color.Black);
                    g.DrawEllipse(pen, 180, 130, 300, 300);
                    g.DrawEllipse(pen, 322, 275, 16, 16);
                    g.DrawLine(pen, 330, 153, 330, 275);
                    g.DrawRectangle(pen, 305, 132, 50, 20);

                    g.FillRectangle(brush, x, 110, 30, 10);

                    Thread.Sleep(10);
                    x--;
                }
                else if (i>=106 && i<=189)
                {
                    g.Clear(Color.Black);
                    g.DrawEllipse(pen, 180, 130, 300, 300);
                    g.DrawEllipse(pen, 322, 275, 16, 16);
                    g.DrawLine(pen, 330, 153, 330, 275);
                    g.DrawRectangle(pen, 305, 132, 50, 20);

                    g.FillRectangle(brush, x, 110, 30, 10);
                    g.FillRectangle(brush, 327, drop, 7, 7);

                    Thread.Sleep(10);
                    x--;
                    drop+=2;
                }
                else if (i >= 189 && i <= 301)
                {
                    g.Clear(Color.Black);
                    g.DrawEllipse(pen, 180, 130, 300, 300);
                    g.DrawEllipse(pen, 322, 275, 16, 16);
                    g.DrawLine(pen, 330, 153, 330, 275);
                    g.DrawRectangle(pen, 305, 132, 50, 20);

                    g.FillRectangle(brush, x, y, 30, 10);

                    g.DrawLine(pen2, 330, 283, lineRight, lineUp);
                    g.DrawLine(pen2, 330, 283, 330, lineUp);
                    g.DrawLine(pen2, 330, 283, lineRight, 283);

                    g.DrawLine(pen2, 330, 283, lineLeft, lineUp);
                    g.DrawLine(pen2, 330, 283, lineLeft, 283);
                    g.DrawLine(pen2, 330, 283, lineLeft, lineDown);
                    g.DrawLine(pen2, 330, 283, 330, lineDown);
                    g.DrawLine(pen2, 330, 283, lineRight, lineDown);

                    Thread.Sleep(10);
                    lineUp--;
                    lineRight++;
                    lineLeft--;
                    lineDown++;
                    x -= 3;
                    y--;
                }
                else if (i>= 301 && i<=304)
                {
                    g.Clear(Color.Black);
                    g.DrawEllipse(pen, 180, 130, 300, 300);
                    g.DrawEllipse(pen, 322, 275, 16, 16);
                    g.DrawLine(pen, 330, 153, 330, 275);
                    g.DrawRectangle(pen, 305, 132, 50, 20);

                    pen2.Color = Color.Black;
                    g.DrawLine(pen2, 330, 283, lineRight, lineUp);
                    g.DrawLine(pen2, 330, 283, 330, lineUp);
                    g.DrawLine(pen2, 330, 283, lineRight, 283);
                    g.DrawLine(pen2, 330, 283, lineLeft, lineUp);
                    g.DrawLine(pen2, 330, 283, lineLeft, 283);
                    g.DrawLine(pen2, 330, 283, lineLeft, lineDown);
                    g.DrawLine(pen2, 330, 283, 330, lineDown);
                    g.DrawLine(pen2, 330, 283, lineRight, lineDown);
                    Thread.Sleep(500);

                    pen2.Color = Color.Lime;
                    g.DrawLine(pen2, 330, 283, lineRight, lineUp);
                    g.DrawLine(pen2, 330, 283, 330, lineUp);
                    g.DrawLine(pen2, 330, 283, lineRight, 283);
                    g.DrawLine(pen2, 330, 283, lineLeft, lineUp);
                    g.DrawLine(pen2, 330, 283, lineLeft, 283);
                    g.DrawLine(pen2, 330, 283, lineLeft, lineDown);
                    g.DrawLine(pen2, 330, 283, 330, lineDown);
                    g.DrawLine(pen2, 330, 283, lineRight, lineDown);
                    Thread.Sleep(500);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.DarkSalmon);
            Font title = new Font("Times New Roman", 20,FontStyle.Bold);
            g.DrawString("TOP SECRET", title, brush, 100, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Center;
        }
    }
}
