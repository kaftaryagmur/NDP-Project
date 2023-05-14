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
    public partial class PointSphereCollisionForm : Form
    {
        public PointSphereCollisionForm()
        {
            InitializeComponent();
        }

        public void checkButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int pX = (int)pointXNumericUpDown.Value;
            int pY = (int)pointYNumericUpDown.Value;

            int X = (int)numericUpDownX.Value;
            int Y = (int)numericUpDownY.Value;
            int Rad = (int)numericUpDownRad.Value;

            Point point = new Point { X = pX, Y = pY };
            Sphere sphere = new Sphere { X = X, Y = Y, Radius = Rad };

            if (CollisionCheck.PointSphereCollision(point, sphere))
            {
                MessageBox.Show("The point and the sphere collide.");
            }
            else
            {
                MessageBox.Show("The point and the sphere do not collide.");
            }
        }
        public void showButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            buttonBack.Visible = true;
            int pX = (int)pointXNumericUpDown.Value;
            int pY = (int)pointYNumericUpDown.Value;

            int X = (int)numericUpDownX.Value;
            int Y = (int)numericUpDownY.Value;
            int Rad = (int)numericUpDownRad.Value;

            System.Drawing.Graphics object1;
            object1 = this.CreateGraphics();
            Pen pen = new Pen(System.Drawing.Color.Black, 2);
            Rectangle circle = new Rectangle(pX, pY, 1, 1);
            object1.DrawEllipse(pen, circle);

            System.Drawing.Graphics object2, object3;
            object2 = this.CreateGraphics();
            object3 = this.CreateGraphics();
            Pen pen2 = new Pen(System.Drawing.Color.Chocolate, 5);
            Pen pen3 = new Pen(System.Drawing.Color.Bisque, 5);

            Rectangle circle2 = new Rectangle(X, Y, Rad, Rad);
            object2.DrawEllipse(pen2, circle2);
            object3.DrawArc(pen3, X, Y + Rad / 3, Rad, Rad / 4, 180, 360);
        }

        public void radioButtonPointSphere_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPointSphere.Checked)
            {
                MessageBox.Show("Thank you!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CollisionsForm form = new CollisionsForm();
            form.Show();
            this.Close();
        }
    }
}
