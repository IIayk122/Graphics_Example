using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private int x1, y1, x2, y2;
        private int i,k = 0;
        private Point[] pointsArray = new Point[100];
        private Pen pen = new Pen(Color.DarkRed, 2);

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            pointsArray[0].X = 0;
            pointsArray[0].Y = 0;
            for (int cnt=1; cnt<pointsArray.Length;cnt++)
            {
                pointsArray[cnt].X = pointsArray[cnt-1].X+(int)(Size.Width/100);
                pointsArray[cnt].Y=0;
            }
          
            x1 = pointsArray[0].X;
            y1 = pointsArray[0].Y;
            x2 = pointsArray[0].X;
            y2 = pointsArray[0].Y;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            label1.Text = k + " точка";
            g.DrawEllipse(pen, x2, y2, 20, 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if ((i == pointsArray.Length) & (k == 100)) { i = 0; k = 0; }
            x2 = pointsArray[i].X;
            y2 = pointsArray[i].Y;
            i++;
            k++;
           
           Invalidate(); 
        }
    }
}
