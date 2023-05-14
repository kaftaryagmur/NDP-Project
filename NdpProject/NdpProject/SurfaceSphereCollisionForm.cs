using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NdpProject
{
    public partial class SurfaceSphereCollisionForm : Form
    {
        public SurfaceSphereCollisionForm()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X = (int)numericUpDownX.Value;
            int Y = (int)numericUpDownY.Value;
            int Width = (int)numericUpDownWidth.Value;
            int Depth = (int)numericUpDownDepth.Value;

            int X2 = (int)numericUpDownX2.Value;
            int Y2 = (int)numericUpDownY2.Value;
            int Rad = (int)numericUpDownRad2.Value;

            Surface surface = new Surface { X = X, Y = Y, Width = Width, Depth = Depth };
            Sphere sphere = new Sphere { X = X2, Y = Y2, Radius = Rad };

            if (CollisionCheck.SurfaceSphereCollision(surface, sphere))
            {
                MessageBox.Show("The surface and the sphere collide.");
            }
            else
            {
                MessageBox.Show("The surface and the sphere do not collide.");
            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X = (int)numericUpDownX.Value;
            int Y = (int)numericUpDownY.Value;
            int Width = (int)numericUpDownWidth.Value;
            int Depth = (int)numericUpDownDepth.Value;

            int X2 = (int)numericUpDownX2.Value;
            int Y2 = (int)numericUpDownY2.Value;
            int Rad = (int)numericUpDownRad2.Value;

            System.Drawing.Graphics object1, object2;
            object1 = this.CreateGraphics();
            object2 = this.CreateGraphics();

            Pen pen1 = new Pen(System.Drawing.Color.DarkBlue, 5);
            Pen pen2 = new Pen(System.Drawing.Color.DarkCyan, 5);
            Rectangle circle = new Rectangle(X2, Y2, Rad, Rad);
            object1.DrawEllipse(pen1, circle);
            object2.DrawArc(pen2, X2, Y2 + Rad / 3, Rad, Rad / 4, 180, 360);

            System.Drawing.Graphics line1, line2, line3, line4;
            line1 = this.CreateGraphics();
            line2 = this.CreateGraphics();
            line3 = this.CreateGraphics();
            line4 = this.CreateGraphics();
            Pen pen = new Pen(Color.DarkGray, 3);
            line1.DrawLine(pen, X, Y, X + Depth, Y + Depth);
            line2.DrawLine(pen, X + Width, Y, X + Width + Depth, Y + Depth);
            line3.DrawLine(pen, X, Y, X + Width, Y);
            line4.DrawLine(pen, X + Depth, Y + Depth, X + Depth + Width, Y + Depth);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CollisionsForm form = new CollisionsForm();
            form.Show();
            this.Close();
        }
    }
    
}
