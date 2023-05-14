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
    public partial class SphereCollisionForm : Form
    {
        public SphereCollisionForm()
        {
            InitializeComponent();
        }

        public void checkButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X1 = (int)numericUpDownX1.Value;
            int Y1 = (int)numericUpDownY1.Value;
            int Rad1 = (int)numericUpDownRad1.Value;

            int X2 = (int)numericUpDownX2.Value;
            int Y2 = (int)numericUpDownY2.Value;
            int Rad2 = (int)numericUpDownRad2.Value;

            Sphere sphere1 = new Sphere { X = X1, Y = Y1, Radius = Rad1 };
            Sphere sphere2 = new Sphere { X = X2, Y = Y2, Radius = Rad2 };

            if (CollisionCheck.SphereSphereCollision(sphere1, sphere2))
            {
                MessageBox.Show("Two spheres collide.");
            }
            else
            {
                MessageBox.Show("Two spheres do not collide.");
            }
        }

        public void showButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int X1 = (int)numericUpDownX1.Value;
            int Y1 = (int)numericUpDownY1.Value;
            int Rad1 = (int)numericUpDownRad1.Value;

            int X2 = (int)numericUpDownX2.Value;
            int Y2 = (int)numericUpDownY2.Value;
            int Rad2 = (int)numericUpDownRad2.Value;

            System.Drawing.Graphics object1, object2 , object3, object4;
            object1 = this.CreateGraphics();
            object2 = this.CreateGraphics();
            object3 = this.CreateGraphics();
            object4 = this.CreateGraphics();

            Pen pen1 = new Pen(System.Drawing.Color.Chocolate, 5);
            Pen pen2 = new Pen(System.Drawing.Color.Bisque, 5);
            Pen pen3 = new Pen(System.Drawing.Color.DarkBlue, 5);
            Pen pen4 = new Pen(System.Drawing.Color.DarkCyan, 5);

            Rectangle circle1 = new Rectangle(X1, Y1, Rad1, Rad1);
            Rectangle circle2 = new Rectangle(X2, Y2, Rad2, Rad2);

            object1.DrawEllipse(pen1, circle1);
            object2.DrawArc(pen2, X1, Y1 + Rad1 / 3, Rad1, Rad1 / 4, 180, 360);
            object3.DrawEllipse(pen3, circle2);
            object4.DrawArc(pen4, X2, Y2 + Rad2 / 3, Rad2, Rad2 / 4, 180, 360);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CollisionsForm form = new CollisionsForm();
            form.Show();
            this.Close();
        }
    }
}
